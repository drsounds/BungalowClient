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
        public Model()
        {
            Images = new List<Image>();
        }
        public string ImageUrl
        {
            get
            {
                if (Images != null && Images.Count > 0)
                return Images[0].Url;
                return "";
            }
        }
        [DataMember(Name = "uri")]
        private string uri;
        [DataMember(Name = "external_urls")]
        public ExternalUrls ExternalUrls { get; set; }
        [DataMember(Name = "external_ids")]
        public ExternalIds ExternalIds { get; set; }
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; }
        public string Uri
        {
            get
            {
                if (uri == null)
                {
                    return "spotify:" + this.GetType().Name.ToLower() + ":" + this.Id;
                }
                return uri;
            }
            set
            {
                this.uri = value;
            }
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
