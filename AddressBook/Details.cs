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
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string mobileNumber { get; set; }
            public string zipCode { get; set; }

            
        }
        /*...................................................
         * creating a list to store details of people
         * ...........................................*/
       public static List<Person> people = new List<Person>();


       public static void GetDetails()
            {
                Person person = new Person();

                Console.WriteLine("Enter First Name : ");
                person.firstName = Console.ReadLine();

                Console.WriteLine("Enter Last NAme : ");
                person.lastName = (Console.ReadLine());

                Console.WriteLine("Enter Address");
                person.address = Console.ReadLine();

                Console.WriteLine("Enter City");
                person.city = Console.ReadLine();

                Console.WriteLine("Enter State");
                person.state = Console.ReadLine();

                Console.WriteLine("Enter Mobile NUmber :");
                person.mobileNumber = Console.ReadLine();

                Console.WriteLine("Enter Zip COde : ");
                person.zipCode = Console.ReadLine();

                /*.................................................
                 * adding each person into the list after filling the details 
                 * ........................................................*/

                people.Add(person);
              
            }
        public static void Printdetails(Person person)
        {
            Console.WriteLine("First Name :" + person.firstName);
            Console.WriteLine("Last Name : " + person.lastName);

            Console.WriteLine("Address : " + person.address);
            Console.WriteLine("City :" + person.city);
            Console.WriteLine("State :" + person.state);
            Console.WriteLine("Mobile Number :" + person.mobileNumber);
            Console.WriteLine("Zip Code : " + person.zipCode);

        }
        public static void PrintList()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Address Book is Empty");
                return;
            }

            foreach (var person in people)
            {
                Printdetails(person);
            }
        }

    }
        
 
       
    }

