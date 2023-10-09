namespace Hillel;

public class Car
{
    public Car(string brand, string model, string idCar, Color color)
    {
        Brand = brand;
        Model = model;
        this.color = color;
        this.IdCar = idCar;
    }

    public string Brand { get; init; }

    public string Model { get; init; }

    public string? IdCar { get; init; }

    public DateTime ArriveTime { get; set; }

    public DateTime DepartureTime { get; set; }

    public Color color;

    public void SetNewColor()
    {
        Random random = new Random();
        color.R = (byte)random.Next(0, 256);
        color.G = (byte)random.Next(0, 256);
        color.B = (byte)random.Next(0, 256);
    }
}