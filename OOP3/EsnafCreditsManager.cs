using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafCreditsManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı");
        }
    }
}
