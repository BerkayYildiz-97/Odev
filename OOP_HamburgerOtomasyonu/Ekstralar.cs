using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Ekstralar:Urun
    {

        public static List<Ekstralar> EkstraListesi = new List<Ekstralar>()
        {
            new Ekstralar{Ad="Ranch",Fiyat=1},
            new Ekstralar{Ad="Barbekü sos",Fiyat=1}
        };

        public override string ToString()
        {
            return Ad;
        }
    }
}
