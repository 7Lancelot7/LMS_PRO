namespace Hillel;

/// <summary>
/// Represents a car with specified brand, model, ID, and color.
/// </summary>
public class Car
{
    /// <summary>
    /// Constructs a Car instance with specified brand, model, ID, and color.
    /// </summary>
    /// <param name="brand">The brand of the car.</param>
    /// <param name="model">The model of the car.</param>
    /// <param name="idCar">The ID of the car.</param>
    /// <param name="color">The color of the car.</param>
    public Car(string brand, string model, int idCar, Color color)
    {
        Brand = brand;
        Model = model;
        this.Color = color;
        this.IdCar = idCar;
    }

    /// <summary>
    /// Constructs a Car instance with specified brand, model, and ID, using a default color(0,0,0).
    /// </summary>
    /// <param name="brand">The brand of the car.</param>
    /// <param name="model">The model of the car.</param>
    /// <param name="idCar">The ID of the car.</param>
    public Car(string brand, string model, int idCar)
    {
        Brand = brand;
        Model = model;
        this.Color = new Color();
        this.IdCar = idCar;
    }

    /// <summary>
    /// Constructs a Car instance with specified brand, default model("Tesla"), and ID, using a default color(0,0,0).
    /// </summary>
    /// <param name="brand">The brand of the car.</param>
    /// <param name="idCar">The ID of the car.</param>
    public Car(string brand, int idCar)
    {
        Brand = brand;
        Model = "Tesla";
        this.Color = new Color();
        this.IdCar = idCar;
    }

    /// <summary>
    /// The brand of the car.
    /// </summary>
    public string Brand { get; init; }

    /// <summary>
    /// The model of the car.
    /// </summary>
    public string Model { get; init; }

    /// <summary>
    /// The ID of the car.
    /// </summary>
    public int IdCar { get; init; }

    /// <summary>
    /// The time the car arrived at the parking lot.
    /// </summary>
    public DateTime ArriveTime { get; set; }

    /// <summary>
    /// The time the car departed from the parking lot.
    /// </summary>
    public DateTime DepartureTime { get; set; }

    /// <summary>
    /// The color of the car.
    /// </summary>
    public Color Color;

    /// <summary>
    /// Sets a new random color for the car.
    /// </summary>
    public void SetNewColor()
    {
        var random = new Random();
        Color.Red = (byte)random.Next(0, 256);
        Color.Green = (byte)random.Next(0, 256);
        Color.Blue = (byte)random.Next(0, 256);
    }
}