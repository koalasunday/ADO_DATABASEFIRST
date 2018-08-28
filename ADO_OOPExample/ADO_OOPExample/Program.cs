using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {

            int pil;
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("       MENU UTAMA     ");
            System.Console.WriteLine("----------------------");
            Console.WriteLine("  1. CUSTOMERS");
            Console.WriteLine("  2. PRODUCTS");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("\n");
            Console.Write("Tentukan Pilihanmu : ");
            pil = Convert.ToInt32(Console.ReadLine());



            switch (pil)
            {
                case 1:
                    CustomerController panggil1 = new CustomerController();
                    panggil1.Menu();
                    break;
                case 2:
                    ProductsController panggil2 = new ProductsController();
                    panggil2.Menu();
                    break;
                default:
                    break;
            }
        }
    }
}