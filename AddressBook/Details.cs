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
            public int mobileNumber { get; set; }
            public int zipCode { get; set; }

            
        }
        /*...................................................
         * creating a list to store details of people
         * ...........................................*/
        public static List<Person> people = new List<Person>();


        public static void AddPerson()
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
            person.mobileNumber =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Zip COde : ");
            person.zipCode = Convert.ToInt32(Console.ReadLine());

            /*.................................................
             * adding each person into the list after filling the details 
             * ........................................................*/

            people.Add(person);

        }
        
        public static void Printdetails(Person person)
        {
            Console.WriteLine("First Name :"+person.firstName);
            Console.WriteLine("Last Name : "+person.lastName);

            Console.WriteLine("Address : "+person.address);
            Console.WriteLine("City :"+person.city);
            Console.WriteLine("State :"+person.state);
            Console.WriteLine("Mobile Number :"+person.mobileNumber);
            Console.WriteLine("Zip Code : "+person.zipCode);

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
                Printdetails(person);
            }
        }

        public static void RemovePerson()
        {
            Console.WriteLine("Enter the name of the person you want to remove : ");
            string removePerson = Console.ReadLine();
            int flag = 0;
            foreach(var person in people)
            {
                if (removePerson.ToLower() == person.firstName.ToLower())
                {
                    people.Remove(person);
                    Console.WriteLine("Deleted Successfully ");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Enter valid name ");
            }

        }
        public static void EditDetails()
        {
            int temp = 0;
            if(people.Count > 0)
            {
                Console.WriteLine("Enter the name of person to edit : ");
                string editName = Console.ReadLine();

                foreach(var person in people)
                {
                    if(editName.ToLower() == person.firstName.ToLower())
                    {
                        while(true)
                        {
                            temp = 0;
                            Console.WriteLine("1.First Name\n2.Second Name\n3.Adress\n4.City\n5.State\n6.Mobile Number\n7.Zipcode\n8.Exit");
                            Console.WriteLine("Select an Option :");
                            switch(Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First Name :");
                                    person.firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter new Last Name : ");
                                    person.lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter new address :");
                                    person.address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter new City :");
                                    person.city = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter new State :");
                                    person.state = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter new Mobile Number :");
                                    person.mobileNumber =Convert.ToInt32( Console.ReadLine());
                                    break;
                                case 7:
                                    Console.WriteLine("Enter new ZipCode :");
                                    person.zipCode =Convert.ToInt32( Console.ReadLine());
                                    break;
                                case 8:
                                    Console.WriteLine("Exit");
                                    temp = 1;
                                    break;

                            }
                            if(temp == 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid name , It is not in the list.");
                    }
                }

            }
            else
            {
                Console.WriteLine("Details list is empty ");
            }
        }
    }
}
