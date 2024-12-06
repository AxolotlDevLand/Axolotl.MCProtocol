namespace Axolotl.Skins;

using Newtonsoft.Json;

public class Locators
    {
        [JsonProperty(PropertyName = "lead_hold")]
        public float[] LeadHold { get; set; }
    }