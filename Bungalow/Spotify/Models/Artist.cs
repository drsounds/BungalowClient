using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Artist : Model
    {
        [DataMember(Name = "followers")]
        public Followers Followers { get; set; }
    }
}
