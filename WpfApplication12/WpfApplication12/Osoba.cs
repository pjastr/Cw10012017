using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication12
{
    internal class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;

        public Osoba()
        {

        }

        public void UstawDane(string imie, string nazwisko, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public override string ToString()
        {
            return imie+Environment.NewLine+nazwisko+Environment.NewLine+dataUrodzenia.ToString("dd.MM.yyyy");
        }
    }
}
