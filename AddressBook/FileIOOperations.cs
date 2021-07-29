using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook
{
    public class FileIOOperations
    {
        static string filepath = @"C:\Users\VIVEK\source\repos\AddressBook\AddressBook\Books.txt";
        Details details = new Details();
        public static void ReadBook()
        {
            string detailsText;
            if (File.Exists(filepath))
            {
                detailsText = File.ReadAllText(filepath);

                if (detailsText.Length != 0)
                {
                    Console.WriteLine("\n"+detailsText);
                }
                else
                {
                    Console.WriteLine("file does not exist..");
                }
            }
        }

        public static void WriteDetails()
        {
            string text;
            try
            {
                if (Details.addressBookDictionary.Count > 0)
                {

                    File.WriteAllText(filepath, string.Empty);

                    foreach (KeyValuePair<string, List<Details.Person>> dict in Details.addressBookDictionary)
                    {
                         File.AppendAllText(filepath, $"{dict.Key}\n");
                        foreach (var book in dict.Value)
                        {
                            text = $"{"firstname :"+book.firstName},{book.lastName},{book.address},{book.city},{book.state},{book.mobileNumber},{book.zipCode}\n";

                            File.AppendAllText(filepath, text);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address Book is empty");
                }
            }
            catch(Exception)
            {

            }
            ReadBook();
        }
    }
}
