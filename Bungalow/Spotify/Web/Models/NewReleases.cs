using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Web.Models
{
    [DataContract]
    public class NewReleases
    {
        [DataMember(Name="albums")]
        public AlbumList Albums { get; set; }
    }
}
