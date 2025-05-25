using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array -dizi

             string[] kurslar = new string[] {"Yazılım","Programlama","Java","Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                   Console.WriteLine(kurs); 
            }

            Console.WriteLine("sayfa sonu - footer");

            // bir kişinin oluşturabileceği 6 haneli tüm şifrelerin olduğu bir string liste
            //string[] rakamlar = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

           
            //foreach (string rakam1 in rakamlar)
            //{
            //    foreach (string rakam2 in rakamlar)
            //    {
            //        foreach (string rakam3 in rakamlar)
            //        {
            //            foreach (string rakam4 in rakamlar)
            //            {
            //                foreach (string rakam5 in rakamlar)
            //                {
            //                    foreach (string rakam6 in rakamlar)
            //                    {
            //                        Console.WriteLine(rakam1 + rakam2 + rakam3 + rakam4 + rakam5 + rakam6);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

        }
        
    }
}
