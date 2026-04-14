using System.Text.Json;

class FilmFavorit_103022400090
{
	public string title { get; set; }
	public string director { get; set; }
	public string year { get; set; }
	public string genre { get; set; }
	public float rating { get; set; }
	public int durationMinutes { get; set; }
	public bool isWatched { get; set; }

	public void readJSON()
	{
		string json = File.ReadAllText("jurnal7_1_103022400090.json");
		var filmFav = JsonSerializer.Deserialize<FilmFavorit_103022400090>(json);
		Console.WriteLine($"Title: {filmFav.title}\nDirector: {filmFav.director}\n" +
			$"Year: {filmFav.year}\nGenre: {filmFav.genre}\n" +
			$"Rating: {filmFav.rating}\n" +
			$"Duration (Minutes): {filmFav.durationMinutes}\n" +
			$"Has Watched: {filmFav.isWatched}");
    }
}