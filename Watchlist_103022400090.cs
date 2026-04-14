using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_BNP
{
    internal class Watchlist_103022400090
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public float rating { get; set; }
        public List<Watchlist_103022400090> movies { get; set; }

        public void readJSON()
        {
            string json = File.ReadAllText("jurnal7_2_103022400090.json");
            Watchlist_103022400090 watchlist = JsonSerializer.Deserialize<Watchlist_103022400090>(json);
            Console.WriteLine($"Watchlist Name: {watchlist.watchlistName}\nCreated By: {watchlist.createdBy}\nMovies:");

            foreach (var item in watchlist.movies)
            {
                Console.WriteLine($"{item.id} {item.title} ({item.year} - {item.rating})");
            }

        }
    }
}
