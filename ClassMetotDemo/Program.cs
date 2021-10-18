using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ahmet";
            customer1.LastName = "Toprak";
            customer1.YearOfBirth = 1995;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Yasin";
            customer2.LastName = "Kaya";
            customer2.YearOfBirth = 2000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Nihat";
            customer3.LastName = "Kahveci";
            customer3.YearOfBirth = 1891;



            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);
            customerManager.Update(customer1);



        }
    }
}
