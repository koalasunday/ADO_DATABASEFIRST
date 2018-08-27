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
            Console.WriteLine("Menu");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Products");
            Console.Write("Tentukan Pilihanmu : "); pil = Convert.ToInt32(Console.ReadLine());



            switch (pil)
            {
                case 1:
                    CustomerController panggilcs = new CustomerController();
                    panggilcs.Menu();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}