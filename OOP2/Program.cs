using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.İd = 1;
            musteri1.Adi = "Canan";
            musteri1.Soyadi = "Bektas";
            musteri1.TcNo = "123456789";
            musteri1.MusteriNo = "12345";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.İd = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama";
            musteri2.VergiNo = "123456789";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);

        }
    }
}
