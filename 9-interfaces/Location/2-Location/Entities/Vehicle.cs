using System;

namespace Location.Entities
{
    class Vehicle
    {
        public string Model { get; set; }
        public Vehicle(string model)
        {
            Model = model;
        }
    }
}