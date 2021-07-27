using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Details
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

        public static void EditDetails()
        {
            if(people.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("Enter first name :");
                string name = Console.ReadLine();
                foreach(var person in people)
                {
                    if(person.firstName.ToLower() == name.ToLower())
                    {
                        Console.WriteLine("Enter the option to change details :");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch(choice)
                        {
                            case 1:
                                Console.WriteLine("Enter New First Name :");
                                person.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new last name :");
                                person.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter new Address :");
                                person.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter new City Name :");
                                person.city = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter new state name :");
                                person.state = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter new Mobile nUmber :");
                                person.mobileNumber = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter new Zipcode");
                                person.zipCode = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Enter valid Option");
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Name Does not exist in the list.");
                    }
                }
            }
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
