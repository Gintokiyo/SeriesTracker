using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Models
{
    public class EpisodeModel
    {
        public int EpisodeId { get; set; }
        public string? EpisodeName { get; set; }
        public string? EpisodeNumber { get; set; }
        public double EpisodeRating { get; set; }
        public string? EpisodeUrl { get; set; }
        public string? EpisodeReleaseDate { get; set; }
        public int EpisodeSeriesId { get; set; }

    }
}
