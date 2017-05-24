using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Track : Model
    {
        public Track()
        {
            Artists = new List<Artist>();
        }
        [DataMember(Name = "artists")]
        public List<Artist> Artists { get; private set; }
        [DataMember(Name = "album")]
        public Album Album { get; set; }
        [DataMember(Name="disc_number")]
        public int DiscNumber { get; set; }
        [DataMember(Name = "track_number")]
        public int TrackNumber { get; set; }
        [DataMember(Name="duration_ms")]
        public int DurationMS { get; set; }
        [DataMember(Name="explicit")]
        public bool Explicit { get; set; }
        [DataMember(Name="is_playable")]
        public bool IsPlayable { get; set; }
        [DataMember(Name="preview_url")]
        public string PreviewUrl { get; set; }
    }
}
