using System.Collections;

namespace Hillel;

/// <summary>
/// Represents a parking lot with specified capacity, ParkingName, freeplace and address.
/// </summary>
public class Parking
{
    /// <summary>
    /// Number of free parking places.
    /// </summary>
    private int freePlace;

    /// <summary>
    /// Name of the parking.
    /// </summary>
    public readonly string ParkingName;

    /// <summary>
    /// Address of the parking.
    /// </summary>
    public readonly string Address;


    /// <summary>
    /// Total capacity of the parking.
    /// </summary>
    private readonly int _capacity;

    /// <summary>
    /// Container for cars parked in the parking.
    /// </summary>
    private Car[]? _carContainer;

    /// <summary>
    /// Gets or sets the car at the specified index in the parking.
    /// </summary>
    /// <param name="index">The index of the parking space.</param>
    /// <exception cref="IndexOutOfRangeException">Thrown if the index is out of range.</exception>
    /// <exception cref="Exception">Thrown if the parking space is already occupied.</exception>
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

    /// <summary>
    /// Constructs a Parking instance with specified capacity, parking name, and address.
    /// </summary>
    /// <param name="capacity">The total capacity of the parking.</param>
    /// <param name="parkingName">The name of the parking.</param>
    /// <param name="address">The address of the parking.</param>
    public Parking(int capacity, string parkingName, string address)
    {
        Address = address;
        ParkingName = parkingName;
        _capacity = capacity;
        freePlace = capacity;
        _carContainer = new Car[this._capacity];
    }

    /// <summary>
    /// Default constructor for Parking with default values (Address="address", ParkingName="parkingName",)
    /// </summary>
    public Parking()
    {
        Address = "address";
        ParkingName = "parkingName";
        _capacity = 10;
        freePlace = 10;
        _carContainer = new Car[this._capacity];
    }

    /// <summary>
    /// Parks a car in the parking lot.
    /// </summary>
    /// <param name="car">The car to be parked.</param>
    /// <exception cref="Exception">Thrown if there are no free parking places.</exception>
    public void Park(Car car)
    {
        if (freePlace == 0)
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
                freePlace--;
                return;
            }
        }

        throw new Exception("No free place");
    }

    /// <summary>
    /// Parks a car in a specific parking place.
    /// </summary>
    /// <param name="car">The car to be parked.</param>
    /// <param name="placeIndex">The index of the parking place.</param>
    /// <exception cref="Exception">Thrown if there are no free parking places or if the place is already taken.</exception>
    public void Park(Car car, int placeIndex)
    {
        if (freePlace == 0)
        {
            throw new Exception("No free place");
        }

        if (_carContainer[placeIndex] == null)
        {
            var time = DateTime.Now;
            _carContainer[placeIndex] = car;
            car.ArriveTime = time;
            freePlace--;
        }
        else
        {
            throw new Exception("This place is already taken");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="car"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
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

    /// <summary>
    /// Removes a car from the parking lot based on the car's information.
    /// </summary>
    /// <param name="car">The car to be unparked.</param>
    /// <returns>The unparked car.</returns>
    /// <exception cref="Exception">Thrown if the specified car is not in the parking lot.</exception>
    public Car UnPark(int placeIndex)
    {
        if (_carContainer[placeIndex] == null)
        {
            throw new Exception("no car here");
        }

        return _carContainer[placeIndex];
    }

    /// <summary>
    /// Removes a car from the specified parking place.
    /// </summary>
    /// <param name="placeIndex">The index of the parking place.</param>
    /// <returns>The unparked car.</returns>
    /// <exception cref="Exception">Thrown if there is no car in the specified place.</exception>
    public void ShowParking()
    {
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

    /// <summary>
    /// Displays the state of specific parking places.
    /// </summary>
    /// <param name="placeIndexes">The list of place indexes to display.</param>
    public void ShowParking(List<int> placeIndexes)
    {
        foreach (var index in placeIndexes)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=");
            if (_carContainer[index] == null)
            {
                Console.WriteLine($"Number of place is {index}.****Free place****");
            }
            else
            {
                Console.WriteLine(
                    $"Number of place is {index}. Car is {_carContainer[index].Brand},idNumber is {_carContainer[index].IdCar}");
            }
        }
    }

    /// <summary>
    /// Displays information about the parking lot's free places and capacity.
    /// </summary>
    public void GetSetMessage()
    {
        Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/");
        Console.WriteLine($"Number of free places:{freePlace}");
        Console.WriteLine($"Capacity of parking:{_capacity}");
        Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/");
    }
}