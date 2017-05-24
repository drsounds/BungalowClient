using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Spotify.Models
{
    [DataContract]
    class ArtistResult
    {
        [DataMember(Name="artists")]
        public ArtistList Artists { get; set; }
    }
}
