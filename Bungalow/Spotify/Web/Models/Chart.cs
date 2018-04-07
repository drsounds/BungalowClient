using Spotify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace Spotify.Web.Models
{
    [DataContract]
    public class Chart : Model
    {
        public Chart() : base()
        {
            trackItems = new List<Track>();
            tracks = new Trackset();

        }
        private List<Track> trackItems;
        private Trackset tracks;
        [DataMember(Name="for")]
        public Model For { get; set; }
        public Trackset Tracks {
            get
            {
                return tracks;
            }
            set
            {
                tracks = value;
            }
        }
        /// <summary>
        /// We have to emulate Trackset organisation since the respons is different here
        /// </summary>
        [DataMember(Name = "tracks")]
        public List<Track> TrackItems
        {
            get
            {
                return trackItems;
            }
            set
            {
                trackItems = value;
                Tracks = new Trackset
                {
                    Items = new List<Track>(value.Take(5))
                };
            }
        }

    }
}
