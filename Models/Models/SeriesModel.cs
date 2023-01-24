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
        public List<PersonModel>? SeriesPerson { get; set; }
        public int SeriesEpisodeCount { get; set; }
        public List<EpisodeModel>? SeriesEpisode { get; set; }
        public string? SeriesLatestEpisode { get; set; }
        public string? SeriesUrl { get; set; }
        public string? SeriesReleaseDate { get; set; }
        public int SeriesUpdateCycle { get; set; }
    }
}
