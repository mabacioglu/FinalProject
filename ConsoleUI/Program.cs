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
            // ProductTest();
            // CategoryTest();

            ProductManager productManager = new ProductManager(new EFProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductID+" - "+ item.ProductName+ " - "+item.CategoryName+ " - "+item.UnitsInStock);
            }


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryId + "  " + item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductId +"   "+item.ProductName + "    "+item.UnitPrice );
            }
            Console.WriteLine("-----------------------");
            foreach (var item in productManager.GetAllByCatergoryId(2))
            {
                Console.WriteLine(item.ProductId + "   " + item.ProductName + "    " + item.UnitPrice);
            }
            Console.WriteLine("-----------------------");
            foreach (var item in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(item.ProductId + "   " + item.ProductName + "    " + item.UnitPrice);
            }
        }

    }
}
