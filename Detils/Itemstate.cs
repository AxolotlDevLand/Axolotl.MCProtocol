namespace Axolotl;

using Newtonsoft.Json;

public class Itemstate
    {
        [JsonProperty("runtime_id")] public short Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("component_based")] public bool ComponentBased { get; set; }
        //public int RuntimeId { get; set; }
    }