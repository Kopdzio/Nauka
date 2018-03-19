using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka
{
    public abstract class Operations : ISorts
    {
        protected int size;
        protected int[] tab;
        public Operations(int size, int[] tab)
        {
            this.size = size;
            this.tab = tab;
        }
        public async Task ToSort()
        {
            await Task.Run(() =>
            {
                if (Confirm())
                {
                    ShowSortMethod();
                    WriteTab("Przed sortowaniem: ");
                    Sort();
                    WriteTab("Po sortowaniu: ");
                }
                else
                {
                    Write("Blad, podano pusta tablice.");
                }
            });
        }
        public abstract int[] Sort();
        public abstract void ShowSortMethod();
        protected void Change(int i, int j)
        {
            var orginalValue = this.tab[i];
            this.tab[i] = this.tab[j];
            this.tab[j] = orginalValue;
        }
        protected void WriteTab(string tekst)
        {
            Write(tekst);

            for (int i = 0; i < this.size; i++)
                Write(this.tab[i] + " ");

            Write(Environment.NewLine);
        }
        protected bool Confirm()
        {
            return this.size > 0;
        }
        protected void Write(string text)
        {
            Console.Write(text);
        }
    }
}
