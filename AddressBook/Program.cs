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
                case 3:
                    Info.GetDetails();
                    Details.GetDetails();
                    Details.PrintList();
                    Details.RemovePerson();
                    Details.PrintList();
                    break;
                case 4:
                    Console.WriteLine("Adding address books to dictionary.");
                    Details.GetDetails();
                    Details.PrintList();
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;

            }
        }
    }
}
