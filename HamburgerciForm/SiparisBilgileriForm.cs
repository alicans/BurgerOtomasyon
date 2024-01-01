using HamburgerciData;

namespace HamburgerciForm
{
    public partial class SiparisBilgileriForm : Form
    {
        private readonly GenelData _db;
        public SiparisBilgileriForm(GenelData db)
        {
            _db = db;
            InitializeComponent();
            lstTumSiparisler.DataSource = _db.siparisler;
        }

        private void SiparisBilgileriForm_Load(object sender, EventArgs e)
        {
            lblCiro.Text = _db.siparisler.Sum(x => x.ToplamTutar).ToString("C2");
            lblToplamSiparis.Text = _db.siparisler.Count.ToString();
            lblEMGeliri.Text = _db.siparisler.Sum(x => x.EkstraMalzemeGeliri).ToString("C2");
        }


    }
}
