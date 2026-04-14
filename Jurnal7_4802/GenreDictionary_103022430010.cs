using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class GenreDictionary_103022430010
{
    public string category { get; set; }
    public string id { get; set; }
    public string GenreInfo { get; set; }
    public string description { get; set; }
    public List<GenreDictionary_103022430010> genreDictionary { get; set; }
    public List<GenreDictionary_103022430010> genreInfo { get; set; }
    public List<GenreDictionary_103022430010> popularMovies { get; set; }


    public void ReadJSON(string jsonString)
    {
        try
        {
            jsonString = File.ReadAllText(jsonString);

            var gd = JsonSerializer.Deserialize<GenreDictionary_103022430010>(jsonString);

            Console.WriteLine($"ID: {gd.id} \nName {gd.category} \nDescription: {gd.description}");

        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The JSON file was not found.");
        }
    }
}