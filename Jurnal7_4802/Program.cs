class Program
{
    static void Main(string[] args)
    {
        string jsonFile1 = "D:\\grw cwAERA\\Jurnal7_4802\\jurnal7_1_103022430010.json";

        FilmFavorit_103022430010 ff = new FilmFavorit_103022430010();
        ff.ReadJSON(jsonFile1);

        Console.WriteLine("");

        string jsonFile2 = "D:\\grw cwAERA\\Jurnal7_4802\\jurnal7_2_103022430010.json";

        Watchlist_103022430010 wl = new Watchlist_103022430010();
        wl.ReadJSON(jsonFile2);

        Console.WriteLine("");

        string jsonFile3 = "D:\\grw cwAERA\\Jurnal7_4802\\jurnal7_3_103022430010.json";

        GenreDictionary_103022430010 gd = new GenreDictionary_103022430010();
        gd.ReadJSON(jsonFile3);

    }
}