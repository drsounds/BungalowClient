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
                }
            };
        }
        public List<MenuItem> MenuItems { get; set; }
    }
}
