using HamburgerciData;

namespace HamburgerciForm
{
    public partial class AnaKapsayiciForm : Form
    {
        // listelerin bulundu�u s�n�f
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

            // bu ana formun �ocuklar� i�erisinde gezelim
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true;
                    form.Show(); //istenenin a��lmas�
                }
                else
                    form.Close(); //a��k olan varsa kapat�lmas�
            }
            if (!durum)
            {
                secilenForm.MdiParent = this;
                secilenForm.Show();
            }
        }

        private void OrnekVerileriYukle()
        {
            db.menuler.Add(new Menu() { MenuAd = "Big King Men�", Fiyat = 102 });
            db.menuler.Add(new Menu() { MenuAd = "Double King Chicken Men�", Fiyat = 95 });
            db.menuler.Add(new Menu() { MenuAd = "Steakhouse Men�", Fiyat = 130 });
            db.menuler.Add(new Menu() { MenuAd = "Whopper Men�", Fiyat = 107 });
            db.menuler.Add(new Menu() { MenuAd = "Whopper Jr. Men�", Fiyat = 84 });
            db.menuler.Add(new Menu() { MenuAd = "Chicken Royale Men�", Fiyat = 90 });

            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Hardal", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Sar�msakl� Mayonez", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Ket�ap", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Barbek� Sos", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Ac� Sos", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Ranch Sos", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Ball� Hardal", Fiyat = 10m });
            db.ekstraMalzemeler.Add(new EkstraMalzeme() { MalzemeAd = "Buffalo Sos", Fiyat = 10m });
        }
    }
}