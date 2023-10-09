namespace Hillel;

public class Ticket
{
    public  string brand{ get; set; }
    public  string idCar{ get; set; }
    public DateTime? arrive_time{ get; set; }
    
    public DateTime? departure_time{ get; set; }
    
    public int idPlace { get; set; }
    
    public Ticket(Car car,int idPlace)
    {
        brand = car.Brand;
        idCar = car.IdCar;
        arrive_time = DateTime.Now;
        this.idPlace = idPlace;
    }

    protected Ticket()
    {
    }
}