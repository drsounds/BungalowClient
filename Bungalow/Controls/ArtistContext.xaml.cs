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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Bungalow.Controls
{
    public sealed partial class ArtistContext : UserControl
    {
        public ArtistContext()
        {
            this.InitializeComponent();
        }


        public ArtistList Artists
        {
            get { return (ArtistList)GetValue(ArtistsProperty); }
            set { SetValue(ArtistsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Artists.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArtistsProperty =
            DependencyProperty.Register("Artists", typeof(ArtistList), typeof(ArtistList), new PropertyMetadata(null));


        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count < 1) return;
            Model model = (Model)e.AddedItems[0];

            MainPage.Current.Navigate(model.Uri);
        }
    }
}
