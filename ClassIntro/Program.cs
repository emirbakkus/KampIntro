
namespace ClassIntro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string adi = "Emir";
            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Arif Yılmaz";
            kurs2.İzlenmeOrani = 56;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Kutay Demir";
            kurs3.İzlenmeOrani = 76;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Eğitmen = "Ali Veli";
            kurs4.İzlenmeOrani = 90;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen );

            Kurs[]kurslar= new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " ; " + kurs.Eğitmen + " ; " + kurs.İzlenmeOrani);
            }
        }

    }

    public class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}