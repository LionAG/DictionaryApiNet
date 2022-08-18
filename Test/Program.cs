using DictionaryApiNet;

var dictapi = new DictionaryApi();
var wordData = await dictapi.GetWordDefinitionAsync("Dog");

if(wordData != null)
{
    Console.WriteLine($"{wordData.Word} [{wordData.Phonetics[0].Text}] - {wordData.Meanings[0].Definitions[0].DefinitionText}");
}

Console.ReadKey();