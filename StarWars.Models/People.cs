using System;
using System.Collections.Generic;

namespace StarWars.Models
{
    public class People
    {
        public string Name { get; set; }
        public string BirthYear { get; set; }
        public string EyeColor { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string SkinColor { get; set; }
        public string Homeworld { get; set; }
        public List<Films> Films { get; set; }
        public List<Species> Species { get; set; }
        public List<Starships> Starships { get; set; }
        public List<Vehicles> Vehicles { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
    }
}
