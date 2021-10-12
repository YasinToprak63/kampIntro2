using System;

namespace kampIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            //switch case kullanımı
            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            int sayi1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            int sayi2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen işlem türünü giriniz");
            Console.WriteLine("toplama=1, çıkarma=2, çarpma=3, bölme=4");
            int islem = Int32.Parse(Console.ReadLine());

            switch (islem)
            {
                case 1: Console.WriteLine(sayi1 + sayi2); break;
                case 2: Console.WriteLine(sayi1 - sayi2); break;
                case 3: Console.WriteLine(sayi1 * sayi2); break;
                case 4: Console.WriteLine(sayi1 / sayi2); break;

                default: Console.WriteLine("Hata böyle bir işlem bulunamadı"); break;
            }

            //bir sayının asal olup olmadığına bakan kod (Ternary Operator)
            int a = 4;
            var sonuc = a % 1 == a || a % a == a ? a + " asal bir sayıdır " : a + " asal bir sayı değildir";
            Console.WriteLine(sonuc);
        }
    }
  
}
