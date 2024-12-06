namespace Axolotl.Skins;

using Newtonsoft.Json;

public class GeometryIdentifier : ICloneable
    {
        public string Default { get; set; }

        [JsonProperty(PropertyName = "animated_face")]
        public string AnimatedFace { get; set; }

        public object Clone()
            {
                return MemberwiseClone();
            }
    }