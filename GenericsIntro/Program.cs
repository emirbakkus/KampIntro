﻿namespace GenericsIntro { 
internal class Program
{
    private static void Main(string[] args)
    {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Emir");

            Console.WriteLine("Hello, World!");
    }
}
}