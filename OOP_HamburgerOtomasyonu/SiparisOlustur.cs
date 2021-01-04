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
        decimal toplamFiyat = 0;
        string soslar = " ";
        decimal ekstraFiyat = 0;
        decimal menuFiyat = 0;
        decimal siparisFiyat = 0;
        int extraMalzemeAdedi = 0;
        int toplamExtraMalzemeAdedi = 0;

        Siparis siparis = new Siparis();
        Hamburger menu = new Hamburger();
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (nudAdet.Value > 0 && cmbMenu.SelectedItem != null)
            {
                

                foreach (Hamburger hamburger in Hamburger.Hamburgerler)
                {
                    if (hamburger.Ad == cmbMenu.Text)
                    {
                        menuFiyat = hamburger.Fiyat;
                        //MessageBox.Show(menuFiyat.ToString());
                    }
                }
                menu.Ad = cmbMenu.SelectedItem.ToString();

                if (rbOrta.Checked)
                {
                    menuFiyat += 2;
                    menu.Boyut = Boyut.orta;
                }
                else if (rbKucuk.Checked)
                {
                   // menuFiyat = menu.Fiyat;
                    menu.Boyut = Boyut.kucuk;
                }
                else if (rbBuyuk.Checked)
                {
                    menuFiyat += 5;
                    menu.Boyut = Boyut.buyuk;
                }

                foreach (Control kontrol in this.flwEkstra.Controls)
                {
                    CheckBox checkbox = (CheckBox)kontrol;
                    foreach (Ekstralar ekstra in Ekstralar.EkstraListesi)
                    {
                        if (checkbox.Checked)
                        {
                            if (checkbox.Text == ekstra.Ad)
                            {
                                ekstraFiyat += ekstra.Fiyat;
                                soslar += ekstra.Ad + " ";
                                extraMalzemeAdedi++;
                            }
                        }
                    }
                }
                menu.Adet = Convert.ToInt32(nudAdet.Value);

                siparisFiyat = (menuFiyat + ekstraFiyat) * menu.Adet;
                toplamFiyat += siparisFiyat;

                listBox1.Items.Add($"{menu.Ad}-{" [soslar: "+ soslar+" ] "}-{" " + menu.Adet + " Adet "}-{" (Boyut: " + menu.Boyut+ ")"}-{" Fiyat: " + siparisFiyat}");

                lblToplamTutar.Text = toplamFiyat.ToString();

               

                toplamExtraMalzemeAdedi += extraMalzemeAdedi;

                Siparis.Ciro += siparisFiyat;
                Siparis.ToplamSiparisSayisi ++;
                Siparis.ExtraMalzemeGeliri += ekstraFiyat * menu.Adet;
                Siparis.SatilanUrunAdedi = ( Siparis.ToplamSiparisSayisi + toplamExtraMalzemeAdedi) * menu.Adet;

                Siparis.siparisler.Add(siparis);
            }

            else
            {
                MessageBox.Show("Lütfen sipariş adedi seçip sipariş menüsü giriniz");
            }

            siparisFiyat = 0;
            soslar = "";
            ekstraFiyat = 0;
            extraMalzemeAdedi = 0;
        }
        void Temizle()
        {
            toplamFiyat = 0;
            listBox1.Items.Clear();
            cmbMenu.SelectedItem = null;
            lblToplamTutar.Text = "0";
            foreach (RadioButton ctrl in groupBox1.Controls)
            {
                ctrl.Checked = false;
            }
            foreach (CheckBox ctrl in flwEkstra.Controls)
            {
                ctrl.Checked = false;
            }
            nudAdet.Value = 0;
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            cmbMenu.DataSource = Hamburger.Hamburgerler.ToList();

            foreach (Ekstralar ekstralar in Ekstralar.EkstraListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstralar.Ad;
                flwEkstra.Controls.Add(chk);
            }
            
        }
        
        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Toplam Sipariş Sayısı: " + listBox1.Items.Count + "\nToplam Sipariş Tutarı:" + toplamFiyat.ToString("C2") + "\nSiparişi Tamamlamak istiyor musunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            {
                
                //siparis.Ad = menu.Ad;
                //siparis.Fiyat = siparisFiyat;
                //siparis.Adet = listBox1.Items.Count;
                
                Temizle();
            }
            else
            {
                MessageBox.Show("işleminiz iptal edilmiştir , kaldığınız yerden devam edebirsiniz");
            }
        }


    }
}
