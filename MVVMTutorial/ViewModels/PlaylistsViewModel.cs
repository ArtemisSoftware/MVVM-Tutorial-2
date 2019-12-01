using MVVMTutorial.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MVVMTutorial.ViewModels
{
    class PlaylistsViewModel
    {
        public ObservableCollection<Playlist> Playlists { get; private set; } = new ObservableCollection<Playlist>();
        public Playlist SelectedPlaylist { get; set; }

        public void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new Playlist { Title = newPlaylist });

        }

        public void SelectPlaylist(Playlist playlist)
        {
            if (playlist == null)
                return;

            
            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
