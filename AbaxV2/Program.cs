namespace AbaxV2
{
    internal class Program
    {
        static void Main()
        {
            var Car1 = new Car("NF123456", 147, 200, "Km/t", "grønn", "lett kjøretøy");
            var Car2 = new Car("NF654321", 150, 195, "Km/t", "blå", "lett kjøretøy");

            var Car3 = new Car("NF123456", 147, 200, "Km/t", "grønn", "lett kjøretøy");

            var plane = new Plane("LN1234", 1000, "30M", 2, 10);
            var boat = new Boat("ABC123", 100, 30, "knop", "500kg");

            Car1.PrintInfo();
            Car2.PrintInfo();

            Car1.Drive();

            plane.PrintInfO();
            plane.PlaneFlying();

            boat.PrintInfo();

            Car1.CompareCars(Car1, Car2);
        }

        
    }
}