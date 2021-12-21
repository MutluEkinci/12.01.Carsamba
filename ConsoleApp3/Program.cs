using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            //Soru 3:5 elemanlı bir ürün listesi üzerinde aranılan ve bulunan elemanın indisini olay(arama,bulundu) üzerinden donduren yapıyı oop kullanarak yazınız.

            Depo depo = new Depo();
            depo.Ekle(new Urun { UrunID = 111, UrunAdi = "A4 Defter", Fiyat = 25 });
            depo.Ekle(new Urun { UrunID = 145, UrunAdi = "Pergel", Fiyat = 20 });
            depo.Ekle(new Urun { UrunID = 133, UrunAdi = "Silgi", Fiyat = 5 });
            depo.Ekle(new Urun { UrunID = 101, UrunAdi = "Gönye", Fiyat = 30 });
            depo.Ekle(new Urun { UrunID = 970, UrunAdi = "Kalem", Fiyat = 15 });

            
            depo.Bulundu += Depo_Bulundu;
            depo.Bul(111);

        }

        private static void Depo_Bulundu(object sender, int bulunduguIndis)
        {
            Urun urun = (Urun)sender;
            Console.WriteLine(urun.UrunID + " " + urun.UrunAdi + " " + urun.Fiyat + " " + "Bulunduğu İndis " + bulunduguIndis);
        }
    }
}
