using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DolgozoNyilvantartasKonzolos
{
    internal class Nyilvantartas
    {
        string endPoint = ReadSetting("endPoint");
        HttpClient client = new HttpClient();
        private List<Worker> workers = new List<Worker>();

        static string ReadSetting(string key)
        {
            string result = string.Empty;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "Not Found";
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return result;
        }

        public void getNumbersofWorkers()
        {
            int db = 0;
            foreach  (Worker item in workers)
            {
                db++;
            }
            Console.WriteLine($"Az dolgozók száma: {db}");
        }
        public void getHighestSalary()
        {
            int highest = 0;
            foreach (Worker worker in workers)
            {
                if (worker.Salary > highest)
                {
                    highest = (int)worker.Salary;
                }
            }
            foreach (Worker worker in workers)
            {
                if (worker.Salary == highest) 
                {
                    Console.WriteLine($"A legmagasabb fizetéssel rendelkező dolgozó: {worker.Name}");
                }
            }
        }
        public void getWorkerbyPosition()
        {
            Dictionary<string, int> positions = new Dictionary<string, int>();
            foreach (Worker worker in workers)
            {
                if (positions.ContainsKey(worker.Position))
                {
                    positions[worker.Position]++;
                }
                else
                {
                    positions.Add(worker.Position, 1);
                }
            }
            int db = 0;
            string position = "Hiba";
        }
    }
    
}
