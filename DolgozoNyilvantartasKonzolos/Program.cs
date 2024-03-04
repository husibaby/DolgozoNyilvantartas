using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace DolgozoNyilvantartasKonzolos
{
    internal class Program
    {
        public List<Worker> workers = new List<Worker>();

        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Nyilvantartas nyilvantartas = new Nyilvantartas();
            nyilvantartas.getNumbersofWorkers();
            nyilvantartas.getHighestSalary();
            nyilvantartas.getWorkerbyPosition();
        }
        private static void readAllConfig()
        {
            //-- 
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                if (appSettings.Count == 0)
                {
                    Console.WriteLine("Nincs beállítás a konfigurációs fájlban!");
                    Console.ReadLine();
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {

                Console.WriteLine("Hiba a konfigurációs fájl olvasásakor!");
                Console.ReadLine();
            }

        }
    }
}