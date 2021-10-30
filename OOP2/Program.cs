using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yasin Toprak
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Yasin";
            customer1.LastName = "Toprak";
            customer1.TcNo = "123456789";

            //Kodflma.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "12345678910";


        }
    }
}
