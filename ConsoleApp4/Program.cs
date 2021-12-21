using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Personel
    {
        public int ID { get; set; }
    }
    class Urun
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
              LINQ(Language Integrated Quary)(Dil içerisine entegre edilmiş sorgulama)     
            *********Data!= Object*********
            linq c#3.0
            1-var(gelen değere göre tipi oluşturur. Sonuç kümesinin ne olucağını kestiremediğimiz durumlarda tercih edilir. Okunabilirlik açısından iyi değildir.
            2-auto prop
            3-object init.
            4-collection init.
            5-anonymous object
            6-extension methods 
            7-expression tree
            8-lambda expression 

            */
            //1-var
            var sayi = 10;
            var isim = "Cevdet";
            var kontrol = true;
            var fiyat = 34.99;
            var urun = new Urun();
            var c = 'A';

            //c#4.0

            dynamic sayi1 = 12;
            dynamic ad = "Selami";

            sayi1 = "Dursun";

            object obj = 12;
            //int s = obj;

            dynamic obj2 = 12;//tip dönüşümü yapmak zorunda değilsiniz.oluşturduğunuz yapının hangi tipte olduğunu bilir dynamic.
            int s2 = obj2;

            //2,3,4
            //2-auto prop:değişkene ihtiyaç duymadan yazar.(satır 7)

            //3-object init.:ctora gerek duymadan ilk değer ataması için kullanılan yapı.
            Personel p1 = new Personel() { ID = 123 };

            //4-collection init.
            List<Personel> personeller = new List<Personel> { new Personel() { ID = 123 }, new Personel() { ID = 135 } };

            //5-anonymous object:class ismi olmadan obje tanımlamasına denir.
            var m = new { MusID = 123, MusAdi = "Cevdet" };

            



        }
    }
}
