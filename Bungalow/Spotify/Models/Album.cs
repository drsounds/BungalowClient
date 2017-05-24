using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Album : Model
    {
        public Album()
        {
            Tracks = new Trackset();
            Images = new List<Image>();
            Genres = new List<Genre>();
            Copyrights = new List<Copyright>();
            Artists = new List<Artist>();
        }
        [DataMember(Name="album_type")]
        public string AlbumType { get; set; }
        [DataMember(Name = "artists")]
        public List<Artist> Artists { get; private set; }
        [DataMember(Name = "popularity")]
        public int Popularity { get; set; }
        [DataMember(Name = "label")]
        public string Label { get; set; }
        [DataMember(Name = "release_date")]
        public DateTime ReleaseDate { get; set; }
        [DataMember(Name = "copyrights")]
        public List<Copyright> Copyrights {get;set;}
        [DataMember(Name = "genres")]
        public List<Genre> Genres { get; set; }
        [DataMember(Name="images")]
        public List<Image> Images { get; set; }
        [DataMember(Name="tracks")]
        public Trackset Tracks { get; set; }
    }
}
