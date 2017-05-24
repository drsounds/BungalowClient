using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Model
    {
        [DataMember(Name = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }
        [DataMember(Name = "external_ids")]
        public ExternalId ExternalIds { get; set; }
        [DataMember(Name="uri")]
        public string Uri
        {
            get;
            set;
        }
        [DataMember(Name = "href")]
        public string Href
        {
            get;
            set;
        }
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }
        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }
    }
}
