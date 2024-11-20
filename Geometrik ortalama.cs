using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

       
            
            {
                
                Console.Write("Birinci sayıyı girin: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci sayıyı girin: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

               
                double geometrikOrtalama = Math.Sqrt(sayi1 * sayi2);

                
                Console.WriteLine("Girilen sayıların geometrik ortalaması: " + geometrikOrtalama);
            }
                Console.ReadLine();
        }




    }
}

