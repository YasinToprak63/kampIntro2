using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(30,45);
            dortIslem.Cıkar(20,10);
            dortIslem.Carp(20, 10);
            dortIslem.Bol(20, 10);
        }
    }
}
