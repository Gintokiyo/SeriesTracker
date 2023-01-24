
namespace FinalProjectFront.Models.AppModels
{
    public class SeriesViewModel
    {
        public int SeriesId { get; set; }
        public string? SeriesName { get; set; }
        public string? SeriesOriginalName { get; set; }
        public string? SeriesDescription { get; set; }
        public double SeriesRating { get; set; }
        public int SeriesSeasonCount { get; set; }
        public int SeriesEpisodeCount { get; set; }
        public string? SeriesLatestEpisode { get; set; }
        public string? SeriesUrl { get; set; }
        public string? SeriesReleaseDate { get; set; }
        public int SeriesUpdateCycle { get; set; }
    }
}
