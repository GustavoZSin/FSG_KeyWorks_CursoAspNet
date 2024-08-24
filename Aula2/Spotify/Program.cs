using System.Text.Json;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SongManager musicRegister = new SongManager();
                int playlistId = musicRegister.CreatePlaylist("Rock Songs", "Gustavo");

                musicRegister.AddMusicToPlaylist(playlistId, "Bohemian Rapsody", "Rock", "Queen", 355);
                musicRegister.AddMusicToPlaylist(playlistId, "Mary On A Cross", "Rock", "Ghost", 245);

                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;

                string json = JsonSerializer.Serialize(musicRegister, jsonSerializerOptions);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
