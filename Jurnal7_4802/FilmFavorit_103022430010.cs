using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class FilmFavorit_103022430010
{
    public string title { get; set; }
    public string director { get; set; }
    public string year { get; set; }
    public string genre { get; set; }
    public string rating { get; set; }
    public string durationMinutes { get; set; }
    public bool isWatched { get; set; }

    public void ReadJSON(string jsonString)
    {
        try
        {
            jsonString = File.ReadAllText(jsonString);

            var ff = JsonSerializer.Deserialize<FilmFavorit_103022430010>(jsonString);

            if (ff != null)
            {
                Console.WriteLine($"Title : {ff.title}");
                Console.WriteLine($"Direktor : {ff.director}");
                Console.WriteLine($"Tahun Rilis : {ff.year}");
                Console.WriteLine($"Genre : {ff.genre}");
                Console.WriteLine($"Rating : {ff.rating}");
                Console.WriteLine($"Durasi : {ff.durationMinutes}");
                Console.WriteLine($"Status : {ff.isWatched}");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The JSON file was not found.");
        }
    }
}