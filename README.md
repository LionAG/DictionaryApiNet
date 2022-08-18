# DictionaryApiNet
A .NET library for https://dictionaryapi.dev

How to use:

```C#
using DictionaryApiNet;

var dictapi = new DictionaryApi();
var wordData = await dictapi.GetWordDefinitionAsync("dog");

if(wordData != null)
{
    Console.WriteLine($"{wordData.Word} [{wordData.Phonetics[0].Text}] - {wordData.Meanings[0].Definitions[0].DefinitionText}");
}

Console.ReadKey();
```
