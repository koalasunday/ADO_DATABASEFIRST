using ADO_OOPExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_OOPExample
{
    class ProductsController
    {
        Models.TestADO_OOPEntities _context = new Models.TestADO_OOPEntities();
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
                    Insert();
                    System.Console.Read();
                    break;
                case 2:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    string input = System.Console.ReadLine();
                    Update(input);
                    break;
                case 3:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    string input1 = System.Console.ReadLine();
                    delete(input1);
                    System.Console.Read();
                    break;
                case 4:
                    Select();
                    System.Console.Read();
                    break;
                default:
                    System.Console.Write("Periksa kembali");
                    System.Console.Read();
                    break;
            }
        }

        public void Insert()
        {
            Console.Clear();
            System.Console.Write("Please Input data of Product : ");
            System.Console.Write("Id      : ");
            string Id_PD = System.Console.ReadLine();
            System.Console.Write("Nama    : ");
            string Nama_PD = System.Console.ReadLine();
            System.Console.Write("Harga   : ");
            int Harga_PD = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Stok    : ");
            int Stok_PD = Convert.ToInt32(System.Console.ReadLine());


            product call = new product();
            {
                call.ID = Id_PD;
                call.NAME = Nama_PD;
                call.PRICE = Harga_PD;
                call.STOCK = Stok_PD;
            };
            try
            {
                _context.products.Add(call);
                var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        public product GetById(string input)
        {
            var product = _context.products.Find(input);
            if (product == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return product;
        }
        public string Update(string input)
        {
            //System.Console.Write("ID    : ");
            //string id_PD = System.Console.ReadLine();
            System.Console.Write("Nama    : ");
            string Nama_PD = System.Console.ReadLine();
            System.Console.Write("Harga   : ");
            int Harga_PD = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Stok    : ");
            int Stok_PD = Convert.ToInt32(System.Console.ReadLine());
            


            var getProduct = _context.products.Find(input);
            if (getProduct == null)
            {
                System.Console.Write("TIDAK ADA ID PRODUCT : " + input);
                System.Console.ReadLine();
            }
            else
            {
                product pd = GetById(input);
                pd.NAME = Nama_PD;
                pd.PRICE = Harga_PD;
                pd.STOCK = Stok_PD;

                _context.Entry(pd).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
            return input;
        }

        public void delete(string input)
        {
            using (var dlt = new TestADO_OOPEntities())
            {
                var hapus = (from hps in dlt.products
                         where hps.ID == input
                         select hps).FirstOrDefault();
                dlt.products.Remove(hapus);
                dlt.SaveChanges();
            }
        }

        public List<product> Select()
        {
            Console.Clear();
            var getall = _context.products.ToList();
            System.Console.WriteLine("Select All Data of Customers");
            System.Console.WriteLine("\n");
            foreach (product cs in getall)
            {
                System.Console.WriteLine("Id    : " + cs.ID);
                System.Console.WriteLine("Nama  : " + cs.NAME);
                System.Console.WriteLine("Harga : " + cs.PRICE);
                System.Console.WriteLine("Stok  : " + cs.STOCK);
                System.Console.WriteLine("\n");
            }
            System.Console.WriteLine("--------------------------------------------");
            return getall;
        }

    }
}
