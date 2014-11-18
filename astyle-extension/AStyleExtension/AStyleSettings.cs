using System;

namespace AStyleExtension {
    [Serializable]
    public class AStyleSettings {
        public bool CppFormatOnSave { get; set; }
        public bool CsFormatOnSave { get; set; }
        public string CppCommandLine { get; set; }
        public string CsCommandLine { get; set; }
        public string Version { get; set; }
    }
}
