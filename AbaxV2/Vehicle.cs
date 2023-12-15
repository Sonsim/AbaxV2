using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxV2
{
    abstract class Vehicle
    {
        public string Id;
        public int Effect;

        protected Vehicle(string id, int effect)
        {
            Id=id;
            Effect=effect;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Regnr: {Id}");
            Console.WriteLine($"Effekt: {Effect} kw");
        }
    }
}
