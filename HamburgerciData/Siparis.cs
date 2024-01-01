using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciData
{
    public class Siparis
    {
        public Menu SecilenMenu { get; set; } = new();
        public UrunBoyut Boyut { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; } = new();
        public int Adet { get; set; }
        public decimal ToplamTutar { get { return TutarHesapla(); } }
        public decimal EkstraMalzemeGeliri { get { return EkstraMalzemeler.Sum(x => x.Fiyat); } }

        public override string ToString()
        {
            string ekstraMalzemeler;

            // ekstra malzeme yoksa boş string döndür
            if (EkstraMalzemeler.Count == 0)
                ekstraMalzemeler = "";

            // varsa ekstra malzemeleri virgül ile ayırarak bir string'e dönüştür.
            else
                ekstraMalzemeler = " (" + string.Join(", ", EkstraMalzemeler.Select(m => m.MalzemeAd)) + ") -";


            return $"{SecilenMenu.MenuAd} x {Adet} Adet, {Boyut} Boy,{ekstraMalzemeler} Toplam {ToplamTutar:c2}";
        }

        public decimal TutarHesapla()
        {
            decimal yuzde = 1;
            //boyut'un değerine göre belirli yüzdesini al
            //örneğin boyut büyükse %20'sini al
            //boyut orta ise %10'unu al
            if (Boyut == UrunBoyut.Buyuk)
                yuzde = 1.2m;
            else if (Boyut == UrunBoyut.Orta)
                yuzde = 1.1m;

            return Adet * (yuzde * (SecilenMenu.Fiyat + EkstraMalzemeler.Sum(x => x.Fiyat)));
        }

    }
}
