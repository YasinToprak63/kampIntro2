using System;

namespace trys
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir sayının asal olup olmadığına bakan kod
            int a = 4;
            var sonuc = a % 1 == a || a % a == a ? a + " asal bir sayıdır " : a + " asal bir sayı değildir";
            Console.WriteLine(sonuc);

            if (a % 2 == 1)
            {
                Console.WriteLine(a + " tek bir sayıdır ");
            }
            else
            {
                Console.WriteLine(a + " çift bir sayıdır");
            }


        }
      
    }
}
