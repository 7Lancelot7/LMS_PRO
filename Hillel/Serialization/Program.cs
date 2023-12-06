using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Serialization
{
    internal class Program
    {


        public static void SerializationToJson(Person person,out string serialized)
        {
            serialized = JsonConvert.SerializeObject(person);
            string filePath = "person.json";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            File.WriteAllText(filePath,serialized);



            IFormatter formatter = new BinaryFormatter();
            byte[] serializedData;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                formatter.Serialize(memoryStream,person);
                serializedData = memoryStream.ToArray();
                
            }

            using (MemoryStream memoryStream = new MemoryStream(serializedData))
            {
                Person deserialized = formatter.Deserialize(memoryStream) as Person;
                string newfilePath = "desirialized_person.txt";
                string res = $"FirstName:{deserialized.FirstName}\n" +
                             $"SecondName:{deserialized.LastName}\n" +
                             $"Age:{deserialized.Age}\n" +
                             $"Weight:{deserialized.Weight}";
                                
                if (!File.Exists(newfilePath))
                {
                    File.Create(newfilePath).Close();
                }
                File.WriteAllText(newfilePath,res);
            }
        }
        
        
        public static void Main()
        {
            Person person = new Person("Bob","Hops",24,78);
            SerializationToJson(person,out  string serialized);
        }
    }
}