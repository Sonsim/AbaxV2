using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxV2
{
    internal class Plane : Vehicle
    {
        private string _wingspan;
        private int _weight;
        private int _capacity;
        public Plane(string id, int effect, string Wingspan, int Weight, int Capacity) : base(id, effect)
        {
            Id=id;
            Effect=effect;
            _wingspan =Wingspan;
            _weight = Weight;
            _capacity =Capacity;
        }

        public void PlaneFlying()
        {
            Console.WriteLine();
            Console.WriteLine($"{Id} flyr mot Sydney");
        }

        public void PrintInfO()
        {
            Console.WriteLine();
            Console.WriteLine("******** Fly *******");
            base.PrintInfo();
            Console.WriteLine($"Vingespenn: {_wingspan}");
            Console.WriteLine($"Lateevne: {_weight} tonn");
            Console.WriteLine($"Egenvekt: {_capacity} tonn");
        }
    }
}
