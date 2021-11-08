using System;

namespace ClassAndMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler guest = new Musteriler();
            guest.Musteri_Id = 1;
            guest.Musteri_Ad = "Kadir";
            guest.Musteri_SoyAd = "Erdem";

            Musteriler[] y = new Musteriler[] { guest };

            foreach (var x in y)
            {
                Console.WriteLine("Müşteri Id'si: " + guest.Musteri_Id + "\n" + "Müşteri Adı: " + guest.Musteri_Ad + "\n" + "Müşteri Soyadı: " + guest.Musteri_SoyAd);

                Console.WriteLine("**********");
            }


            Console.WriteLine("*****************");
            MusterileriYonet musterileriYonet = new MusterileriYonet();
            musterileriYonet.Ekle(guest);
            Console.WriteLine("*****************");

            musterileriYonet.Sil(guest);
            Console.WriteLine("*****************");
            musterileriYonet.Listele(guest);


            // MÜŞTERİ TAKİP SİMİLAYSONU EKLEME-SİLME-LİSTELEME İŞLEVİ OLAN BİR SİMİLASYON...

            Console.ReadKey();
        }
    }
}
