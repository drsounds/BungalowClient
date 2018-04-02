using Spotify;
using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Text;
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

namespace Bungalow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
            WebView.Navigate(new System.Uri("https://buddhalow.webfactional.com/authify/connect/spotify?scope=user-read-private user-read-currently-playing user-read-playback-state user-modify-playback-state"));

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
        }
        private async void WebView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
          
        }

        private async void WebView_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {

            if (args.Uri.ToString().StartsWith("https://buddhalow.webfactional.com/authify/token/spotify"))
            {
                string code = args.Uri.Query.Split('=')[1];
                Authentication authentication = new Authentication();
                Session session = await authentication.GetAccessToken(code);
                session.Issued = DateTime.Now;
                DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Session));


                MemoryStream ms = new MemoryStream();

                Windows.Storage.ApplicationDataContainer localSettings =
                    Windows.Storage.ApplicationData.Current.LocalSettings;
                Windows.Storage.StorageFolder localFolder =
                    Windows.Storage.ApplicationData.Current.LocalFolder;
                dcjs.WriteObject(ms, session);

                localSettings.Values["SpotifySession"] = Encoding.ASCII.GetString(ms.ToArray());
                ((App)App.Current).Spotify = new Spotify.Web.Spotify();
                Frame.Navigate(typeof(MainPage), null);
            }
        }
    }
}
