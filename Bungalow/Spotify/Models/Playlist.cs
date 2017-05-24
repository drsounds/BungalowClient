using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Spotify.Models
{
    [DataContract]
    public class Playlist : Model
    {
        [DataMember(Name="collaborative")]
        public bool IsCollaborative { get; set; }
        [DataMember(Name="description")]
        public string Description { get; set; }
        [DataMember(Name="followers")]
        public Followers Followers { get; set; }
        [DataMember(Name="user")]
        public User Owner { get; set; }
        [DataMember(Name="public")]
        public bool IsPublic { get; set; }
        [DataMember(Name="snapshot_id")]
        public string SnapshotId { get; set; }
        [DataMember(Name ="tracks")]
        public Trackset Tracks { get; set; }
    }
}
