using System;

namespace Hillel
{
    public class Program
    {
        public static void Main()
        {
            Car Lexus = new Car("Lexus", "LS", "Green", "AX7777AX");
            Car BMW = new Car("BMW", "528", "Blue", "AX1111GG");
            Car Mersedes = new Car("Mersedes", "E53", "Red", "AX1234YY");
            Parking parking = new Parking(5);
            var object1 = parking.Park(Lexus);
            var object2 = parking.Park(BMW);
            var object3 = parking.Park(Mersedes);
            parking.ShowParking();
            parking.Unpark(object1);
            parking.ShowParking();
        }
    }
}