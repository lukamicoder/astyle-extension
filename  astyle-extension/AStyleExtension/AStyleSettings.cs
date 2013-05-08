using System;

namespace AStyleExtension {
    [Serializable]
    public class AStyleSettings {
        public string CppCommandLine { get; set; }
        public string CsCommandLine { get; set; }
        public string Version { get; set; }
    }
}
