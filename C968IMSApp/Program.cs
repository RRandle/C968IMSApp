using C968IMSApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968IMSApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Initial Test Entries

            Sys.Parts.Add(new InHouse("Tire", 100, 299.99, 4, 200, 5611));
            Sys.Parts.Add(new OutSource("Engine", 12, 3999.99, 1, 25, "Tesla"));
            Sys.Parts.Add(new InHouse("Body", 10, 1199.99, 1, 20, 5693));
            Sys.Parts.Add(new OutSource("Window",80, 59.99, 2, 100,"Macco"));
            Sys.Products.Add(new Product("Dodge: Dart", 5, 12999.99, 1, 80));
            Sys.Products.Add(new Product("Ford: F-150", 20, 39000.99, 15, 50));
            Sys.Products.Add(new Product("Mazda: 6", 15, 24995.99, 10, 75));
            Sys.Products.Add(new Product("KIA: Sorento", 35, 2199.99, 5, 50)); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeScreen());
        }
    }
}
