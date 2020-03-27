using System;
using System.Collections.Generic;


namespace StarWars.Models
{
    public class Species
    {
        // The name of this species.
        public string Name { get; set; }
        // The classification of this species, such as "mammal" or "reptile".
        public string Classification { get; set; }
        // The designation of this species, such as "sentient".
        public string Designation { get; set; }
        // The average height of this species in centimeters.
        public string AverageHeight { get; set; }
        // The average lifespan of this species in years.
        public string AverageLifespan { get; set; }
        // A comma-separated string of common eye colors for this species, "none"
        // if this species does not typically have eyes.
        public string EyeColors { get; set; }
        // A comma-separated string of common hair colors for this species, "none"
        // if this species does not typically have hair.
        public string HairColors { get; set; }
        // A comma-separated string of common skin colors for this species, "none" 
        //if this species does not typically have skin.
        public string SkinColors { get; set; }
        // The language commonly spoken by this species.
        public string Language { get; set; }
        // The URL of a planet resource, a planet that this species originates from.
        public string Homeworld { get; set; }
        // An array of People URL Resources that are a part of this species.
        List<People> People { get; set; }
        // An array of Film URL Resources that this species has appeared in.
        List<Films> Films { get; set; }
        // The hypermedia URL of this resource.
        public string Url { get; set; }
        // The ISO 8601 date format of the time that this resource was created.
        public string Created { get; set; }
        // The ISO 8601 date format of the time that this resource was edited.
        public string Edited { get; set; }
    }
}
