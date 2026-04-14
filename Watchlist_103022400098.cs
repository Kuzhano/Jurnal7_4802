using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

public class Watchlist_103022400098
{
    public string watchlistName { get; set; }
    public string createdBy { get; set; }
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public float rating { get; set; }
    public List<Watchlist_103022400098> movies { get; set; }

    public void ReadJSON(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Error: File '{filePath}' tidak ditemukan di {Directory.GetCurrentDirectory}");
                return;
            }
;
            Watchlist_103022400098 watchlist = JsonSerializer.Deserialize<Watchlist_103022400098>(filePath);
            Console.WriteLine($"Watchlist Name: {watchlist.watchlistName}\nCreated By: {watchlist.createdBy}\nMovies:");

            foreach (var item in watchlist.movies)
            {
                Console.WriteLine($"{item.id} {item.title} ({item.year} - {item.rating})");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi Kesalahab: {ex.Message}");
        }
    }
}