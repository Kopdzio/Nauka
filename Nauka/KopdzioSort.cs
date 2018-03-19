using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka
{
    public class KopdzioSort : Operations
    {
        public KopdzioSort(int size, int[] tab) : base(size, tab)
        {
        }

        public override void ShowSortMethod()
        {
            Console.WriteLine("Uzyto mojej metody sortowania.");
        }

        public override int[] Sort()
        {
            for (int i = 0; i < this.size; i++)
            {
                int min = i;
                for (int j = i; j < this.size; j++)
                {
                    if (this.tab[min] > this.tab[j])
                        min = j;
                }
                Change(i, min);
            }
            return this.tab;
        }
    }
}
