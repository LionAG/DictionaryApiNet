using Newtonsoft.Json;

namespace DictionaryApiNet.Model
{
    public class WordDefinition
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public string Origin { get; set; }

        [JsonProperty("phonetic", NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonetic { get; set; }

        [JsonProperty("phonetics")]
        public Phonetic[] Phonetics { get; set; }
        
        [JsonProperty("meanings")]
        public Meaning[] Meanings { get; set; }

        [JsonProperty("license")]
        public License License { get; set; }

        [JsonProperty("sourceUrls")]
        public string[] SourceUrls { get; set; }

        public static WordDefinition? FromJson(string json)
        {
            var deserialized = JsonConvert.DeserializeObject<WordDefinition[]>(json);

            if (deserialized != null && deserialized.Length > 0)
                return deserialized[0];

            return null;
        }

        public WordDefinition(string word, string origin, string? phonetic, Phonetic[] phonetics, Meaning[] meanings, License license, string[] sourceUrls)
        {
            Word = word;
            Origin = origin;
            Phonetic = phonetic;
            Phonetics = phonetics;
            Meanings = meanings;
            License = license;
            SourceUrls = sourceUrls;
        }
    }
}
