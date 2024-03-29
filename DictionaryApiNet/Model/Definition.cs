﻿using Newtonsoft.Json;

namespace DictionaryApiNet.Model
{
    public class Definition
    {
        [JsonProperty("definition")]
        public string DefinitionText { get; set; }

        [JsonProperty("synonyms")]
        public string[] Synonyms { get; set; }

        [JsonProperty("antonyms")]
        public object[] Antonyms { get; set; }

        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public string? Example { get; set; }

        public Definition(string definitionText, string[] synonyms, object[] antonyms, string? example)
        {
            DefinitionText = definitionText;
            Synonyms = synonyms;
            Antonyms = antonyms;
            Example = example;
        }
    }
}
