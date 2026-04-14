using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_BNP
{
    internal class Watchlist_103022400020
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public float rating { get; set; }
        public List<Watchlist_103022400020> movies { get; set; }

        public void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_2_103022400020.json");
            Watchlist_103022400020 film = JsonSerializer.Deserialize<Watchlist_103022400020>(json);
            Console.WriteLine($"Watchlist Name : {film.watchlistName} \nCreated By : {film.createdBy} \nMovies: ");
            int num = 1;
            foreach(var wl in film.movies)
            {
                Console.WriteLine($"{wl.id} {wl.title} ({wl.year} - {wl.rating})");
                num++;
            }
        }
    }
}
