using System;
using System.Collections.Generic;

namespace StarWars.Models
{
    public class Vehicles
    {
        // The name of this vehicle. The common name, such as "Sand Crawler" or "Speeder bike".
        public string Name { get; set; }
        // The model or official name of this vehicle. Such as "All-Terrain Attack Transport".
        public string Model { get; set; }
        // The class of this vehicle, such as "Wheeled" or "Repulsorcraft".
        public string VehicleClass { get; set; }
        // The length of this vehicle in meters.
        public string Length { get; set; }
        // The cost of this vehicle new, in Galactic Credits.
        public string CostInCredits { get; set; }
        // The number of personnel needed to run or pilot this vehicle.
        public string Crew { get; set; }
        // The number of non-essential people this vehicle can transport.
        public string Passengers { get; set; }
        // The maximum speed of this vehicle in the atmosphere.
        public string MaxAtmospheringSpeed { get; set; }
        // The maximum number of kilograms that this vehicle can transport.
        public string CargoCapacity { get; set; }
        // The maximum length of time that this vehicle can provide consumables for its 
        // entire crew without having to resupply. 
        public string Consumables { get; set; }
        // An array of Film URL Resources that this vehicle has appeared in.
        public List<Films> Films { get; set; }
        // An array of People URL Resources that this vehicle has been piloted by.
        public List<People> Pilots { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
    }
}
