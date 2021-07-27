﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Details
    {

        public static Dictionary<string, List<Person>> addressBookDictionary = new Dictionary<string, List<Person>>();
        
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
        public static List<Person> people; 

        

        public static void GetDetails()
        {
     
            people = new List<Person>();
            string bookName;
            Console.WriteLine("Enter num of books :");
            int books = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= books; j++)
            {

                Console.WriteLine("Enter the name of the addressbook :");
                bookName = Console.ReadLine();

                if (addressBookDictionary.ContainsKey(bookName))
                {
                    Console.WriteLine("address book with entered name already exist.");
                }
                else
                {
                    Console.WriteLine("Enter number of contacts to be inserted :");
                    int num = Convert.ToInt32(Console.ReadLine());
                    //using for loop to iterate over Getting details of contacts

                    for (int i = 1; i <= num; i++)
                    {

                        Person person = new Person();
                        Console.WriteLine("Enter details of contact :");
                        //validating duplicate entries using first name
                        while (true)
                        {

                            Console.WriteLine("Enter First Name : ");
                            string firstName = Console.ReadLine();
                            if (people.Count <= num)
                            {
                                //comparing input with existing contacts
                                var v = people.Find(x => x.firstName.Equals(firstName));
                                if (v != null)
                                {
                                    Console.WriteLine("Name already exists");
                                }
                                else
                                {
                                    person.firstName = firstName;
                                    break;
                                }
                            }
                            else
                            {
                                person.firstName = firstName;
                                break;
                            }
                        }

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
                    addressBookDictionary.Add(bookName, people);
                    
                }
            }
            
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
        public static void RemovePerson()
        {
            Console.WriteLine("Enter the name of the person you want to remove : ");
            string removePerson = Console.ReadLine();

            foreach (var person in people)
            {
                if (removePerson.ToLower() == person.firstName.ToLower())
                {
                    people.Remove(person);
                    Console.WriteLine("Deleted Successfully ");

                    break;
                }
                else
                {
                    Console.WriteLine("Name does not exist.");
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
            Console.WriteLine("Total num of books in dictionary are :"+addressBookDictionary.Count);
        }


    }
}
