using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;

namespace Modul7_BNP
{
    internal class FilmFavorit_103022400020
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int genredurationMinutes { get; set; }
        public bool isWatched { get; set; }

        public void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103022400020.json");
            var film = JsonSerializer.Deserialize<FilmFavorit_103022400020>(json);
            Console.WriteLine($"Judul {film.title}, director {film.director}, tahun {film.year}, genre {film.genre}, rating {film.rating}" +
                $", durasi {film.genredurationMinutes}, Sudah ditonton? {film.isWatched}");
        }
    }
}
