using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Spotify.Models
{
    [DataContract]
    public class Image
    {
        [DataMember(Name="height")]
        public int Height { get; set; }
        [DataMember(Name="width")]
        public int Width { get; set; }
    }
}
