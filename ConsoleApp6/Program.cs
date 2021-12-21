using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    static class Genisletme
    {
        public static int Kare(this int sayi)
        {
            return sayi * sayi;
        }
        public static int Kup(this int sayi)
        {
            return sayi * sayi * sayi;
        }
        public static double IkiyeBol(this int sayi)
        {
            return (double)sayi / 2;
        }

        public static int Adet<T>(this IEnumerable<T> x)
        {
            return x.Count();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Soru 1:bir sayının karesini,kupunu ve sayıyı ikiye bölen metodları "extension" olarak yazınız.
            int sayi = 3;
            Console.WriteLine(sayi.Kup());
            Console.WriteLine(sayi.IkiyeBol());


            List<int> sayilar = new List<int> { 3, 5, 7, 8, 4, 5, 67 };
            Console.WriteLine(sayilar.Adet());

            string[] sehirler = { "Adana", "Bursa", "İstanbul" };
            Console.WriteLine(sehirler.Adet());

            //7-Expression tree
            
            Console.WriteLine(sayi.Kare().Kup().IkiyeBol());

            //8-Lambda Expression 

            foreach (int s in sayilar.Where(x=>x %2==1))
                Console.WriteLine(s);
        }
    }
}
