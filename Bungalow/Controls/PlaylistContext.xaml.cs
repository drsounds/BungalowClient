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

namespace Bungalow.Controls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlaylistContext : Page
    {
        public PlaylistList Playlists
        {
            get { return (PlaylistList)GetValue(MyPlaylistsProperty); }
            set { SetValue(MyPlaylistsProperty, value); Bindings.Update(); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPlaylistsProperty =
            DependencyProperty.Register("Playlists", typeof(PlaylistList), typeof(PlaylistList), new PropertyMetadata(null));

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (e.AddedItems.Count < 1) return;
            Model model = (Model)e.AddedItems[0];

            MainPage.Current.Navigate(model.Uri);
        }
        public PlaylistContext()
        {
            this.InitializeComponent();
        }
    }
}
