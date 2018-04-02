using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Spotify.Web.Models;
using System.Runtime.Serialization.Json;

namespace Spotify
{
    public class Authentication
    {
        public Authentication()
        {

        }
        public async Task<T> RequestResource<T>(string method, string url, object payload = null)

 
        {
            HttpWebRequest hwr = WebRequest.CreateHttp(url);
            hwr.Method = method;
            
            T a = default(T);
            using (WebResponse r = await hwr.GetResponseAsync())
            {
                Stream s = r.GetResponseStream();

                if (s != null)
                {
                    DataContractJsonSerializer j = new DataContractJsonSerializer(typeof(T));
                    a = (T)j.ReadObject(s);

                }
            }
            return a;
        }
        public async Task<Session> GetAccessToken(string code)
        {
            Session session = await RequestResource<Session>("GET", "https://buddhalow.webfactional.com/authify/token/spotify?code=" + code);
           

            return session;
        }
    }
}
