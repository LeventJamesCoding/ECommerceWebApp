using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
//DTO: Data Transformation Object
namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();    
            //CategoryTest();
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(item.ProductName + " " + item.ProductId + " " + item.CategoryName + " " + item.UnitsInStock);
            }
        }
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAllByUnitPrice(30, 100).Data)
            {
                Console.WriteLine("ProductName: " + item.ProductName +
                    "; UnitPrice: " + item.UnitPrice);
            }
        }
    }
}