using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class Watchlist_103022430010
{
    public string watchlistName { get; set; }
    public string createdBy { get; set; }
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public float rating { get; set; }
    public List<Watchlist_103022430010> movies { get; set; }

    public void ReadJSON(string jsonString)
    {
        try
        {
            jsonString = File.ReadAllText(jsonString);

            var wl = JsonSerializer.Deserialize<Watchlist_103022430010>(jsonString);

            Console.WriteLine($"Watchlist Name: {wl.watchlistName}\nCreated By: {wl.createdBy}\nMovies:");

            foreach (var item in wl.movies)
            {
                Console.WriteLine($"{item.id} {item.title} ({item.year} - {item.rating})");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The JSON file was not found.");
        }
    }
}