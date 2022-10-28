using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 5000;
            product1.UnitsInStock = 3;
            product1.Description = "Mini Sabit Masa";
            product1.Image = "https://st1.myideasoft.com/idea/en/81/myassets/products/859/empoli-mini-sabit-masa-120cm.jpg?revision=1628760497";

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 40,
                UnitsInStock = 5,
                Description = "Tablet Ekran Kalemi",
                Image = "https://img-morhipo.mncdn.com/mnresize/1200/1645/productimages/ii/8686731549396/[img][5][1].jpg?0337"

            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
        }
    }
}
