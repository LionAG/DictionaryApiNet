using Newtonsoft.Json;

namespace DictionaryApiNet.Model
{
    public class Phonetic
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public string? Audio { get; set; }

        [JsonProperty("sourceUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string? SourceUrl { get; set; }

        [JsonProperty("license")]
        public License License { get; set; }

        public Phonetic(string text, string? audio, string? sourceUrl, License license)
        {
            Text = text;
            Audio = audio;
            SourceUrl = sourceUrl;
            License = license;
        }
    }
}
