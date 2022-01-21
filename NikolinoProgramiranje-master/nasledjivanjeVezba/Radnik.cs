using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledjivanjeVezba
{
    class Radnik
    {
        public string ime;
        public string prezime;
        public string jmbg;
        public double zarada;

        public Radnik(string ime, string prezime, string jmbg, double zarada)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.zarada = zarada;

        }

        public double godisnjaZarada()
        {
            return 12 * zarada;
        }

    }
    
}
