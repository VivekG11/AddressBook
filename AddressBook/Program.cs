using System;

namespace AddressBook
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book ................");
            Console.WriteLine("Enter an option :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    Details.GetDetails();
                    break;
                case 2:
                    Details.GetDetails();
                    Details.PrintList();
                    Console.WriteLine("Edit details");
                    Details.EditDetails();
                    Details.PrintList();
                    break;


        }
        }
    }
}
