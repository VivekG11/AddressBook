﻿using System;

namespace AddressBook
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book ................");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {

                case 1:
                    Details.AddPerson();
                    break;
                default:
                    break;
            }
        }
    }
}
