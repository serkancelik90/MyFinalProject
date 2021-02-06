using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID 
        //Open Closed Principle (Yaptığın yazılıma yeni bir özellik ekliyorsan, mevcuttaki hiçbir koduna dokunamazsın.)
        static void Main(string[] args)
        {
            ProductTest();

            Console.WriteLine("-------------------");

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName +" " + product.UnitPrice);
            }
        }
    }
}
