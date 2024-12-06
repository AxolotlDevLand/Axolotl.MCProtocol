namespace Axolotl.Skins;

using Newtonsoft.Json;

public class SkinResourcePatch : ICloneable
    {
        public GeometryIdentifier Geometry { get; set; }

        [JsonProperty(PropertyName = "persona_reset_resource_definitions")]
        public bool PersonaResetResourceDefinitions { get; set; }

        public object Clone()
            {
                SkinResourcePatch cloned = (SkinResourcePatch)MemberwiseClone();
                cloned.Geometry = (GeometryIdentifier)Geometry?.Clone();

                return cloned;
            }
    }