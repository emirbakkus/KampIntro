
namespace DegerVeReferansTipler { 

internal class Program
{
    private static void Main(string[] args)
    {
        // int , decimal , double , float , bool = değer tip
        // array , class ,  interface = referans tip  

        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        // sayi1 ??  = 30

        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
            foreach (var sayilar in sayilar1)
            {
                Console.WriteLine(sayilar);
            }
            //sayilar1[0] = 999 

        }
}
}