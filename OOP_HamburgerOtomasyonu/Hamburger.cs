using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Hamburger:Urun
    {
        public Boyut Boyut { get; set; }
        public static List<Hamburger> Hamburgerler = new List<Hamburger>()
        {
            new Hamburger{Ad="King Chicken",Fiyat=15},
            new Hamburger{Ad="Big king",Fiyat=18},
            new Hamburger{Ad="Whooper",Fiyat=20}
        };

        public override string ToString()
        {
            return Ad;
        }
    }
}
