using System.Xml.Linq;

namespace XML;

public class Car
{
    public string Name { get; set; }

    public int Price { get; set; }

    public string Number { get; set; }

    public Car(string name, int price, string number)
    {
        Name = name;
        Price = price;
        Number = number;
    }


    public static void SaveCollectionInXmlFile(IEnumerable<Car> cars)
    {
        if (cars is null)
        {
            throw new NullReferenceException("Empty Collection");
        }


        var document = new XDocument();
        var rootElement = new XElement("carDealer");
        List<XElement> carsList = new List<XElement>();
        int index = 0;
        foreach (var auto in cars)
        {
            var automobile = new XElement("auto");
            carsList.Add(automobile);
            var autoNameAttr = new XAttribute("name", auto.Name);
            var autoNumber = new XElement("number", auto.Number);
            var autoPrice = new XElement("price", auto.Price);
            carsList[index].Add(autoNameAttr);
            carsList[index].Add(autoNumber);
            carsList[index].Add(autoPrice);
            index++;
        }

        foreach (var car in carsList)
        {
            rootElement.Add(car);
        }

        document.Add(rootElement);
        document.Save("C:\\Users\\vrata\\Desktop\\hillel\\LMS_PRO\\Hillel\\CarList.xml");
    }

    public static void SetNewCarPriceByNumber(string carNumber, int newPrice)
    {
        if (carNumber is null || newPrice == 0)
        {
            throw new FormatException("incorrect data");
        }

        var doc = XDocument.Load("C:\\Users\\vrata\\Desktop\\hillel\\LMS_PRO\\Hillel\\CarList.xml");
        var root = doc.Element("carDealer");
        if (root is null)
        {
            throw new NullReferenceException("root is null");
        }

        var autoElement = root.Elements("auto").FirstOrDefault(auto => auto.Element("number")?.Value == carNumber);
        if (autoElement is null)
        {
            throw new InvalidOperationException($"Car with number '{carNumber}' not found");
        }

        var priceElement = autoElement.Element("price");
        if (priceElement is null)
        {
            throw new InvalidOperationException($"Price element not found for car with number '{carNumber}'");
        }

        priceElement.Value = newPrice.ToString();
        
        doc.Save("C:\\Users\\vrata\\Desktop\\hillel\\LMS_PRO\\Hillel\\CarList.xml");

        Console.WriteLine($"Price for car with number '{carNumber}' updated to {newPrice}");
    }
}