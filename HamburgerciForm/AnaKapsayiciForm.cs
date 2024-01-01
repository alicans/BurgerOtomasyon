using HamburgerciData;

namespace HamburgerciForm
{
    public partial class AnaKapsayiciForm : Form
    {
        // listelerin bulunduðu sýnýf
        GenelData db = new GenelData();

        public AnaKapsayiciForm()
        {
            InitializeComponent();
             OrnekVerileriYukle();
        }

        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisEklemeForm(db));
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgileriForm(db));
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new MenuEkleForm(db));
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new EkstraMalzemeEkleForm(db));
        }

        public void FormGoster(Form secilenForm)
        {
            secilenForm.StartPosition = 0;

            // bu ana formun çocuklarý içerisinde gezelim
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true;
                    form.Show(); //istenenin açýlmasý
                }
                else
                    form.Close(); //açýk olan varsa kapatýlmasý
            }
            if (!durum)
            {
                secilenForm.MdiParent = this;
                secilenForm.Show();
            }
        }

        private void OrnekVerileriYukle()
        {
            db.menuler.Add(new Menu() { MenuAd = "Big King Menü", Fiyat = 102 });
            db.menuler.Add(new Menu() { MenuAd = "Double King Chicken Menü", Fiyat = 95 });
            db.menuler.Add(new Menu() { MenuAd = "Steakhouse Menü", Fiyat = 130 });
            db.menuler.Add(new Menu() { MenuAd = "Whopper Menü", Fiyat = 107 });
            db.menuler.Add(new Menu() { MenuAd = "Whopper Jr. Menü", Fiyat = 84 });
            db.menuler.Add(new Menu() { MenuAd = "Chicken Royale Menü", Fiyat = 90 });

            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Hardal", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Sarýmsaklý Mayonez", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Ketçap", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Barbekü Sos", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Acý Sos", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Ranch Sos", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Ballý Hardal", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Buffalo Sos", Fiyat = 10m });
        }
    }
}