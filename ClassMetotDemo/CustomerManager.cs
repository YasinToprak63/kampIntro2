using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName +" : " + "Customer Listed!");
            
        }
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName + " : " + "Customer Added!");
     
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName + " : " + " Customer Deleted!");
            
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName + " : " + " Customer Updated!");

        }
    }
}
