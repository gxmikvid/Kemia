using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemia
{
    class Anyag
    {
        public int Ev;
        public string Nev;
        public string Vegyjel;
        public int Rendszam;
        public string Felfedezo;

        public Anyag(int ev, string nev, string vegyjel, int rendszam, string felfedezo)
        {
            this.Ev = ev;
            this.Nev = nev;
            this.Vegyjel = vegyjel;
            this.Rendszam = rendszam;
            this.Felfedezo = felfedezo;
        }
    }
}
