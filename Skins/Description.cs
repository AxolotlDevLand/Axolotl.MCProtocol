namespace Axolotl.Skins;

using Newtonsoft.Json;

public class Description : ICloneable
    {
        public string Identifier { get; set; }

        [JsonProperty(PropertyName = "texture_height")]
        public int TextureHeight { get; set; }

        [JsonProperty(PropertyName = "texture_width")]
        public int TextureWidth { get; set; }

        [JsonProperty(PropertyName = "visible_bounds_height")]
        public float VisibleBoundsHeight { get; set; }

        [JsonProperty(PropertyName = "visible_bounds_offset")]
        public float[] VisibleBoundsOffset { get; set; }

        [JsonProperty(PropertyName = "visible_bounds_width")]
        public float VisibleBoundsWidth { get; set; }

        public object Clone()
            {
                Description clone = (Description)MemberwiseClone();
                clone.VisibleBoundsOffset = VisibleBoundsOffset?.Clone() as float[];
                return clone;
            }
    }