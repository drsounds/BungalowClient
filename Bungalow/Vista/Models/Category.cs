using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Vista.Models
{
    [DataContract]
    public class Category : Model
    {
        [DataMember(Name = "albums")]
        public AlbumList Albums { get; set; }
        [DataMember(Name = "playlists")]
        public PlaylistList Playlists { get; set; }
        [DataMember(Name = "artists")]
        public ArtistList Artists { get; set; }
        [DataMember(Name = "tracks")]
        public Trackset Tracks { get; set; }
    }
}
