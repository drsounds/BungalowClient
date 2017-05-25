using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Web.Models
{
    [DataContract]
    public class Session
    {
        public DateTime Expires
        {
            get
            {
                return Issued.AddMinutes(ExpiresIn);
            }
        }
        public bool IsValid
        {
            get
            {
                return Issued > DateTime.Now;
            }
        }
        [DataMember(Name ="access_token")]
        public string AccessToken { get; set; }
        [DataMember(Name ="expires_in")]
        public int ExpiresIn { get; set; }
        [DataMember(Name ="refresh_token")]
        public string RefreshToken { get; set; }
        public DateTime Issued { get; set; }

        public static explicit operator Session(Task<Stream> v)
        {
            throw new NotImplementedException();
        }
    }
}
