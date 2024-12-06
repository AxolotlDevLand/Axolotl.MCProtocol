namespace Axolotl;

using Newtonsoft.Json;

public class Itemstates : List<Itemstate>
    {
        public static Itemstates FromJson(string json)
            {
                return JsonConvert.DeserializeObject<Itemstates>(json);
            }
    }