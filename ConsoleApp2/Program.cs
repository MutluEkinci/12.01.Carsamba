using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void OlayYakalayıcı();
    class Depo<T> where T : class
    {
        List<T> list = new List<T>();

        public void Ekle(T t)
        {
            if (list.Count < 10)
                list.Add(t);
            else if (DepoDoldu != null)
            {
                DepoDoldu();
            }
        }
        public void Çıkar(T t)
        {
            list.Remove(t);
            if (list.Count == 0 && DepoBoş != null)
            {
                DepoBoş();
            }
        }


        public event OlayYakalayıcı DepoBoş;
        public event OlayYakalayıcı DepoDoldu;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 2:10 adet buzdolabı alan bir depo icin;ekleme çıkarma işlemleri yapan nesneyi yazınız.Sonra depo dolduğunda veya boş olduğunda kullanıcıyı bilgilendirecek olayları tanımlayınız ve kullanınız.
            Depo<Buzdolabi> d = new Depo<Buzdolabi>();
            d.DepoDoldu += D_DepoDoldu;
            d.DepoBoş += D_DepoBoş;

            Buzdolabi buzdolabi = new Buzdolabi();
            for (int i = 0; i < 12; i++)
            {
                d.Ekle(buzdolabi);
            }
            for (int i = 0; i < 12; i++)
            {
                d.Çıkar(buzdolabi);
            }

        }

        private static void D_DepoBoş()
        {
            Console.WriteLine("Depo boş");
        }
        private static void D_DepoDoldu()
        {
            Console.WriteLine("Depo dolu");
        }
    }
}
