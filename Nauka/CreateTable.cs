using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka
{
    class CreateTable
    {
        public int Size { get; set; }
        public CreateTable()
        {
            this.Size = 0;
        }
        public int[] CreateBableMainMethod()
        {
            var tab = CreateTab();
            if(this.Size > 0 && tab != null)
            {
                TakeTabValues(tab);
            }
            return tab;
        }
        private int[] CreateTab()
        {
            int[] tab = new int[0];
            while (this.Size <= 0)
            {
                this.Size = TakeTabSize();
                if (this.Size > 0)
                {
                    tab = new int[this.Size];
                }
                else Console.Write("Podano bledny rozmiar, prosze wpisac liczbe wieksza od 0." + Environment.NewLine);
            }
            return tab;
        }
        private void TakeTabValues(int[] tab)
        {
            for (int i = 0; i < this.Size; i++)
            {
                bool inValue = false;
                while (!inValue)
                {
                    Console.Write($"Prosze podac liczbe {i + 1} z {this.Size}: ");
                    inValue = int.TryParse(Console.ReadLine(), out tab[i]);
                }
            }
        }
        private int TakeTabSize()
        {
            Console.Write("Prosze podac rozmiar tablicy: ");
            int.TryParse(Console.ReadLine(), out int size);
            return size;
        }
    }
}
