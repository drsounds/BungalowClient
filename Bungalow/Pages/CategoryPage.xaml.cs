using Spotify.Web.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Bungalow.Pages
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
                Category = await ((App)App.Current).Spotify.RequestResource<Category>("GET", "/browse/categories/" + query),
                Playlists = await ((App)App.Current).Spotify.RequestResource<CategoryPlaylists>("GET", "/browse/categories/" + query + "/playlists")
            };
            Bindings.Update();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem == null) return;
            Model model = (Model)e.ClickedItem;

            MainPage.Current.Navigate(model.Uri);
        }
    }
}
