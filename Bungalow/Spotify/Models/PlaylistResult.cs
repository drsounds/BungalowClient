using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Spotify.Models
{
    [DataContract]
    public class PlaylistResult
    {
        [DataMember(Name ="playlists")]
        public PlaylistList Playlists { get; set; }
    }
}
