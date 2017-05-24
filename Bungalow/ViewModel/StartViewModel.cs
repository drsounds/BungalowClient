using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify.Web.Models;

namespace Bungalow.ViewModel
{
    public class StartViewModel
    {
        public StartViewModel()
        {
            Spotify.Web.Mockify mockify = new Spotify.Web.Mockify();

            FeaturedAlbums = new AlbumList
            {
                Items =
                {
                    mockify.GetAlbum()
                }
            };
        }
        public AlbumList FeaturedAlbums { get; set; }
    }
}
