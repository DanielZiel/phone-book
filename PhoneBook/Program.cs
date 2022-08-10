using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace PhoneBook

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search contacts");
            Console.WriteLine("To exit, press X");


            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();
            while(true)
            {
                switch (userInput)
                {

                    case "1":

                        Console.WriteLine("Insert Number");
                        var number = Console.ReadLine();

                        Console.WriteLine("Insert Name");
                        var name = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);


                        break;
                    case "2":
                        Console.WriteLine("Insert Number");
                        var numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);

                        break;

                    case "3":
                        phoneBook.DisplayAllContact();
                        break;

                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display contact by number");
                Console.WriteLine("3. Display all contacts");
                Console.WriteLine("4. Search contacts");
                Console.WriteLine("To exit, press X");
                userInput = Console.ReadLine();
            }
            



        }
    }
}