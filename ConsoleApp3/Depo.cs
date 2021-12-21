using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate void OlayYakalayici(object sender, int bulunduguIndis);
    class Depo
    {
        List<Urun> urunler = new List<Urun>();

        public event OlayYakalayici Bulundu;

        public void Ekle(Urun urun)
        {
            urunler.Add(urun);
        }

        public void Bul(int urunID)
        {
            for (int i = 0; i < urunler.Count; i++)
            {
                if (urunler[i].UrunID == urunID && Bulundu != null)
                {
                    Bulundu(urunler[i], i);
                }
            }
        }


    }
}
