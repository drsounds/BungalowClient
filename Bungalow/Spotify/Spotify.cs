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
        public async Task<Trackset> FindTracks(string query)
        {
            return await RequestResource<Trackset>("GET", "/search?q=" + query + "&type=track");

        }
        public async Task<Search> Search(string query)
        {
            if (query == "tag:featured")
            {
                return new Search
                {
                    Name = "Featured",
                    Albums = new AlbumList
                    {
                        Items = {
                            new Album
                            {
                                Name = "Swimming",
                                Uri = "spotify:album:6Ryu2lM1IDjb5DzVMiXOMg",
                                Id = "6Ryu2lM1IDjb5DzVMiXOMg",
                                Type = "album",
                                Artists =
                                {
                                    new Artist
                                    {
                                        Name = "Dr. Sounds",
                                        Uri = "spotify:artist:2FOROU2Fdxew72QmueWSUy",
                                        Id = "2FOROU2Fdxew72QmueWSUy",
                                        Type = "artist"
                                    }
                                }
                            }
                        }
                    },
                    Tracks = new Trackset
                    {
                        Items =
                        {

                        }
                    },
                    Artists = new ArtistList
                    {
                        Items = {
                            new Artist
                            {
                                Name = "Dr. Sounds",
                                Uri = "spotify:artist:2FOROU2Fdxew72QmueWSUy",
                                Id = "2FOROU2Fdxew72QmueWSUy",
                                Type = "artist"
                            }
                        }
                    }
                };
            }
            Search search =  await RequestResource<Search>("GET", "/search?q=" + query + "&type=artist,track,album");
            search.Name = "Search results for '" + query + "'";
            
            return search;
        }
        public async Task<ArtistList> FindArtists(string query)
        {
            return await RequestResource<ArtistList>("GET", "/search?q=" + query + "&type=artist");

        }
        public async Task<AlbumList> FindAlbums(string query)
        {
            return await RequestResource<AlbumList>("GET", "/searc/?q=" + query + "&type=album");

        }
        public async Task<Chart> GetChartForArtist(string id)
        {
            Artist artist = await GetArtistById(id);
            Chart chart = await RequestResource<Chart>("GET", "/artists/" + id + "/top-tracks?country=se");
            chart.For = artist;
            chart.Name = "Top Tracks";
            chart.Images.Add(new Image
            {
                Url = "https://sporal-drsounds.c9users.io/themes/spotify09/images/toplist.png"
            });
            return chart;
        }
        public async Task<Album> GetAlbumById(string id)
        {
            return await RequestResource<Album>("GET", "/albums/" + id);
            
        }
        public async Task<AlbumList> GetAlbumsByArtist(string id)
        {
            return await RequestResource<AlbumList>("GET", "/artists/" + id + "/albums");
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
