using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Web.Models
{
    [DataContract]
    public class PlaylistRow : Model
    {
        public User AddedBy { get; set; }
        [DataMember(Name="track")]
        public Track Track { get; set; }
}
    }
