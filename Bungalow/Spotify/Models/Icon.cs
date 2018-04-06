using System.Runtime.Serialization;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Icon
    {
        [DataMember(Name = "url")]
        public string Url { get; set; }
    }
}
