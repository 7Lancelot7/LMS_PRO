using System.Collections;

namespace Hillel;

public class Parking
{
    private int freeplace;

    public readonly string ParkingName;

    public readonly string Address;

   

    private readonly int _capacity;

    private Car[]? _carContainer;

    public Car this[int index]
    {
        get
        {
            if (index < 0 || index >= _capacity)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            return _carContainer[index];
        }
        set
        {
            if (index < 0 || index >= _capacity)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            if (_carContainer[index] == null)
            {
                _carContainer[index] = value;
                return;
            }

            throw new Exception("this place already taken ");
        }
    }

    public Parking(int capacity, string parkingName, string address)
    {
        Address = address;
        ParkingName = parkingName;
        _capacity = capacity;
        freeplace = capacity;
        _carContainer = new Car[this._capacity];
    }

    public void Park(Car car)
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

                _carContainer[i] = car;
                car.ArriveTime = time;
                freeplace--;
                return;
            }
        }

        throw new Exception("No free place");
    }


    public Car UnPark(Car car)
    {
        if (car == null)
        {
            throw new Exception("no valid value");
        }

        for (int i = 0; i < _capacity; i++)
        {
            if (_carContainer[i] == null)
            {
                continue;
            }

            if (_carContainer[i].IdCar == car.IdCar && _carContainer[i].Brand == car.Brand)
            {
                var result = _carContainer[i];
                _carContainer[i] = null;
                return result;
            }
        }
        throw new Exception("Your car is not here");
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
}