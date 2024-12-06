namespace Axolotl.Nbts;

using fNbt;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class NbtIntConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(NbtLong) || objectType == typeof(NbtInt) ||
                       objectType == typeof(NbtShort) || objectType == typeof(NbtByte) ||
                       objectType == typeof(NbtByteArray) || objectType == typeof(NbtFloat);
            }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
            }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
            {
                JToken token = JToken.Load(reader);
                if (objectType == typeof(NbtLong)) return token.Value<long>();

                if (objectType == typeof(NbtInt)) return token.Value<int>();

                if (objectType == typeof(NbtShort)) return token.Value<short>();

                if (objectType == typeof(NbtByte)) return token.Value<byte>();

                if (objectType == typeof(NbtByteArray)) return token.Value<byte[]>();

                if (objectType == typeof(NbtFloat)) return token.Value<float>();

                return 0;
            }
    }