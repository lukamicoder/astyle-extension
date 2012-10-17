using System;

namespace AStyleExtension {
    public class AStyleErrorArgs : EventArgs {
        public string Message { get; set; }

        public AStyleErrorArgs(string message) {
            Message = message;
        }
    }
}
