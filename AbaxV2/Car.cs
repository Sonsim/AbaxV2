using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxV2
{
    internal class Car : VehicleWithSpeed
    {
        private string _color;
        private string _type;


        public Car(string id, int effect, int speed, string speedtype, string Color, string Type) : base(id, effect, speed, speedtype)
        {
            _color = Color;
            _type = Type;
        }

        public void Drive()
        {
            Console.WriteLine();
            Console.WriteLine($"{Id} kjører til Cape Town");
        }
        public override void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("*******Bil*******");
            base.PrintInfo();
            Console.WriteLine($"Farge: {_color}");
            Console.WriteLine($"Type: {_type}");
        }

        public void CompareCars(Car car, Car car2)
        {
            if (car.Id == car2.Id && car._type == car2._type && car._color == car2._color && car.Effect ==  car2.Effect &&
                car.SpeedType == car2.SpeedType && car.Speed == car2.Speed)
            {
                Console.WriteLine();
                Console.WriteLine($"{car.Id} og {car2.Id} er like");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{car.Id} og {car2.Id} er ikke like");
            }
        }
       
    }
}
