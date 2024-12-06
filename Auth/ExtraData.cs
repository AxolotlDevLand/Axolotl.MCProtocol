namespace Axolotl.Auth;

using System.Text.Json.Serialization;

public class ExtraData
    {
        public string Identity { get; set; }

        public string DisplayName { get; set; }

        [JsonPropertyName("XUID")] public string XUID { get; set; }

        public string TitleId { get; set; }
        public string sandboxId { get; set; }
    }