using MVVMTutorial.Models;
using MVVMTutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMTutorial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsPage : ContentPage
    {
        
        public PlaylistsPage()
        {
            BindingContext = new PlaylistsViewModel();

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnAddPlaylist(object sender, System.EventArgs e)
        {
            (BindingContext as PlaylistsViewModel).AddPlaylist();
            
        }

        void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            (BindingContext as PlaylistsViewModel).SelectPlaylist(e.SelectedItem as Playlist);
        }
    }
}