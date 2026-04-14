class Program
{
    static void Main(string[] args)
    {
        string jsonFile1 = "D:\\grw cwAERA\\Jurnal7_4802\\jurnal7_1_103022430010.json";

        FilmFavorit_103022430010 ff = new FilmFavorit_103022430010();
        ff.ReadJSON(jsonFile1);

    }
}