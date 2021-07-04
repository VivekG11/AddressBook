using System;

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
                case 2:
                    Details.AddPerson();
                    Details.PrintList();
                    break;
                case 3:
                    Details.RemovePerson();
                    break;
                case 4:
                    Details.EditDetails();
                    break;
                default:
                    break;
            }
        }
    }
}
