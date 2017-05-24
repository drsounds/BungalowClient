using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Spotify.Models
{
    [DataContract]
    public class ExternalUrls
    {
        [DataMember(Name="spotify")]
        public string Spotify { get; set; }
    }
}
