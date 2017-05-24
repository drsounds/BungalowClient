using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Spotify.Models
{
    [DataContract]
    public class Copyright
    {
        [DataMember(Name="text")]
        public string Text { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
