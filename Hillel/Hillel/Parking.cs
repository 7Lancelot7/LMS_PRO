using System.Collections;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace Hillel;

public class Parking:IEnumerable,IEnumerator
{

    private class SecretTicket:Ticket
    {
        public  Car car ;
        public  string idCar;
        public DateTime? arrive_time;
        public DateTime? departure_time;
        public int idPlace;

        public SecretTicket(Car car, string idCar, DateTime? arriveTime,int idPlace)
        {
            this.car = car;
            this.idCar = idCar;
            arrive_time = arriveTime;
            this.idPlace = idPlace;
        }
    }
    private int freeplace;

    private int _currentPosition = -1;
    
    private readonly int _capacity;
    
    private Car[]? _carContainer;

    public Car this[int index]
    {
        get
        {
            if (index < 0 || index >= _currentPosition)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _carContainer[index];
        }
        set
        {
            if (index < 0 || index >= _capacity)
                throw new IndexOutOfRangeException("Index out of range");
            if (_carContainer[index] == null)
            {
                _carContainer[index] = value;
                return;
            }
            throw new Exception("this place already taken ");
        }
    }

    public Parking(int _capacity)
    {
        this._capacity = _capacity;
        freeplace = _capacity;
        this._carContainer = new Car[this._capacity];
    }

    public Ticket Park(Car car)
    {
        if (freeplace == 0)
        {
            throw new Exception("No free place");
        }

        for (int i = 0; i < _capacity; i++)
        {
            if (_carContainer[i] == null)
            {
                var time = DateTime.Now;
                Ticket ticket = new SecretTicket(car,car.Id_car,time,i);
                _carContainer[i] = car;
                car.arrive_time = time;
                freeplace--;
                return ticket;
            }
        }
        throw new Exception("No free place");
    }

    
    public Car Unpark(Ticket ticket=null)
    {
        if (ticket == null)
        {
            throw new Exception("no ticket");
        }
        
        var newticket = ticket as SecretTicket;
        
        if (_carContainer[newticket.idPlace] == null)
        {
            throw new Exception("Your car is not here");
        }

        var result = _carContainer[newticket.idPlace];
        _carContainer[newticket.idPlace] = null;
        newticket = null;
        return result;
    }
    public void ShowParking()
    {
        var iter = 1;
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=");
        for (int i = 0; i < _capacity-freeplace;i++)
        {
            if (_carContainer[i] == null)
            {
                continue;
            }
            Console.WriteLine($"Number of place is {iter++}. Car is {_carContainer[i].Brand},idNumber is {_carContainer[i].Id_car}");
        }
    }
    public IEnumerator GetEnumerator()
    {
        return this as IEnumerator;
    }
    
    public bool MoveNext() => _currentPosition++<_capacity;
    
    public void Reset()
    {
        _currentPosition = -1;
    }
    
    public object Current =>_carContainer[_currentPosition]; 
}