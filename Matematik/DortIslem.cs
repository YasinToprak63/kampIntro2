using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
      class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Sonuç : " + (sayi1 + sayi2));
        }

        public void Cıkar(int sayi1, int sayi2)
        {
            Console.WriteLine("Sonuç : " + (sayi1 - sayi2));
        }

        public void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine("Sonuç : " + (sayi1 * sayi2));
        }

        public void Bol(int sayi1, int sayi2)
        {
            Console.WriteLine("Sonuç : " + (sayi1 / sayi2));
        }
    }
}
