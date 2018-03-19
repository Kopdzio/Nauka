using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka
{
    public class LinquSort : Operations
    {
        public LinquSort(int size, int[] tab) : base(size, tab)
        {

        }
        public override void ShowSortMethod()
        {
            Write("Uzyto Linqu sortowania." + Environment.NewLine);
        }

        public override int[] Sort()
        {
            this.tab = this.tab.OrderBy(p => p).ToArray();
            return this.tab;
        }
    }
}
