using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook
{
   public class JSONOperations
    {
        public static  string path = @"C:\Users\VIVEK\source\repos\AddressBook\AddressBook\JSON.json";
        public static void Serialize()
        {
         
                if(Details.addressBookDictionary.Count > 0)
                {
                    File.WriteAllText(path, string.Empty);

                    JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter writer = new StreamWriter(path)) 
                using (JsonWriter jsonWriter = new JsonTextWriter(writer)) 
                    {
                        foreach(KeyValuePair<string,List<Details.Person>> keyValue in Details.addressBookDictionary)
                        {
                            Details.people = new List<Details.Person>();
                            foreach(var i in keyValue.Value)
                            {
                                Details.people.Add(i);
                            }

                            serializer.Serialize(jsonWriter, Details.people);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address Book is empty..");
                }
          
        }
    }
}
