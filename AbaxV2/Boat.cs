using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxV2
{
    
    internal class Boat : VehicleWithSpeed
    {
        private string _weight;
        public Boat(string id, int effect, int speed, string speedtype, string Weight) : base(id, effect, speed, speedtype)
        {
            Id = id;
            Effect = effect;
            Speed = speed;
            SpeedType = speedtype;
            _weight = Weight;
        }


        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("********Båt*******");
            base.PrintInfo();
            Console.WriteLine($"Vekt: {_weight}");
        }
    }
}
