﻿using Bungalow.Spotify.Models;
using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.Spotify
{
    public class Mockify 
    {
        public AlbumList GetAlbumset()
        {
            return new AlbumList
            {
                Items =
                {
                    GetAlbum()
                }
            };
        }
        public Trackset GetTrackset()
        {
            return new Trackset
            {
                Items = {
                    GetTrack()
                }
            };
        }
        public Playlist GetPlaylist(string username, string identifier)
        {
            return new Playlist
            {
                Name = "Test playlist",
                Id = identifier,
                Owner = GetUser(username),
                Type = "playlist",
                Tracks = GetTrackset()
            };
        }
        public User GetUser(string id)
        {
            return new User
            {
                Id = id,
                Uri = "spotify:user:" + id,
                Type = "user"
            };
        }
        public Artist GetArtist()
        {
            return new Artist
            {
                Name = "Fredrik Kempe",
                Uri = "spotify:artist:5a3wjp9dcWyJitaiwXIsC7",
                Id = "5a3wjp9dcWyJitaiwXIsC7"
            };
        }
        public Album GetAlbum()
        {
            return new Album
            {
                Uri = "spotify:album:6sFyn9bcvCqdzs7ULVzAER",
                Id = "6sFyn9bcvCqdzs7ULVzAER",
                Type = "album",
                AlbumType = "album",
                ReleaseDate = DateTime.Now,
                Tracks = GetTrackset()
            };
        }
        public Track GetTrack()
        {
            return new Track
            {
                Name = "Vincero",
                Id = "43oUj12d6TH2f41Rm7Wxz2",
                Uri = "spotify:track:43oUj12d6TH2f41Rm7Wxz2",
                Type = "artist",
                TrackNumber=1,
                Artists =
                {
                    GetArtist()   
                },
                Album=GetAlbum()
                
            };
        }
        public Artist GetArtist(string id)
        {
            return GetArtist();
        }
        public Album GetAlbum(string id)
        {
            return GetAlbum();

        }
        public User GetUserById(string id)
        {
            return GetUser(id);
        }
        
        public Trackset GetPlaylistTracks(string username, string identifier)
        {
            return GetTrackset();
        }
        public Trackset GetAlbumTracks(string identifier)
        {
            return GetTrackset();
        }
        public AlbumList GeAlbumsByArtist(string identifier)
        {
            return GetAlbumset();
        }
    }
}
