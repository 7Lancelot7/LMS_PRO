using System.Threading.Channels;
using Microsoft.Win32;

namespace RegistrtyFileLogging
{
    class Program
    {
        public static void Start()
        {
            string filePath = "C:\\Users\\LocalAdmin\\Desktop\\Hillel\\Hillel\\RegistryFileLogging\\LogInfo.txt";
            string data = DateTime.Now.ToString();
            if (!WasExecutedBefore())
            {
                FirstExecute();
                return;
            }
            WriteToFile(filePath,data);
            
        }
        public static void WriteToFile(string filePath, string data)
        {
            
            if (File.Exists(filePath))
            {
                
                using (StreamWriter writer = new StreamWriter(filePath,true))
                {
                    writer.WriteLine(data);
                }
            }
            else
            {
                File.WriteAllText(filePath, data);
            }
        }
        public static async Task FirstExecute()
        {
            RegistryKey registryKey = Registry.CurrentUser;
            var key = registryKey.CreateSubKey("FirstExecute");
            key.SetValue("date", DateTime.Now.ToString());
            registryKey.Close();
        }

        public static bool WasExecutedBefore()
        {
            RegistryKey registryKey = Registry.CurrentUser;
            var key = registryKey.OpenSubKey("FirstExecute");
            if (key == null)
            {
                registryKey.Close();
                return false;
            }
            registryKey.Close();
            return true;
        }

        public static void Main()
        {
           Start();
        }
    }
}