﻿namespace OOP2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Emir";
            musteri1.Soyadi = "Akkuş";
            musteri1.TcNo = "12345678910";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;    
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Disiplin";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri(); //new gördüğümüz anda referans numarası 
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();   
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


            //Gerçek Müşteri - Tüzel Müşteri 
            //SOLID PRINCIPLE
        }
    }
}