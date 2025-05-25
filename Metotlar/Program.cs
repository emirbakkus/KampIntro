
namespace Metotlar
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 0;
            string aciklama = "Amasya Elması";


            Urun urun1 = new Urun();  //class'ın örneği
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2= new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2, };

            foreach (Urun urun in urunler)
            {
                 Console.WriteLine(urun.Adi);
                 Console.WriteLine(urun.Fiyati);
                 Console.WriteLine(urun.Aciklama);
                 Console.WriteLine("------------------");
            }


            Console.WriteLine("----------------Metotlar---------");

            //instance - örnek
            //encapsulation - kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Deveci Armut", 12 , 5 );
            sepetManager.Ekle2("Elma", "Yeşil", 15 , 8);
            sepetManager.Ekle2("Karpuz", "Kesmece", 18 , 9 );
        }
    }
}
