using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._12.Çarşamba
{
    public delegate void OlayYakalayici();
    class Isitici
    {
        private int _isi;
        public int Isi
        {
            get { return _isi; }
            set
            {
                _isi = value;
                if (_isi > 30 && _isi < 50 && Kabarciklanma != null)
                    Kabarciklanma();
                else if (_isi >= 50 && _isi < 80 && SesCikar != null)
                    SesCikar();
                else if (_isi >= 80 && _isi < 95 && Kaynama != null)
                    Kaynama();
                else if (_isi >= 95 && Fokurdama != null)
                    Fokurdama();

            }
        }
        public event OlayYakalayici Kabarciklanma;
        public event OlayYakalayici SesCikar;
        public event OlayYakalayici Kaynama;
        public event OlayYakalayici Fokurdama;

        public void Isit()
        {
            for (int i = 0; i < 120; i++)
            {
                for (int j = 0; j < 999999; j++) ;
                Isi++;
                Console.Write(Isi);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 1:Isıtıcı sorusu
            Isitici isitici1 = new Isitici();

            isitici1.Kabarciklanma += İsitici1_Kabarciklanma;
            isitici1.SesCikar += İsitici1_SesCikar;
            isitici1.Kaynama += İsitici1_Kaynama;
            isitici1.Fokurdama += İsitici1_Fokurdama;

            isitici1.Isit();
        }

        private static void İsitici1_Fokurdama()
        {
            Console.WriteLine("Fokur fokur");
        }

        private static void İsitici1_Kaynama()
        {
            Console.WriteLine("Kayna...");
        }

        private static void İsitici1_SesCikar()
        {
            Console.WriteLine("sss sss");
        }

        private static void İsitici1_Kabarciklanma()
        {
            Console.WriteLine(" o O o OO o");
        }
    }
}
