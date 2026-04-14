using System;

namespace Modul7_BNP
{ 
    class main
    {
        static void Main(String[] args) { 
            FilmFavorit_103022400020 film = new FilmFavorit_103022400020();
            Watchlist_103022400020 watchlist = new Watchlist_103022400020();
            GenreDictionary_103022400020 gd = new GenreDictionary_103022400020();

            film.ReadJSON();
            watchlist.ReadJSON();
            gd.ReadJSON();
        }
    }
}
