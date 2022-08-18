using Newtonsoft.Json;

namespace DictionaryApiNet.Model
{
    public class Meaning
    {
        [JsonProperty("partOfSpeech")]
        public string PartOfSpeech { get; set; }

        [JsonProperty("definitions")]
        public Definition[] Definitions { get; set; }

        [JsonProperty("synonyms")]
        public string[] Synonyms { get; set; }

        [JsonProperty("antonyms")]
        public string[] Antonyms { get; set; }

        public Meaning(string partOfSpeech, Definition[] definitions, string[] synonyms, string[] antonyms)
        {
            PartOfSpeech = partOfSpeech;
            Definitions = definitions;
            Synonyms = synonyms;
            Antonyms = antonyms;
        }
    }
}
