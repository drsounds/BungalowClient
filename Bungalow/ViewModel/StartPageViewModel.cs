using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify.Web.Models;

namespace Bungalow.ViewModel
{
    public class StartPageViewModel
    {
        public BrowseCategories Categories { get; set; }
        public FeaturedPlaylists FeaturedPlaylists { get; internal set; }
        public NewReleases NewReleases { get; internal set; }
    }
}
