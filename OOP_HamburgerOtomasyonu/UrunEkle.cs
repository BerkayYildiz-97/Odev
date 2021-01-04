using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerOtomasyonu
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hamburger hamburger = new Hamburger();
            hamburger.Ad = txtMenu.Text;
            hamburger.Fiyat = nudFiyat.Value;
            Hamburger.Hamburgerler.Add(hamburger);
        }
    }
}
