using System.Collections;

namespace Hillel;

public class Parking : IEnumerable, IEnumerator
{
    private class SecretTicket : Ticket
    {
        public Car Car;
        public string idCar;
        public DateTime? arrive_time;
        public DateTime? departure_time = null;
        public int idPlace;

        public SecretTicket(Car car, string idCar, DateTime? arriveTime, int idPlace)
        {
            this.Car = car;
            this.idCar = idCar;
            arrive_time = arriveTime;
            this.idPlace = idPlace;
        }
    }

    private int freeplace;

    public readonly string ParkingName;

    public readonly string Adress;

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

    public Parking(int capacity, string parkingName, string adress)
    {
        Adress = adress;
        ParkingName = parkingName;
        _capacity = capacity;
        freeplace = capacity;
        _carContainer = new Car[this._capacity];
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
                Ticket ticket = new SecretTicket(car, car.IdCar, time, i);
                _carContainer[i] = car;
                car.ArriveTime = time;
                freeplace--;
                return ticket;
            }
        }

        throw new Exception("No free place");
    }


    public Car Unpark(Ticket ticket = null)
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
        //Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=");
        for (int i = 0; i < _capacity; i++)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=");
            if (_carContainer[i] == null)
            {
                Console.WriteLine($"Number of place is {i + 1}.****Free place****");
            }
            else
            {
                Console.WriteLine(
                    $"Number of place is {i + 1}. Car is {_carContainer[i].Brand},idNumber is {_carContainer[i].IdCar}");
            }
        }
    }

    public void GetSetMessage()
    {
        Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/");
        Console.WriteLine($"Number of free places:{freeplace}");
        Console.WriteLine($"Capacity of parking:{_capacity}");
        Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/");
    }
    public IEnumerator GetEnumerator()
    {
        return this as IEnumerator;
    }

    public bool MoveNext() => _currentPosition++ < _capacity;

    public void Reset()
    {
        _currentPosition = -1;
    }

    public object Current => _carContainer[_currentPosition];
}