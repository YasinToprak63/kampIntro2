using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.urunAdi = "Klavye";
            product1.stokSayiyisi = 50;
            product1.urunFiyati = 100;

            Product product2 = new Product();
            product2.urunAdi = "Laptop";
            product2.stokSayiyisi = 20;
            product2.urunFiyati = 10000;

            Product product3 = new Product();
            product3.urunAdi = "Kulaklık";
            product3.stokSayiyisi = 30;
            product3.urunFiyati = 70;

            Product[] products = new Product[] { product1, product2, product3 };

            //do - while döngüsü
            int a = 0;
            do
            {
                Console.WriteLine("Ürün : " + products[a].urunAdi);
                Console.WriteLine("Stok Sayısı : " + products[a].stokSayiyisi);
                Console.WriteLine("Ürün Fiyatı : " + products[a].urunFiyati);
                Console.WriteLine("*********************");
                a++;
            } while (a < products.Length);


            //for döngüsü
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün : " + products[i].urunAdi);
                Console.WriteLine("Stok Sayısı : " + products[i].stokSayiyisi);
                Console.WriteLine("Ürün Fiyatı : " + products[i].urunFiyati);
                Console.WriteLine("*********************");
            }
            //foreach döngüsü
            foreach (var product in products)
            {
                Console.WriteLine("Ürün : " + product.urunAdi);
                Console.WriteLine("Stok Sayısı : " + product.stokSayiyisi);
                Console.WriteLine("Ürün Fiyatı : " + product.urunFiyati);
                Console.WriteLine("*********************");
            }
        }
    }
    class Product
    {
        public string urunAdi { get; set; }
        public int stokSayiyisi { get; set; }
        public double urunFiyati { get; set; }
    }
    }

