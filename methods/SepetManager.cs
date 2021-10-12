using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name);
        }

        public void Add2(string Name, string Explanation, double Price, int Stock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + Name);
        }
    }
}
