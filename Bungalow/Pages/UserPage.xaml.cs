using Bungalow.ViewModel;
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

namespace Bungalow.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserPage : Page
    {
        public UserPageViewModel ViewModel { get; set; }
        public UserPage()
        {
            this.InitializeComponent();
            ViewModel = new UserPageViewModel();
           
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string uri = (string)e.Parameter;
            string id = uri.Split(':')[2];
            ViewModel = new UserPageViewModel()
            {
                User = new User
                {
                    Id = id,
                    Name = id,
                    Uri = uri
                }
            };
        }
    }
}
