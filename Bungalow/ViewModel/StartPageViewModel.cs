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
        public StartPageViewModel()
        {
            Spotify.Web.Mockify mockify = new Spotify.Web.Mockify();

            FeaturedAlbums = mockify.GetFeaturedAlbums();
        }
        public AlbumList FeaturedAlbums { get; set; }
    }
}
