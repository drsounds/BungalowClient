using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Spotify.Web.Models;
using System.Runtime.Serialization.Json;
using Bungalow.Spotify.Models;

namespace Spotify.Web
{
    public class Spotify
    {
        public string AccessToken { get; set; }
        public Spotify(string accessToken)
        {
            AccessToken = accessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<Stream> Request(string method, string url)
        {
            HttpWebRequest hwr = WebRequest.CreateHttp("https://api.spotify.com/v1" + url);
            hwr.Method = method;
            hwr.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(AccessToken));
            Stream s = null;
            using (WebResponse t = await hwr.GetResponseAsync())
            {
                 s = t.GetResponseStream();
            }
            return s;            
        }
        public async Task<T> RequestResource<T>(string method, string url, object payload = null) 
        {
            Stream s = await Request(method, url);
            T a = default(T);
            if (s != null)
            {
                DataContractJsonSerializer j = new DataContractJsonSerializer(typeof(T));
                a = (T)j.ReadObject(s);

            }
            return a;
        }
        public async Task<Artist> GetArtist(string id)
        {
            return await RequestResource<Artist>("GET", "/artists/" + id);
        }
        public async Task<Album> GetAlbum(string id)
        {
            return await RequestResource<Album>("GET", "/albums/" + id);
            
        }
        public async Task<User> GetUserById(string id)
        {
            return await RequestResource<User>("GET", "/users/" + id);
        }
        public async Task<Playlist> GetPlaylist(string username, string identifier)
        {
            return await RequestResource<Playlist>("GET", "/users/" + username + "/playlists/" + identifier);
        }
        public async Task<Trackset> GetPlaylistTracks(string username, string identifier)
        {
            return await RequestResource<Trackset>("GET", "/users/" + username + "/playlists/" + identifier + "/tracks");
        }
        public async Task<Trackset> GetAlbumTracks(string identifier)
        {
            return await RequestResource<Trackset>("GET", "/albums/" + identifier + "/tracks");
        }
        public async Task<AlbumList> GeAlbumsByArtist(string identifier)
        {
            return await RequestResource<AlbumList>("GET", "/artists/" + identifier + "/albums");
        }
    }
}
