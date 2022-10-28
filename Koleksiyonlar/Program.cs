using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] isimler = new string[] { "Canan", "Halim", "Bektaş" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);

            isimler = new string[5];
            isimler[4]="AdilAsaf";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Canan","Halim"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Bektas");
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[1]);
        }
    }
}
