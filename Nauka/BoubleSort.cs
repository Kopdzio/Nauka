using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka
{
    public class BoubleSort : Operations
    {
        public BoubleSort(int size, int[] tab) : base(size, tab)
        {

        }
        public override void ShowSortMethod()
        {
            base.Write("Wybrano metode sortowania bąbelkowego." + Environment.NewLine);
        }
        public override int[] Sort()
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size - 1; j++)
                {
                    if (this.tab[j] > this.tab[j + 1])
                    {
                        Change(j, j + 1);
                    }
                }
            }
            return this.tab;
        }
    }
}
