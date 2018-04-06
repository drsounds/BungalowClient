using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Category : Model
    {
        public List<Icon> Icons { get; set; }
    }
}
