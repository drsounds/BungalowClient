using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Spotify.Models
{
    [DataContract]
    public class AlbumResult
    {
        [DataMember(Name="albums")]
        public AlbumList Albums { get; set; }
    }
}
