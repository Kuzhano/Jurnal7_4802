using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace Modul7_BNP
{
    internal class GenreDictionary_103022400098
    {
        public string category { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<GenreDictionary_103022400098> GenreDictionary { get; set; }
        public List<GenreDictionary_103022400098> GenreInfo { get; set; }
        public List<GenreDictionary_103022400098> popularMovies { get; set; }

        public void readJSON(string filePath)
        {
            GenreDictionary_103022400098 genreDict = JsonSerializer.Deserialize<GenreDictionary_103022400098>(filePath);
            foreach (var item in genreDict.GenreDictionary)
            {
                foreach (var item1 in item.GenreInfo)
                {
                    Console.WriteLine($"ID: {item1.id}\nName: {item1.name}\nDescription: {item1.description}\nPopular Movies:");
                    for (int i = 0; i < item1.popularMovies.Count; i++)
                    {
                        Console.WriteLine($"{item1.popularMovies[i].name}");
                    }
                }
            }
        }
    }
}
