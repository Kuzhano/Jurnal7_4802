using System.Text.Json;

public class FilmFavorit_103022400098
{
    public void ReadJSON(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Error: File '{filePath}' tidak ditemukan di {Directory.GetCurrentDirectory}");
                return;
            }

            string jsonString = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);

            if (data != null)
            {
                Console.WriteLine($"Title: {data["title"]}");
                Console.WriteLine($"Director: {data["director"]}");
                Console.WriteLine($"Year: {data["year"]}");
                Console.WriteLine($"Gendre: {data["genre"]}");
                Console.WriteLine($"Rating: {data["rating"]}");
                Console.WriteLine($"Duration(minute): {data["duraitonMinutes"]}");
                Console.WriteLine($"Already Waching: {data["isWatched"]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Gagal membaca file: {ex.Message}");
        }
    }
}