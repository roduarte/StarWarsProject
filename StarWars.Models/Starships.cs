using System;
using System.Collections.Generic;


namespace StarWars.Models
{
    public class Starships
    {
        // The name of this starship. The common name, such as "Death Star".
        public string Name { get; set; }
        // The model or official name of this starship. Such as "T-65 X-wing" or "DS-1
        // Orbital Battle Station".
        public string Model { get; set; }
        public string StarshipClass { get; set; }
        public string Manufacturer { get; set; }
        public string CostInCredits { get; set; }
        public string Length { get; set; }
        public string Crew { get; set; }
        // The number of non-essential people this starship can transport.
        public string Passengers { get; set; }
        public string MaxAtmospheringSpeed { get; set; }
        public string HyperdriveRating { get; set; }
        // The Maximum number of Megalights this starship can travel in a standard hour.
        // A "Megalight" is a standard unit of distance and has never been defined before 
        // within the Star Wars universe. This figure is only really useful for measuring
        // the difference in speed of starships.We can assume it is similar to AU, the 
        // distance between our Sun (Sol) and Earth.
        public string MGLT { get; set; }
        // The maximum number of kilograms that this starship can transport.
        public string CargoCapacity { get; set; }
        // The maximum length of time that this starship can provide consumables for its 
        // entire crew without having to resupply. 
        public string Consumables { get; set; }
        // An array of Film URL Resources that this starship has appeared in.
        public List<Films> Films { get; set; }
        // An array of People URL Resources that this starship has been piloted by.
        public List<People> Pilots { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
    }
}
