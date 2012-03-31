using System;
using System.Runtime.InteropServices;

namespace AStyleExtension {
    /// AStyleInterface contains methods to call the Artistic Style formatter.
    public class AStyleInterface {
        // Cannot use String as a return value because Mono runtime will attempt to
        // free the returned pointer resulting in a runtime crash.
        private AStyleErrorDelegate _aStyleError;
        private AStyleMemAllocDelegate _aStyleMemAlloc;

        /// Declare callback functions
        public AStyleInterface() {
            _aStyleMemAlloc = OnAStyleMemAlloc;
            _aStyleError = OnAStyleError;
        }

        [DllImport("astyle/astyle", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr AStyleGetVersion();

        // Cannot use String as a return value because Mono runtime will attempt to
        // free the returned pointer resulting in a runtime crash.
        [DllImport("astyle/astyle", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr AStyleMain
            (
            [MarshalAs(UnmanagedType.LPStr)] String sIn,
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
                IntPtr pText = AStyleMain(textIn, options, _aStyleError, _aStyleMemAlloc);
                if (pText != IntPtr.Zero) {
                    sTextOut = Marshal.PtrToStringAnsi(pText);
                    Marshal.FreeHGlobal(pText);
                }
            } catch (BadImageFormatException e) {
                Console.WriteLine(e.ToString());
                Console.WriteLine("You may be mixing 32 and 64 bit code!");
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return sTextOut;
        }

        /// Get the Artistic Style version number.
        /// Does not need to terminate on error.
        /// But the exception must be handled when a function is called.
        public String GetVersion() {
            String sVersion = String.Empty;
            try {
                IntPtr pVersion = AStyleGetVersion();
                if (pVersion != IntPtr.Zero) {
                    sVersion = Marshal.PtrToStringAnsi(pVersion);
                }
            } catch (BadImageFormatException e) {
                Console.WriteLine(e.ToString());
                Console.WriteLine("You may be mixing 32 and 64 bit code!");
                Console.WriteLine("The program has terminated!");
                Environment.Exit(1);
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                Console.WriteLine("The program has terminated!");
                Environment.Exit(1);
            }
            return sVersion;
        }

        // Allocate the memory for the Artistic Style return string.
        private IntPtr OnAStyleMemAlloc(int size) {
            return Marshal.AllocHGlobal(size);
        }

        // Display errors from Artistic Style .
        private void OnAStyleError(int errorNumber, String errorMessage) {
            Console.WriteLine("AStyle error " + errorNumber + " - " + errorMessage);
        }

        #region Nested type: AStyleErrorDelegate

        private delegate void AStyleErrorDelegate(int errorNum, [MarshalAs(UnmanagedType.LPStr)] String error);

        #endregion

        #region Nested type: AStyleMemAllocDelegate

        private delegate IntPtr AStyleMemAllocDelegate(int size);

        #endregion
    }
}