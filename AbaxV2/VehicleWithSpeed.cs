using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace AbaxV2
{
    abstract class VehicleWithSpeed : Vehicle
    {
        public int Speed;
        public string SpeedType;


        public VehicleWithSpeed(string id, int effect, int speed, string speedtype) : base(id, effect)
        {
            Speed = speed;
            SpeedType = speedtype;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Maksfart:  {Speed}{SpeedType}");
        }
    }
}
