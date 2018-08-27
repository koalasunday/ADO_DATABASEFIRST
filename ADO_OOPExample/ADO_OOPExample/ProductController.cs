using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_OOPExample
{
    class ProductController
    {
        Models.TestADO_OOPEntities _context = new Models.TestADO_OOPEntities();
        //int input;
        public void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("       Sub Menu       ");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("1. Insert Data");
            System.Console.WriteLine("2. Update Data");
            System.Console.WriteLine("3. Delete Data");
            System.Console.WriteLine("4. Select All Data");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("        - END -       ");
            System.Console.WriteLine("----------------------");
            System.Console.Write("pilihan kalian : ");
            int choice = Convert.ToInt32(System.Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Insert();
                    System.Console.Read();
                    break;
                case 2:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    int input = Convert.ToInt32(System.Console.ReadLine());
                    //Update(input);
                    break;
                case 3:
                    // update();
                    System.Console.Read();
                    break;
                case 4:
                   // Select();
                    System.Console.Read();
                    break;
                default:
                    System.Console.Write("Periksa kembali");
                    System.Console.Read();
                    break;
            }
        }

        /*   public void Insert()
           {
               Console.Clear();
               System.Console.Write("Please Input data of Customer : ");
               System.Console.Write("Id      : ");
               string Id = System.Console.ReadLine();
               System.Console.Write("Name    : ");
               string Nama = System.Console.ReadLine();
               System.Console.Write("Harga : ");
               string Harga = System.Console.ReadLine();
               System.Console.Write("Stok : ");
               string Stok = System.Console.ReadLine();


               Products call = new Products();
               {
                   call.ID = Id;
                   call.NAME = Nama;
                   call.PRICE = Harga;
                   call.stock = Stok;
               };
               try
               {
                   _context.customers.Add(call);
                   var result = _context.SaveChanges();
               }
               catch (Exception ex)
               {
                   System.Console.Write(ex.InnerException);
               }
           }*/

     /*   public List<Products> Select()
        {
            Console.Clear();
            var getall = _context.customers.ToList();
            System.Console.WriteLine("Select All Data of Customers");
            System.Console.WriteLine("\n");
            foreach (Products pro in getall)
            {
                System.Console.WriteLine("ID : " + pro.ID);
                System.Console.WriteLine("NAME : " + pro.NAME);
                System.Console.WriteLine("Harga : " + pro.PRICE);
                System.Console.WriteLine("Stok : " + pro.STOCK);
                System.Console.WriteLine("\n");
            }
            System.Console.WriteLine("--------------------------------------------");
            return getall;
        }*/

    }
}
