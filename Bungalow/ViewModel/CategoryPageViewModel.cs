﻿using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungalow.ViewModel
{
    public class CategoryPageViewModel
    {
        public Category Category { get; set; }
        public CategoryPlaylists Playlists { get; set; }
    }
}
