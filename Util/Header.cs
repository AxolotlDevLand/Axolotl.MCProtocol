namespace Axolotl.Util;

public class Header
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Uuid { get; set; }
        public List<int> Version { get; set; }
        public List<int> MinEngineVersion { get; set; }
    }