using Microsoft.VisualBasic;

namespace Spotify
{
    internal class SongManager
    {
        public List<Playlist> Playlists { get; private set; } = new();
        private int _lastPlaylistId = 0;
        private int _lastMusicId = 0;
        public void AddMusicToPlaylist(int idPlaylist, string nome, string genero, string artista, int segundosDuracao)
        {
            int musicId = _lastMusicId++;
            Music music = new Music(musicId, nome, genero, artista, segundosDuracao);

            var foundedPlaylist = Playlists.FirstOrDefault(p => p.Id == idPlaylist);

            if (foundedPlaylist is not null)
                foundedPlaylist.AddMusic(music);
            else
                throw new Exception($"Id de playlist não foi encontrado. Id informado = {idPlaylist}");
        }
        public int CreatePlaylist(string playlistName, string userName)
        {
            _lastPlaylistId++;
            Playlist playlist = new Playlist(_lastPlaylistId, playlistName, userName);
            Playlists.Add(playlist);

            return playlist.Id;
        }
    }
}
