using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Ekstralar:Urun
    {
        public string EkstraAd { get; set; }
        public static List<Ekstralar> EkstraListesi = new List<Ekstralar>();
    }
}
