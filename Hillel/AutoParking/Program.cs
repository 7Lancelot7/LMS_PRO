namespace Hillel
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();
            Color color1 = new Color((byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256),
                (byte)random.Next(0, 256));
            Color color2 = new Color((byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256),
                (byte)random.Next(0, 256));
            Color color3 = new Color((byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256),
                (byte)random.Next(0, 256));
            
            Car lexus = new Car("Lexus", "LS", "AX7777AX", color1);
            Car bmv = new Car("BMW", "528", "AX1111GG", color2);
            Car mersedes = new Car("Mersedes", "E53", "AX1234YY", color3);
            
            Parking parking = new Parking(5, "Nikolskyi", "Kharkiv,Ukraine");
            List<Ticket> listOfTickets = new List<Ticket>();
            
            var object1 = parking.Park(lexus);
            listOfTickets.Add(object1);
            
            var object2 = parking.Park(bmv);
            listOfTickets.Add(object2);
            
            var object3 = parking.Park(mersedes);
            listOfTickets.Add(object3);
            
            parking.ShowParking();
            // parking.Unpark(listOfTickets[0]);
            // parking.ShowParking();
            
            parking.GetSetMessage();
        }
    }
}