using ADO_OOPExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_OOPExample
{
    class CustomerController
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
                    Console.Clear();
                    System.Console.Write("\n");
                    System.Console.Write("- INSERT NEW CUSTOMER -\n\n");
                    Insert();
                    System.Console.Read();
                    break;
                case 2:
                    Console.Clear();
                    System.Console.Write("\n");
                    System.Console.Write("- UPDATE CUSTOMER -");
                    System.Console.Write("\n\n");
                    System.Console.Write("ID      : ");
                    string input = System.Console.ReadLine();
                    Update(input);
                    break;
                case 3:
                    Console.Clear();
                    System.Console.Write("\n");
                    System.Console.Write("- DELETE CUSTOMER -");
                    System.Console.Write("\n\n");
                    System.Console.Write("ID      : ");
                    string input1 = System.Console.ReadLine();
                    delete(input1);
                    System.Console.Read();
                    break;
                case 4:
                    Console.Clear();
                    System.Console.Write("\n");
                    System.Console.Write("- SELECT ALL DATA CUSTOMERS -");
                    System.Console.Write("\n\n");
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
            
            System.Console.Write("Id      : ");
            string Id_CS = System.Console.ReadLine();
            System.Console.Write("Name    : ");
            string Nama_CS = System.Console.ReadLine();
            System.Console.Write("Address : ");
            string Alamat_CS = System.Console.ReadLine();


            customer call = new customer();
            {
                call.ID = Id_CS;
                call.NAME = Nama_CS;
                call.ALAMAT = Alamat_CS;
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
        }

        public customer GetById(string input)
        {
            var customer = _context.customers.Find(input);
            if (customer == null)
            {
                System.Console.WriteLine("The Id is not found. Please, Try Again. ");
            }
            return customer;
        }
        public string Update(string input)
        {
            System.Console.Write("Name    : ");
            string Nama_cs = System.Console.ReadLine();
            System.Console.Write("Address : ");
            string Alamat_cs = System.Console.ReadLine();

            var getCutomer = _context.customers.Find(input);
            if (getCutomer == null)
            {
                System.Console.Write("TIDAK ADA ID CUSTOMER : " + input);
            }
            else
            {
                customer cs = GetById(input);
                cs.NAME = Nama_cs;
                cs.ALAMAT = Alamat_cs;

                _context.Entry(cs).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
            return input;
        }

        public void delete(string input) {
            using (var ctx = new TestADO_OOPEntities())
            {
                var x = (from y in ctx.customers
                         where y.ID == input
                         select y).FirstOrDefault();
                ctx.customers.Remove(x);
                ctx.SaveChanges();
            }
        }

        public List<customer> Select()
        {
            Console.Clear();
            var getall = _context.customers.ToList();
            System.Console.WriteLine("Select All Data of Customers");
            System.Console.WriteLine("\n");
            foreach (customer cs in getall)
            {
                System.Console.WriteLine("ID : " + cs.ID);
                System.Console.WriteLine("NAME : " + cs.NAME);
                System.Console.WriteLine("ADDRESS : " + cs.ALAMAT);
                System.Console.WriteLine("\n");
            }
            System.Console.WriteLine("--------------------------------------------");
            return getall;
        }
    }
}
