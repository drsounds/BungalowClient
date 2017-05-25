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
    public sealed partial class ChartControl : UserControl
    {
        public ChartControl()
        {
            this.InitializeComponent();
        }


        public Chart Chart
        {
            get { return (Chart)GetValue(ChartProperty); }
            set { SetValue(ChartProperty, value); Bindings.Update(); }
        }

        // Using a DependencyProperty as the backing store for Chart.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChartProperty =
            DependencyProperty.Register("Chart", typeof(Chart), typeof(Chart), new PropertyMetadata(null));


    }
}
