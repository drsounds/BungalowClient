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
using Bungalow.ViewModel;
using Spotify.Web.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Bungalow.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartPage : Page
    {
        public StartPage()
        {
            this.InitializeComponent();
            this.ViewModel = new StartPageViewModel();
        }


        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel = new Bungalow.ViewModel.StartPageViewModel
            {
                Categories = await ((App)App.Current).Spotify.RequestResource<CategoryList>("GET", "/browse/categories"),
                FeaturedPlaylists = await ((App)App.Current).Spotify.RequestResource<PlaylistList>("GET", "/browse/featured-playlists"),
                NewReleases = await ((App)App.Current).Spotify.RequestResource<AlbumList>("GET", "/browse/new-releases")
            };

            Bindings.Update();
        }

        public StartPageViewModel ViewModel { get; private set; }

    }
}
