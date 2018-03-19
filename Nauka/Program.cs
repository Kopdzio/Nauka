using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka
{
    class Program
    {
        static void Main(string[] args)
        {
            Wykonaj();
            Console.ReadKey();
        }
        public static async void Wykonaj()
        {
            CreateTable createTable = new CreateTable();
            var tab = createTable.CreateBableMainMethod();

            List<Operations> allSotrs = new List<Operations>();
            allSotrs.Add(new BoubleSort(createTable.Size, (int[])tab.Clone()));
            allSotrs.Add(new LinquSort(createTable.Size, (int[])tab.Clone()));
            allSotrs.Add(new KopdzioSort(createTable.Size, (int[])tab.Clone()));


            foreach (Operations operacja in allSotrs)
            {
                await operacja.ToSort().ConfigureAwait(false);
            }
        }
    }
}
