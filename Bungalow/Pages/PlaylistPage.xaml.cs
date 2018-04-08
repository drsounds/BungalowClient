using Bungalow.ViewModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Bungalow.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlaylistPage : Page
    {
        public PlaylistPageViewModel ViewModel { get; set; }
        public PlaylistPage()
        {
            this.InitializeComponent();
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            string uri = (string)e.Parameter;
            string id = uri.Split(':')[4];
            string username = uri.Split(':')[2];
            ViewModel = new PlaylistPageViewModel()
            {
                Playlist = await ((App)App.Current).Spotify.GetPlaylist(username, id),
                Tracks = await ((App)App.Current).Spotify.GetPlaylistTracks(username, id)
            };
            Bindings.Update();
        }

        private void Header_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
