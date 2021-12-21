using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    static class Ekle
    {
        public static int KareAl(this int sayi)//hangi yapıya ekliceksen metodu ilk parametrede thisden sonra onu ekle.bu parametrede demek.
        {
            return sayi * sayi ;
        }
        public static int Kuvvet(this int sayi,int k)
        {
            int sonuc = 1;

            for (int i = 0; i < k; i++)
            {
                sonuc *= sayi;
            }
            return  sonuc;
        }

        public static string TersCevir(this string str)
        {
            string strTers = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strTers += str[i];
            }
            return strTers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //6-extension methods:
            //1-static metodlara yazılmak zorunda.2-sınıf static olduğu için metod da static olur.3-

            int sayi = 12;
            string isim = "Cevdet";

            Console.WriteLine(sayi.KareAl());

            Console.WriteLine(isim.TersCevir());
            Console.WriteLine(sayi.Kuvvet(3));

        }
    }
}
