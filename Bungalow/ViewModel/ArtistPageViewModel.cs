
using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.ViewModel
{
    public class ArtistPageViewModel
    {
        public Artist Artist {get;set; }
        public Chart Chart { get; set; }
        public AlbumList Albums { get; set; }
    }
}
