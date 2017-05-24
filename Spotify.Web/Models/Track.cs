using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Track : Model
    {
        [DataMember(Name = "artists")]
        public IEnumerable<Artist> Artists { get; private set; }

        [DataMember(Name = "albums")]
        public IEnumerable<Artist> Albums { get; private set; }
    }
}
