class Program
{
    static void Main(string[] args)
    {
        string jsonFile = "jurnal7_1_103022400098.json";

        FilmFavorit_103022400098 fav = new FilmFavorit_103022400098();
        fav.ReadJSON(jsonFile);
    }
}