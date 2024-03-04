﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DolgozoNyilvantartasGrafikus
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            //readAllConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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
