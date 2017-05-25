using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Spotify.Web.Models;
using System.Runtime.Serialization.Json;

namespace Spotify.Web
{
    public class Spotify
    {
        public Session Session {get;set; }
        public Spotify()
        {
            Session = GetSession();
        }
        public bool IsLoggedIn
        {
            get
            {
                return Session != null && Session.IsValid;
            }
        }
        protected Session GetSession()
        {

            Windows.Storage.ApplicationDataContainer localSettings =
                Windows.Storage.ApplicationData.Current.LocalSettings;
            Windows.Storage.StorageFolder localFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;
            if (!localSettings.Values.ContainsKey("spotifySession"))
                return null;
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Session));
            Session session = (Session)dcjs.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes((string)localSettings.Values["spotifySession"])));
            return session;
        }
        public async Task<T> RequestResource<T>(string method, string url, object payload = null)
        {
            HttpWebRequest hwr = WebRequest.CreateHttp("https://api.spotify.com/v1" + url);
            hwr.Headers["Authorization"] = "Bearer " + Session.AccessToken;
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
        public async Task<Artist> GetArtistById(string id)
        {
            return await RequestResource<Artist>("GET", "/artists/" + id);
        }
        public async Task<Album> GetAlbumById(string id)
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
