namespace Spotify
{
    internal class Playlist
    {
        public List<Music> Musics { get; private set; } = new List<Music>();
        public readonly int Id;
        public string Name { get; set; }
        public int TotalMusics { get; set; }
        public readonly string UserName;

        public Playlist(int id, string name, string userName)
        {
            Id = id;
            Name = name;
            UserName = userName;
        }
        public Playlist(int id, List<Music> musics, string name, string userName)
        {
            Id = id;
            Musics = musics;
            Name = name;
            UserName = userName;
            TotalMusics = musics.Count;
        }

        public void AddMusic(Music music)
        {
            Musics.Add(music);
            TotalMusics++;
        }
        public void RemoveMusic(Music music)
        {
            Musics.Remove(music);
            TotalMusics--;
        }
    }
}
