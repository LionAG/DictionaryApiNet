using DictionaryApiNet.Model;

namespace DictionaryApiNet
{
    public class DictionaryApi
    {
        private readonly string Endpoint = "https://api.dictionaryapi.dev/api/v2/entries/en/";
        private readonly HttpClient Client = new();

        public DictionaryApi(string endpoint = "https://api.dictionaryapi.dev/api/v2/entries/en/")
        {
            Endpoint = endpoint;
        }

        public DictionaryApi(string endpoint, HttpClient client) : this(endpoint)
        {
            Client = client;
        }

        ~DictionaryApi()
        {
            Client.Dispose();
        }

        private string GetRequestAddress(string requestedWord)
        {
            return $"{Endpoint}{requestedWord}";
        }

        /// <summary>
        /// Get word definition.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public WordDefinition? GetWordDefinition(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException($"'{nameof(word)}' cannot be null or empty.", nameof(word));
            }

            return GetWordDefinitionAsync(word).Result;
        }

        /// <summary>
        /// Asynchronously get word definition.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<WordDefinition?> GetWordDefinitionAsync(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException($"'{nameof(word)}' cannot be null or empty.", nameof(word));
            }

            var req = GetRequestAddress(word);
            var data = await Client.GetStringAsync(req);
            
            return WordDefinition.FromJson(data);
        }
    }
}