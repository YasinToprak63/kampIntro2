using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temel kurs" ,
                "Java","Python","C#"};

            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            //Console.WriteLine("for bitti");

            //foreach (string kurs in kurslar)
            //{
            //    Console.WriteLine(kurs);
            //}
          
            //Console.WriteLine("Sayfa Sonu - footer");

            int a = 0;
            do
            {
                Console.WriteLine(kurslar);
                a++;
            } while (a < kurslar.Length);
            
        }
    }
}
