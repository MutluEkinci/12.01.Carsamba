using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Deneme
    {
        public event EventHandler Tikla;

        public void Tetikle()
        {
            if (Tikla != null) //metot varsa tıkla eventini tetikle yoksa tetikleme demek.
            Tikla(this,new EventArgs());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deneme d = new Deneme();
            //d.Tikla += D_Tikla;
            d.Tetikle();
        }

        private static void D_Tikla(object sender, EventArgs e)
        {
            
        }
    }
}
