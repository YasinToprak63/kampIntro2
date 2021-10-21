using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //defualt constructor
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Yasin",
                LastName = "Toprak",
                City = "Adana"

            };
            Customer customer2 = new Customer(2,"Ahmet","Tatmaz", "Urfa");

            Console.WriteLine(customer.City);
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //defualt constructor
        public Customer(int id, string firstName, string lastname, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }   
}


