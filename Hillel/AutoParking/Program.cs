namespace Hillel
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();
            Color color1 = new Color( 
                (byte)random.Next(0, 256));
            Color color2 = new Color((byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256),
                (byte)random.Next(0, 256));
            Color color3 = new Color((byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256),
                (byte)random.Next(0, 256));

            Car lexus = new Car("Lexus", "LS", 7777, color1);
            Car bmv = new Car("BMW", "528", 1111, color2);
            Car mercedes = new Car("Mercedes", "E53", 1234, color3);

            #nullable enable
            string hello = null;

            using Parking parking = new Parking(5, "Nikolskyi", "Kharkiv,Ukraine");
            parking.Park(lexus);
            parking.Park(bmv);
            parking.Park(mercedes);


            parking.ShowParking();
            

            parking.GetSetMessage();
        }
    }
}