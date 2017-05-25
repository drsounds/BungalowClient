using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Search : Model
    {
        [DataMember(Name = "tracks")]
        public Trackset Tracks { get; set; }
        [DataMember(Name = "artists")]
        public ArtistList Artists { get; set; }
        [DataMember(Name = "albums")]
        public AlbumList Albums { get; set; }
    }
}
