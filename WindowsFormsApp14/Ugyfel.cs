using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class Ugyfel
    {
        int azon;
        string nev;
        decimal irszam;
        decimal szulev;
        string orszag;

        public Ugyfel(int azon, string nev, decimal irszam, decimal szulev, string orszag)
        {
            this.azon = azon;
            this.nev = nev;
            this.irszam = irszam;
            this.szulev = szulev;
            this.orszag = orszag;
        }

        public int Azon { get => azon; set => azon = value; }
        public string Nev { get => nev; set => nev = value; }
        public decimal Irszam { get => irszam; set => irszam = value; }
        public decimal Szulev { get => szulev; set => szulev = value; }
        public string Orszag { get => orszag; set => orszag = value; }

        public override string ToString()
        {
            return this.nev;
        }
    }
}
