using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Web.Models
{
    [DataContract]
    public class User : Model
    {
        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; }
        [DataMember(Name = "followers")]
        public Followers Followers { get; set; }
    }
}
