using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.ViewModel
{
    public class SearchPageViewModel
    {
        public string Name { get; set; }
        public string Query { get; set; }
        public Search Search { get; set; }
    }
}
