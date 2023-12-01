namespace XML
{
    class Program
    {
        
        public static void Main()
        {
            List<Car> list = new List<Car>()
            {
                new Car("Toyota", 35, "AX0004AX"),
                new Car("BMW", 45, "KA7557KA"),
                new Car("Lexus", 55, "BH3040BH"),
                new Car("MB", 90, "LMSPRO")
            };
            Car.SaveCollectionInXmlFile(list);
            Car.SetNewCarPriceByNumber("LMSPRO",999);
        }
    }
}