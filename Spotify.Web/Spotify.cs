using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Net;
namespace Spotify.Web
{
    public class Spotify
    {
        public string AccessToken { get; set; }
        public Spotify(string accessToken)
        {
            AccessToken = accessToken;
        }
        private async Task<Stream> Request(string method, string url, Dictionary<string, string> querystring)
        {
           
        }
    }
}
