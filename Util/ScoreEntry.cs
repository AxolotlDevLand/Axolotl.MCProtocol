namespace Axolotl.Util;

public abstract class ScoreEntry
    {
        public long Id { get; set; }
        public string ObjectiveName { get; set; }
        public uint Score { get; set; }
    }