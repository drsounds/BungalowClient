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
        [DataMember(Name = "artists")]
        public IEnumerable<Artist> Artists { get; private set; }
    }
}
