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
    public sealed partial class AlbumContext : UserControl
    {
        public AlbumContext()
        {
            this.InitializeComponent();
        }


        public AlbumList Albums
        {
            get { return (AlbumList)GetValue(MyAlbumsProperty); }
            set { SetValue(MyAlbumsProperty, value); Bindings.Update(); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyAlbumsProperty =
            DependencyProperty.Register("Albums", typeof(AlbumList), typeof(AlbumList), new PropertyMetadata(null));

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
