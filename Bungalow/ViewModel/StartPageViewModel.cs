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
        public CategoryList Categories { get; set; }
        public PlaylistList FeaturedPlaylists { get; internal set; }
        public AlbumList NewReleases { get; internal set; }
    }
}
