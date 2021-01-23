using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1234;
            musteri1.MusteriNo = "1232";
            musteri1.Adi = "Furkan";
            musteri1.Soyadi = "Bozkurt";
            musteri1.TcNo = "1524152121";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 123654;
            musteri2.MusteriNo = "151210";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "444466655";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();



        }
    }
}
