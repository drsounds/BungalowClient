using Bungalow.Spotify.Models;
using Spotify.Web.Models;
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

namespace Bungalow.Models.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CategoryPage : Page
    {
        Bungalow.ViewModel.CategoryPageViewModel ViewModel { get; set; }
        public CategoryPage()
        {
            this.InitializeComponent();
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            string uri = (string)e.Parameter;
            string query = uri.Substring("bungalow:category:".Length);
            ViewModel = new Bungalow.ViewModel.CategoryPageViewModel
            {
                Category = await ((App)App.Current).Spotify.RequestResource<Category>("GET", "/v1/categories/" + query),
                Playlists = await ((App)App.Current).Spotify.RequestResource<PlaylistList>("GET", "/v1/categories/" + query + "/playlists")
            };
            Bindings.Update();
        }
    }
}
