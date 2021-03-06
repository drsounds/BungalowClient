﻿using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Playlist : Model
    {
        [DataMember(Name="collaborative",EmitDefaultValue =false)]
        public bool? IsCollaborative { get; set; }
        [DataMember(Name="description")]
        public string Description { get; set; }
        [DataMember(Name="followers")]
        public Followers Followers { get; set; }
        [DataMember(Name="user")]
        public User Owner { get; set; }
        [DataMember(Name="public", EmitDefaultValue = false)]
        public bool? IsPublic { get; set; }
        [DataMember(Name="snapshot_id")]
        public string SnapshotId { get; set; }
        [DataMember(Name ="tracks")]
        public PlaylistTrackset Tracks { get; set; }
    }
}
