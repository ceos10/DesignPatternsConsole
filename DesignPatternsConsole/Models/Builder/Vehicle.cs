using System;
using System.Collections.Generic;

namespace DesignPatternsConsole.Models.Builder
{
    public class Vehicle
    {
        private readonly string _vehicleType;
        private readonly Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine($" Frame : { _parts["frame"]}");
            Console.WriteLine($" Engine : {_parts["engine"]}");
            Console.WriteLine($" #Wheels: {_parts["wheels"]}");
            Console.WriteLine($" #Doors : {_parts["doors"]}");
        }
    }
}
