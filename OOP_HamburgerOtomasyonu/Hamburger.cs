using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Hamburger:Urun
    {
        public string MenuAd { get; set; }
        public static List<Hamburger> Hamburgerler = new List<Hamburger>();

        public override string ToString()
        {
            return MenuAd;
        }
    }
}
