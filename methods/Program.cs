using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            foreach (Product product  in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil armut", 12, 15);
            sepetManager.Add2("Elma", "Yeşil elma", 12, 5);
            sepetManager.Add2("Karpuz", "Diyarbakır karpuz", 12, 6);

        }
    }
}


//Do not repeat yourself - Kendini tekrar etme 
