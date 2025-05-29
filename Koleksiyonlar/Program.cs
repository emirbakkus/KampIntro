using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Steak               //heap
            string[] isimler = new string[] { "Emir", "Kerem", "Ali", "Orkun" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];
            isimler[4] = "Oğuzhan";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Emir", "Kerem", "Ali", "Orkun" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Oğuzhan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}