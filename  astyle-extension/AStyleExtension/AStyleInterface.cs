using System;
using System.Runtime.InteropServices;
using System.Text;

//Code is based on http://astyle.sourceforge.net/develop/sharp.html
//Credit goes to Channing Dai for providing a patch to support unicode.

namespace AStyleExtension {
    public class AStyleInterface {
        public delegate void AStyleErrorHandler(object sender, AStyleErrorArgs e);
        public event AStyleErrorHandler ErrorRaised;

        private AStyleErrorDelegate _aStyleError;
        private AStyleMemAllocDelegate _aStyleMemAlloc;

        private delegate void AStyleErrorDelegate(int errorNum, [MarshalAs(UnmanagedType.LPStr)] String error);
        private delegate IntPtr AStyleMemAllocDelegate(int size);

        public AStyleInterface() {
            _aStyleMemAlloc = OnAStyleMemAlloc;
            _aStyleError = OnAStyleError;
        }

        [DllImport("astyle/astyle", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr AStyleMain (
            IntPtr pTextIn,
            [MarshalAs(UnmanagedType.LPStr)] String sOptions,
            AStyleErrorDelegate errorFunc,
            AStyleMemAllocDelegate memAllocFunc
        );

        /// Call the AStyleMain function in Artistic Style.
        /// An empty string is returned on error.
        public String FormatSource(String textIn, String options) {
            // Return the allocated string
            // Memory space is allocated by OnAStyleMemAlloc, a callback function from AStyle
            String sTextOut = String.Empty;
            try {
                IntPtr pTextIn = NativeUtf8FromString(textIn);
                IntPtr pTextOut = AStyleMain(pTextIn, options, _aStyleError, _aStyleMemAlloc);

                Marshal.FreeHGlobal(pTextIn);

                if (pTextOut != IntPtr.Zero) {
                    sTextOut = StringFromNativeUtf8(pTextOut);
                    Marshal.FreeHGlobal(pTextOut);
                }
            } catch (Exception e) {
                OnAStyleError(this, new AStyleErrorArgs(e.ToString()));
            }

            return sTextOut;
        }

        /// Code from http://stackoverflow.com/questions/10773440/conversion-in-net-native-utf-8-managed-string
        private IntPtr NativeUtf8FromString(string managedString) {
            int len = Encoding.UTF8.GetByteCount(managedString);
            byte[] buffer = new byte[len + 1];
            Encoding.UTF8.GetBytes(managedString, 0, managedString.Length, buffer, 0);
            IntPtr nativeUtf8 = Marshal.AllocHGlobal(buffer.Length);
            Marshal.Copy(buffer, 0, nativeUtf8, buffer.Length);

            return nativeUtf8;
        }

        private string StringFromNativeUtf8(IntPtr pointer) {
            int len = 0;
            while (Marshal.ReadByte(pointer, len) != 0) {
                ++len;
            }

            if (len == 0) {
                return String.Empty;
            }

            byte[] buffer = new byte[len];

            Marshal.Copy(pointer, buffer, 0, buffer.Length);

            return Encoding.UTF8.GetString(buffer);
        }

        // Allocate the memory for the Artistic Style return string.
        private IntPtr OnAStyleMemAlloc(int size) {
            return Marshal.AllocHGlobal(size);
        }

        private void OnAStyleError(object source, AStyleErrorArgs args) {
            AStyleErrorHandler tmp = ErrorRaised;
            if (tmp != null) {
                tmp(source, args);
            }
        }

        private void OnAStyleError(int errorNumber, String errorMessage) {
            OnAStyleError(this, new AStyleErrorArgs(errorNumber + ": " + errorMessage));
        }
    }
}