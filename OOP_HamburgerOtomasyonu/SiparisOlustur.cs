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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        decimal Toplam = 0;
        string sos = " ";
        int chktutar = 0;
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            //Hamburger hamburger = new Hamburger();
            //lblToplamTutar.Text = hamburger.Fiyat.ToString();
            foreach (Hamburger hamburger in Hamburger.Hamburgerler)
            {
                if (hamburger.MenuAd == cmbMenu.Text)
                {
                    Toplam += hamburger.Fiyat;
                    MessageBox.Show(Toplam.ToString());
                }
            }

            Siparis siparis = new Siparis();
            siparis.SeciliMenu = (Hamburger)cmbMenu.SelectedItem;
            foreach (Control kontrol in this.flwEkstra.Controls)
            {
                if (kontrol is CheckBox)
                {
                    if (((CheckBox)kontrol).Checked == true)

                    {
                        chktutar += 1;
                       sos = (((CheckBox)kontrol).Text.ToString());
                       MessageBox.Show(sos);
                    }
                }
                Toplam += chktutar;
            }
            foreach (Control control in this.groupBox1.Controls)
            {
                //if (control is RadioButton)
                //{
                //    if (((RadioButton)control).Checked == true)
                //    {
                //        switch ()
                //        {
                //            case rbBuyuk
                            
                //                break;
                //        }
                //    }
                //}
            }

            string format = string.Format("menü: {0} , soslar: {1}", cmbMenu.Text, sos);
            listBox1.Items.Add(format);
            lblToplamTutar.Text = Toplam.ToString();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            cmbMenu.DataSource = Hamburger.Hamburgerler.ToList();

            foreach (Ekstralar ekstralar in Ekstralar.EkstraListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstralar.EkstraAd;
                flwEkstra.Controls.Add(chk);
            }
            
        }
        int fiyat = 0;
        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
