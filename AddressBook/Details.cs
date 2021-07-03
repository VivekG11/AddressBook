using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Details
    {
        /*.....................................
         * Add necessary variables in class
         * ................................*/
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int MobileNumber { get; set; }
            public int ZipCode { get; set; }

            
        }
        /*...................................................
         * creating a list to store details of people
         * ...........................................*/
        public static List<Person> people = new List<Person>();


        public static void AddPerson()
        {
            Person person = new Person();

            Console.WriteLine("Enter First Name : ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last NAme : ");
            person.LastName = (Console.ReadLine());

            Console.WriteLine("Enter Address");
            person.Address = Console.ReadLine();

            Console.WriteLine("Enter City");
            person.City = Console.ReadLine();

            Console.WriteLine("Enter State");
            person.State = Console.ReadLine();

            Console.WriteLine("Enter Mobile NUmber :");
            person.MobileNumber =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Zip COde : ");
            person.ZipCode = Convert.ToInt32(Console.ReadLine());

            /*.................................................
             * adding each person into the list after filling the details 
             * ........................................................*/

            people.Add(person);

        }
        
        public static void Printdetails(Person person)
        {
            Console.WriteLine("First Name :"+person.FirstName);
            Console.WriteLine("Last Name : "+person.LastName);

            Console.WriteLine("Address : "+person.Address);
            Console.WriteLine("City :"+person.City);
            Console.WriteLine("State :"+person.State);
            Console.WriteLine("Mobile Number :"+person.MobileNumber);
            Console.WriteLine("Zip Code : "+person.ZipCode);

        }

        public static void PrintList()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Address Book is Empty");
                return;
            }
           
            foreach(var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
