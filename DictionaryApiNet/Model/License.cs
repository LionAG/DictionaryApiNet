using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DictionaryApiNet.Model
{
    public class License
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public License(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
