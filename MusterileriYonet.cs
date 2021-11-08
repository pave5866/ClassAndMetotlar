using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndMetotlar
{
    class MusterileriYonet
    {
        public void Ekle(Musteriler musteriler)
        {
            Console.WriteLine(musteriler.Musteri_Id + " " + musteriler.Musteri_Ad + " " + musteriler.Musteri_SoyAd + " " + "Müşteriler Eklendi");
        }
        public void Sil(Musteriler musteriler)
        {
            Console.WriteLine(musteriler.Musteri_Id + " " + musteriler.Musteri_Ad + " " + musteriler.Musteri_SoyAd + " " + "Müşteriler Silindi");
        }
        public void Listele(Musteriler musteriler)
        {
            Console.WriteLine(musteriler.Musteri_Id + " " + musteriler.Musteri_Ad + " " + musteriler.Musteri_SoyAd + " " + "Müşteriler Listelendi");
        }
    }
}
