using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Modul7Jurnal
{
    internal class GlossaryItem103082400025
    {
        public Glossary glossary { get; set; }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_3_103082400025.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = JsonSerializer.Deserialize<GlossaryItem103082400025>(json, options);

            Console.WriteLine("=== DATA GLOSS ENTRY ===");

            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine($"ID: {entry.ID}");
            Console.WriteLine($"SortAs: {entry.SortAs}");
            Console.WriteLine($"Term: {entry.GlossTerm}");
            Console.WriteLine($"Acronym: {entry.Acronym}");
            Console.WriteLine($"Abbrev: {entry.Abbrev}");
            Console.WriteLine($"Definition: {entry.GlossDef.para}");
            Console.WriteLine($"GlossSee: {entry.GlossSee}");

            Console.WriteLine("See Also:");
            foreach (var item in entry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}