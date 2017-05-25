using Bungalow.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Bungalow.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlaylistPage : Page
    {
        public PlaylistViewModel ViewModel { get; set; }
        public PlaylistPage()
        {
            this.InitializeComponent();
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            string uri = (string)e.Parameter;
            string username = uri.Split(':')[2];
            string identifier = uri.Split(':')[4];
            ViewModel = new PlaylistViewModel();
            ViewModel.Playlist = await ((App)App.Current).Spotify.GetPlaylist(username, identifier);
            ViewModel.Tracks = await ((App)App.Current).Spotify.GetPlaylistTracks(username, identifier);
            Bindings.Update();
        }
    }
}
