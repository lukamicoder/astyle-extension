using System;
using System.Runtime.InteropServices;

namespace AStyleExtension {
	public class AStyleInterface {
		public delegate void AStyleErrorHandler(object sender, AStyleErrorArgs e);
		public event AStyleErrorHandler ErrorRaised;

		private readonly AStyleErrorDelegate _aStyleError;
		private readonly AStyleMemAllocDelegate _aStyleMemAlloc;

		private delegate void AStyleErrorDelegate(int errorNum, [MarshalAs(UnmanagedType.LPStr)] String error);
		private delegate IntPtr AStyleMemAllocDelegate(int size);

		public AStyleInterface() {
			_aStyleMemAlloc = OnAStyleMemAlloc;
			_aStyleError = OnAStyleError;
		}

		[DllImport("astyle/astyle", CharSet = CharSet.Unicode)]
		private static extern IntPtr AStyleMainUtf16(
		    [MarshalAs(UnmanagedType.LPWStr)] String sIn,
		    [MarshalAs(UnmanagedType.LPWStr)] String sOptions,
		    AStyleErrorDelegate errorFunc,
		    AStyleMemAllocDelegate memAllocFunc
		);

		/// Call the AStyleMain function in Artistic Style.
		/// An empty string is returned on error.
		public String FormatSource(String textIn, String options) {
			// Return the allocated string
			// Memory space is allocated by OnAStyleMemAlloc, a callback function
			String sTextOut = String.Empty;
			try {
				IntPtr pText = AStyleMainUtf16(textIn, options, _aStyleError, _aStyleMemAlloc);
				if (pText != IntPtr.Zero) {
					sTextOut = Marshal.PtrToStringUni(pText);
					Marshal.FreeHGlobal(pText);
				}
			} catch (Exception e) {
                OnAStyleError(this, new AStyleErrorArgs(e.ToString()));
			}

			return sTextOut;
		}

		// Allocate the memory for the Artistic Style return string.
		private IntPtr OnAStyleMemAlloc(int size) {
			return Marshal.AllocHGlobal(size);
		}

		private void OnAStyleError(object source, AStyleErrorArgs args) {
            ErrorRaised?.Invoke(source, args);
        }

		private void OnAStyleError(int errorNumber, String errorMessage) {
			OnAStyleError(this, new AStyleErrorArgs(errorNumber + ": " + errorMessage));
		}
	}
}