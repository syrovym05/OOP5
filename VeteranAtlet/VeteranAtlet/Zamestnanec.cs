using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeteranAtlet
{
    class Zamestnanec
    {
        protected string jmeno;
        protected string prijmeni;
        protected DateTime datumNastupu;        
        protected int odpracHodiny;     
        public int HodinovaMzda { get; }

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.HodinovaMzda = hodinovaMzda;
        }

        public double PocetDni()
        {
            return Math.Round((DateTime.Today - datumNastupu).TotalDays,0);
        }

        public void OdporacujHodiny(int hodiny)
        {
            odpracHodiny += hodiny;
        }

        public int VypoctiMzdu()
        {
            return HodinovaMzda * odpracHodiny;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} s hodinovou mzdou: {2} a odpracovanym pocet dnu: ",jmeno, prijmeni,HodinovaMzda,PocetDni());
        }



    }
}
