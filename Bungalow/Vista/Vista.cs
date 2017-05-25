using Bungalow.Vista.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Vista
{
    public class Vista
    {
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
        public async Task<Curator> GetCuratorByDomainAsync(string domain)
        {
            return await RequestResource<Curator>("GET", "https://" + domain + "/api/index");
        }
        public async Task<Category> GetCategory(string domain, string categoryId)
        {
            return await RequestResource<Category>("GET", "https://" + domain + "/api/categories/" + categoryId);
        }
    }
}
