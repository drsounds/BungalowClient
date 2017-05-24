using Bungalow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem
                {
                    Text="Start",
                    Uri="bungalow:start"
                },
                new MenuItem
                {
                    Text="Radio",
                    Uri="bungalow:radio"
                },
                new MenuItem
                {
                    Text="Daily mix",
                    Uri="bungalow:daily-mix"
                },
                new MenuItem
                {
                    Text="Tracks",
                    Uri="bungalow:collection-tracks"
                },
                new MenuItem
                {
                    Text="Albums",
                    Uri="bungalow:collection-albums"
                },
                new MenuItem
                {
                    Text="Artists",
                    Uri="bungalow:collection-artists"
                },
                new MenuItem
                {
                    Text="Stations",
                    Uri="bungalow:collection-stations"
                },
                new MenuItem
                {
                    Text="Playlists",
                    Uri="bungalow:collection-playlists"
                }
            };
        }
        public List<MenuItem> MenuItems { get; set; }
    }
}
