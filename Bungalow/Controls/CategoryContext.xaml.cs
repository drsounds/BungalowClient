﻿using Spotify.Web.Models;
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
    public sealed partial class CategoryContext : UserControl
    {
        public CategoryContext()
        {
            this.InitializeComponent();
        }
        public CategoryList Categories
        {
            get { return (CategoryList)GetValue(MyCategoriesProperty); }
            set { SetValue(MyCategoriesProperty, value); Bindings.Update(); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyCategoriesProperty =
            DependencyProperty.Register("Categories", typeof(CategoryList), typeof(CategoryList), new PropertyMetadata(null));

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count < 1) return;
            Model model = (Model)e.AddedItems[0];

            MainPage.Current.Navigate(model.Uri);
        }
    }
}
