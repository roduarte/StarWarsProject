using System;
using System.Collections.Generic;

namespace StarWars.Models
{
    public class Films
    {
        public string Title { get; set; }
        public int EpisodeId { get; set; }
        public string OpeningCrawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Species> Species { get; set; }
        public List<Starships> Starships { get; set; }
        public List<Vehicles> Vehicles { get; set; }
        public List<People> Characters { get; set; }
        public List<Planets> Planets { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
    }
}
