using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Siparis
    {
        public Hamburger SeciliMenu { get; set; }
        //public Hamburger Fiyat { get; set; }
        public List<Ekstralar> Ekstra { get; set; }
        public int Adet { get; set; }

        public Boyut Boyut { get; set; }
        public decimal AraToplam { get; set; }

        //public void TutarHesapla()
        //{
        //    AraToplam += SeciliMenu.Fiyat;
            
        //}

    }
}
