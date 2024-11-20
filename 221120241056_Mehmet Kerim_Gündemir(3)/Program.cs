using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221120241056_Mehmet_Kerim_Gündemir_3_
{
    internal class Program
    {
        static public void Öğrenci()
        {
            string adi = "Mehmet Kerim";
            string soyadi = "Gündemir";

            Console.WriteLine(adi + soyadi);
            
        }
        static public void Hesapla()
        {
            int not1 = 50;
            int not2 = 76;

            Console.WriteLine(not1 + not2 / 2);


        } 
        static void Main(string[] args) 
        {
            Öğrenci();
            Hesapla();      
        }
    }

}
