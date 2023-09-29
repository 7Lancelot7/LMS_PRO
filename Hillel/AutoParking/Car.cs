namespace Hillel;

public class Car
{
    public Car(string brand, string model, string color, string idCar)
    {
        Brand = brand;
        Model = model;
        Color = color;
        Id_car = idCar;
    }
    
    public string Brand { get; init; }

    public string Model { get; init; }
    
    public string Color { get; init; }
    
    public string Id_car { get; init; }

    public  DateTime arrive_time { get; set; }

    public  DateTime departure_time { get; set; }
}