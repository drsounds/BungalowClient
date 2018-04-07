using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.ViewModel
{
    public class PlaylistPageViewModel
    {
        public Playlist Playlist { get; set; }
        public PlaylistTrackset Tracks { get; set; }
    }
}
