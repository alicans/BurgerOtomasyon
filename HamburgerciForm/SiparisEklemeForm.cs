using HamburgerciData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using RadioButton = System.Windows.Forms.RadioButton;

namespace HamburgerciForm
{
    public partial class SiparisEklemeForm : Form
    {
        private readonly GenelData _db;

        public SiparisEklemeForm(GenelData db)
        {
            _db = db;
            InitializeComponent();

            pbHamburger.Image = Image.FromFile("img\\hamburger.jpg");
            pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void SiparisEklemeForm_Load(object sender, EventArgs e)
        {
            // Menü seçimi için combobox'a menüleri ekle.
            cmbMenuSec.Items.AddRange(_db.menuler.ToArray());
            if (cmbMenuSec.Items.Count < 1)
            {
                cmbMenuSec.Items.Add("Lütfen Menü Ekleyiniz.");
                cmbMenuSec.SelectedIndex = 0;
                cmbMenuSec.Enabled = false;
                btnSiparisEkle.Enabled = false;
            }
            else
            {
                cmbMenuSec.Enabled = true;
                cmbMenuSec.SelectedIndex = 0;
            }

            // eğer ekstra malzemeler tanımlıysa
            if (_db.ekstraMalzemeler.Count > 0)
            {

                int i = 0;
                // Malzemeleri panel'e ekle.
                foreach (var malzeme in _db.ekstraMalzemeler)
                {
                    CheckBox mlz = new CheckBox();
                    mlz.Text = malzeme.MalzemeAd;
                    mlz.Tag = malzeme.Fiyat;
                    mlz.Top = 20 * i;
                    mlz.Width = pnlMalzeme.Width - 20;
                    pnlMalzeme.Controls.Add(mlz);
                    i++;
                }

            }

            // Boyutları checkbox'tan alalım
            rbBuyuk.Tag = UrunBoyut.Buyuk;
            rbOrta.Tag = UrunBoyut.Orta;
            rbKucuk.Tag = UrunBoyut.Kucuk;

            rbKucuk.Checked = true;

            // Sipariş listesini güncelle.
            Guncelle();


        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {

            // Sipariş nesnesi oluştur.
            Siparis siparis = new Siparis();

            siparis.SecilenMenu = (Menu)cmbMenuSec.SelectedItem!;
            siparis.Boyut = (UrunBoyut)pnlBoyut.Controls.OfType<RadioButton>()?.FirstOrDefault(x => x.Checked)?.Tag!;
            siparis.Adet = (int)nudMenuAdet.Value;

            // Ekstra malzemeleri listeye ekle.
            foreach (CheckBox chk in pnlMalzeme.Controls)
            {
                if (chk.Checked)
                {
                    siparis.EkstraMalzemeler.Add(new EkstraMalzeme { MalzemeAd = chk.Text, Fiyat = (decimal)chk.Tag! });
                }
            }

            // Siparişleri listeye ekle.
            _db.siparisler.Add(siparis);

            // Sipariş listesini güncelle.
            Guncelle();

            //formu defaulta döndür
            Sifirla();
        }

        private void Sifirla()
        {
            // Ek malzeme panelindeki bütün checkboxları uncheck et.
            foreach (CheckBox chk in pnlMalzeme.Controls)
            {
                chk.Checked = false;
            }

            // Boyut panelindeki bütün radiobuttonları uncheck et.
            foreach (RadioButton rb in pnlBoyut.Controls)
            {
                rb.Checked = false;
            }

            // Default değerleri ayarla
            rbKucuk.Checked = true;
            nudMenuAdet.Value = 1;
            cmbMenuSec.SelectedIndex = 0;

        }

        private void Guncelle()
        {
            // Sipariş listesini güncelle.
            lstSiparis.Items.Clear();
            foreach (var item in _db.siparisler)
            {
                lstSiparis.Items.Add(item);
                lblTopTutar.Text = _db.siparisler.Sum(x => x.ToplamTutar).ToString("C2");
            }
        }
    }
}
