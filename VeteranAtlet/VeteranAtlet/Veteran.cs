using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeteranAtlet
{
    class Veteran : Atlet
    {
        private int vek;

        public Veteran( string jmeno, int vek) : base(jmeno)
        {
            this.vek = vek;
        }

        public override void Behej(int pocetKm)
        {
            for(int i = 0; i < pocetKm; i++)
            {
                if (unava >= 200)
                {
                    MessageBox.Show("běžec je moc unavený!!");
                    break;
                }
                unava += 10 + vek / 20;
            }

        }

        public override void Spi(int pocetHodin)
        {
            unava -= pocetHodin * 100 - 10 * (vek / 20);
            if (unava < 0)
                unava = 0;
        }
    }
}
