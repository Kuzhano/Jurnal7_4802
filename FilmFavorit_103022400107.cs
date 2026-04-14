using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_BNP
{
    internal class FilmFavorit_103022400107
    {

        public class film
        {
            public string title { get; set; }

            public string director { get; set; }

            public string year { get; set; }

            public string genre { get; set; }

            public float rating { get; set; }

            public int durationMinutes { get; set; }

            public string durationSeconds { get; set; }

            public bool isWatched { get; set; }

            public void ReadJSON ()
            {
                string json = File.ReadAllText("jurnal7_1_103022400107.json");
                var filmFav = JsonSerializer.Deserialize<FilmFavorit_103022400107>(json);

                Console.WriteLine($"Title: {title}\nDirector: {director}\n" + $"Year: {year}\nGenre: {genre}\n" + $"Rating: {rating}\n" + $"Duration (Minutes): {durationMinutes}\n" + $"Has Watched: {isWatched}");
            }
        }
    }
}
