using System;
using System.Collections.Generic;

namespace StarWars.Models
{
    public class Planets
    {
        // The name of this planet.
        public string Name { get; set; }
        // The diameter of this planet in kilometers.
        public string Diameter { get; set; }
        // The number of standard hours it takes for this planet to complete a single
        // rotation on its axis.
        public string RotationPeriod { get; set; }
        // The number of standard days it takes for this planet to complete a single
        //orbit of its local star.
        public string OrbitalPeriod { get; set; }
        // A number denoting the gravity of this planet, where "1" is normal or 1 
        // standard G. "2" is twice or 2 standard Gs. "0.5" is half or 0.5 standard Gs.
        public string Gravity { get; set; }
        //The average population of sentient beings inhabiting this planet.
        public string Population { get; set; }
        //The climate of this planet. Comma separated if diverse.
        public string Climate { get; set; }
        // The terrain of this planet.Comma separated if diverse.
        public string Terrain { get; set; }
        // The percentage of the planet surface that is naturally occurring water or 
        //bodies of water.
        public string SurfaceWater { get; set; }
        // An array of People URL Resources that live on this planet.
        List<People> Residents { get; set; }
        // An array of Film URL Resources that this planet has appeared in.
        List<Films> Films { get; set; }
        // The hypermedia URL of this resource.
        public string Url { get; set; }
        // The ISO 8601 date format of the time that this resource was created.
        public string Created { get; set; }
        // The ISO 8601 date format of the time that this resource was edited.
        public string Edited { get; set; }
    }
}
