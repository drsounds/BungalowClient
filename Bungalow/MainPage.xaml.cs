using Bungalow.Models;
using Bungalow.Pages;
using Bungalow.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Bungalow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public async void Navigate(string uri)
        {
            
            if (uri.StartsWith("spotify:"))
            {
                uri = "bungalow:" + uri.Substring("spotify:".Length);
            }

            
            if (!uri.StartsWith("bungalow:"))
            {
                uri = "bungalow:search:" + uri;
            }

            if (uri == "bungalow:internal:login")
            {
                
            } else if (new Regex("^bungalow:start$").IsMatch(uri))
            {
                ViewStack.Navigate(typeof(StartPage));
            }
            else if (new Regex("^bungalow:artist:([a-zA-Z0-9]+)$").IsMatch(uri))
            {
                ViewStack.Navigate(typeof(ArtistPage), uri);
            }
            else if (new Regex("^bungalow:user:([a-zA-Z0-9]+)$").IsMatch(uri))
            {
                ViewStack.Navigate(typeof(UserPage), uri);
            }
            else if (new Regex("^bungalow:album:([a-zA-Z0-9]+)$").IsMatch(uri))
            {
                ViewStack.Navigate(typeof(AlbumPage), uri);
            }
        }
        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new MainPageViewModel();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Navigate("spotify:artist:2FOROU2Fdxew72QmueWSUy");
        }

        public MainPageViewModel ViewModel { get; private set; }

        private void TextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                Navigate(((TextBox)sender).Text);
            }

        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count < 1) return;
            var item = (MenuItem)e.AddedItems[0];
            Navigate(item.Uri);

        }
    }
}
