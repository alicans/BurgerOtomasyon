using HamburgerciData;
using System.ComponentModel;

namespace HamburgerciForm
{
    public partial class MenuEkleForm : Form
    {
        private readonly GenelData _db;

        public MenuEkleForm(GenelData db)
        {
            _db = db;
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // menü adını al
            string menuAd = txtMenuAdi.Text.Trim();

            // menü adı boşsa hata ver
            if (string.IsNullOrEmpty(menuAd))
            {
                MesajGoster("Menü adı boş olamaz.");
                return;
            }

            // menü adı daha önce eklenmişse hata ver
            foreach (var item in _db.menuler)
            {
                if (item.MenuAd == menuAd)
                {
                    MesajGoster("Menü adı daha önce eklenmiş.");
                    return;
                }
            }

            // her şey tamamsa yeni menüyü ekle
            decimal fiyat = nudMenuFiyat.Value;
            _db.menuler.Add(new Menu { MenuAd = menuAd, Fiyat = fiyat });

            // formu gönderdikten sonra temizle
            Temizle();

            // menü eklendikten sonra mesaj göster
            MesajGoster("Menü eklendi.");
        }

        private void Temizle()
        {
            txtMenuAdi.Clear();
            nudMenuFiyat.Value = 1;
        }

        void MesajGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
