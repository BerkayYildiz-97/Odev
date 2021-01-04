using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Siparis:Urun
    {
        //public Hamburger SeciliMenu { get; set; }
        public List<Ekstralar> Ekstra { get; set; }
        public int Adet { get; set; }

        public Boyut Boyut { get; set; }
        

        public static List<Siparis> siparisler = new List<Siparis>();

        public static decimal Ciro { get; set; }
        public static int ToplamSiparisSayisi { get; set; }
        public static decimal ExtraMalzemeGeliri { get; set; }
        public static int SatilanUrunAdedi { get; set; }


    }
}
