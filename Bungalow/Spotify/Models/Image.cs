using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Image
    {
        [DataMember(Name = "url")]
        public string Url { get; set; }
    }
}
