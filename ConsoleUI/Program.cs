using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            //foreach (var item in productManager.GetAllByCatergoryId(2))
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            foreach (var item in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(item.ProductName);
            }
        }
            
   
    }
}
