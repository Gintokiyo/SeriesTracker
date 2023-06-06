using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Models
{
    public class SeriesModel
    {
        public int SeriesId { get; set; }
        public string? SeriesName { get; set; }
        public string? SeriesOriginalName { get; set; }
        public string? SeriesDescription { get; set; }
        public double SeriesRating { get; set; }
        public int SeriesSeasonCount { get; set; }
        public int SeriesEpisodeCount { get; set; }
        public string? SeriesLatestEpisode { get; set; }
        public string? SeriesPosterUrl { get; set; }
        public DateTime SeriesReleaseDate { get; set; }
        public int SeriesUpdateCycle { get; set; }
        public string? SeriesBackgroundUrl { get; set; }
        public string? SeriesOriginalLanguage { get; set; }
        public string? SeriesHomepage { get; set; }
    }
}
