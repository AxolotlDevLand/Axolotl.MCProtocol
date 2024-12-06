namespace Axolotl.Util;

public class manifestStructure
    {
        public int FormatVersion { get; set; }
        public Header Header { get; set; }
        public List<Module> Modules { get; set; }
    }