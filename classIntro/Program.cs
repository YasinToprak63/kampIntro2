using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //classlar birden fazla veriyi tutabilmek için kullanılır.

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Kerem Savaş";
            kurs2.izlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.egitmen = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.egitmen);
            }
            //for (int i = 0; i < kurs.Length; i++)
            //{
            //Console.WriteLine(kurs[i].kursAdi + " : " + kurs[i].egitmen);
            //}
           
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
