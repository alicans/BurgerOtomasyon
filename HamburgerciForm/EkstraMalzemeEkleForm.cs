using HamburgerciData;

namespace HamburgerciForm
{
    public partial class EkstraMalzemeEkleForm : Form
    {
        private readonly GenelData _db;
        public EkstraMalzemeEkleForm(GenelData db)
        {
            _db = db;
            InitializeComponent();
   
        }

        private void btnEMKaydet_Click(object sender, EventArgs e)
        {
            // ekstra malzeme adını al
            string ekstraMalzemeAd = txtEMAdi.Text.Trim();

            // ekstra malzeme adı boşsa hata ver
            if (string.IsNullOrEmpty(ekstraMalzemeAd))
            {
                MesajGoster("Ekstra malzeme adı boş olamaz.");
                return;
            }

            // ekstra malzeme adı daha önce eklenmişse hata ver
            foreach (var item in _db.ekstraMalzemeler)
            {
                if (item.MalzemeAd == ekstraMalzemeAd)
                {
                    MesajGoster("Ekstra malzeme adı daha önce eklenmiş.");
                    return;
                }
            }

            // her şey tamamsa yeni ekstra malzemeyi ekle
            decimal fiyat = nudEMFiyat.Value;
            _db.ekstraMalzemeler.Add(new EkstraMalzeme { MalzemeAd = ekstraMalzemeAd, Fiyat = fiyat });

            // formu gönderdikten sonra temizle
            Temizle();

            // ekstra malzeme eklendikten sonra mesaj göster
            MesajGoster("Ekstra malzeme eklendi.");
        }

        private void Temizle()
        {
            txtEMAdi.Clear();
            nudEMFiyat.Value = 1;
        }

        void MesajGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
