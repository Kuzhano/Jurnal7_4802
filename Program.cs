class Program
{
    static void Main(string[] args)
    {
        string jsonFile1 = "jurnal7_1_103022400098.json";

        FilmFavorit_103022400098 fav = new FilmFavorit_103022400098();
        fav.ReadJSON(jsonFile1);

        string jsonFile2 = "jurnal7_2_103022400098.json";

        Watchlist_103022400098 watchlist = new Watchlist_103022400098();
        watchlist.ReadJSON(jsonFile2);

    }
}