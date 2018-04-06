using System.Runtime.Serialization;

namespace Spotify.Web.Models
{
    [DataContract]
    public class CategoryList : ModelList<Category>
    {
    }
}
