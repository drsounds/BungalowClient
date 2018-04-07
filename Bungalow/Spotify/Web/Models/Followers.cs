using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Followers
    {
        [DataMember(Name="href")]
        public string Href { get; set; }
        [DataMember(Name ="total")]
        public int? Total { get; set; }
    }
}
