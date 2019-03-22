using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    class Program
    {
        static void Main()
        {
            var customer1 = new Customer()
            {
                PhoneNumber = 0500,
                Name = "SomeDude1",
                LastName = "SomeDudeLastName1"
            };
            var customer2 = new Customer()
            {
                PhoneNumber = 0501,
                Name = "SomeDude2",
                LastName = "SomeDudeLastName2"
            };
            var customer3 = new Customer()
            {
                PhoneNumber = 0502,
                Name = "SomeDude3",
                LastName = "SomeDudeLastName3"
            };
            var customer4 = new Customer()
            {
                PhoneNumber = 0503,
                Name = "SomeDude3",
                LastName = "SomeDudeLastName3"
            };
            var customer5 = new Customer()
            {
                PhoneNumber = 0504,
                Name = "SomeDude3",
                LastName = "SomeDudeLastName3"
            };

            Dictionary<string, Customer> Customers = new Dictionary<string, Customer>();
            Customers.Add(customer1.Name, customer1);
            Customers.Add(customer2.Name, customer2);
            Customers.Add(customer3.Name, customer3);

            //Console.WriteLine("Please enter a name.");
            //string name = "";
            //bool containsName = Customers.ContainsKey(name);


            //var firstCustomer = Customers[name];
            //Console.WriteLine($"{firstCustomer.Name} {firstCustomer.LastName} : {firstCustomer.PhoneNumber} ");

            string name = "";
            do
                {
                Console.WriteLine("Please enter a name.");
                name =Console.ReadLine();
                //var firstCustomer = Customers[name];
                bool containsName = Customers.ContainsKey(name);
                if (containsName)
                    {
                    var firstCustomer = Customers[name];
                    Console.WriteLine($" Name :{firstCustomer.Name}, last name:{firstCustomer.LastName}, phone number: {firstCustomer.PhoneNumber} ");
                    
                }
                }
                while
                (
                    !Customers.ContainsKey(name)
                );

            
            //var firstCustomer= Customers["SomeDude3"];
            //Console.WriteLine($"{firstCustomer.PhoneNumber}, {firstCustomer.Name}, {firstCustomer.LastName}");
        }
        
    }
    public class Customer
    {
        public int PhoneNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        
    }
}
