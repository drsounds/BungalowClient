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
    public class ModelList<T> where T : Model
    {
        [DataMember(Name = "href")]
        public string Href { get; set; }
        [DataMember(Name = "items")]
        public List<T> Items { get; set; }
        [DataMember(Name = "limit")]
        public int Limit { get; set; }
        [DataMember(Name = "total")]
        public int Total { get; set; }
        [DataMember(Name = "offset")]
        public int Offset { get; set; }
        [DataMember(Name = "next")]
        public String Next { get; set; }
        [DataMember(Name = "previous")]
        public String Previous { get; set; }
    }
}
