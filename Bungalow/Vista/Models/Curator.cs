using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify.Web.Models;
using System.Runtime.Serialization;

namespace Bungalow.Vista.Models
{
    [DataContract]
    public class Curator : Model
    {
        [DataMember(Name="logotype_url")]
        public string LogotypeUrl { get; set; }
        [DataMember(Name="albums")]
        public AlbumList Albums { get; set; }
        [DataMember(Name = "playlists")]
        public PlaylistList Playlists { get; set; }
        [DataMember(Name = "artists")]
        public ArtistList Artists { get; set; }
        [DataMember(Name = "tracks")]
        public Trackset Tracks { get; set; }
        [DataMember(Name = "categories")]
        public CategoryList Categories { get; set; }
    }
}
