using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_1
{
    internal class Program
    {
        Console.Write("enter a name: ");
        String name = Console.Readline();
        Console.writeline("enter a number: ");
        Int number = Convert.ToInt32(Console.Readline());
         Dictionary<String,int>dict = new Dictionary<String,int>;
        

        // A dictionary 
        static void Main(string[] args)
        {
            
            // Simple Contact Manager
            // Use a Simple Dictionary Based DataBase
            // The Data That Are Going to Save : contact, Contact number
            // Functions : Add, Delete, Search, DisplayAll
            // Add the Exeptions (try catch)

            while (true)
            {
                Console.WriteLine("Welcome to the Contact Manager App");
                Console.WriteLine("Enter 1 for Displaying Contacts");
                Console.WriteLine("Enter 2 for Adding Contact");
                Console.WriteLine("Enter 3 for Searching");
                Console.WriteLine("Enter 4 for Delete a contact");
                Console.WriteLine("Enter 0 to Exit");
                Console.WriteLine("............................");

                char choice = Convert.ToChar(Console.ReadLine());
                if (choice == '1')
                {
                    Console.Clear();
                    displayContacts();
                    Console.Write("Press Enter To Back To the Menu");
                    Console.ReadLine();
                }
                else if (choice == '2')
                {
                    Console.Clear();
                    Console.Write("Enter the Name : ");
                    string name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("name Cannot be Empty");
                        return;
                    }
                    Console.Write("Enter the Contact : ");
                    string contact = Console.ReadLine();
                    if (contacts.ContainsKey(name))
                    {
                        Console.WriteLine("This Contact Already Exist!!!");
                        return;
                    }
                    addContact(name, contact);
                    Console.WriteLine("Contact Added SuccessFully");
                    Console.Write("Press Enter To Back To the Menu");
                    Console.ReadLine();
                }
                else if (choice == '3')
                {
                    Console.Clear();
                    Console.Write("Enter a name to search : ");
                    string searchName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(searchName))
                    {
                        searchContact(searchName);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a valid Name");
                        return;
                    }
                    Console.Write("Press Enter To Back To the Menu");
                    Console.ReadLine();
                }
                else if (choice == '4')
                {
                    Console.Clear();
                    Console.Write("Enter a name to Delete");
                    string deleteName = Console.ReadLine();
                    deleteContact(deleteName);

                }

                Console.WriteLine("An Error Has Ocourd!!! Restart the App");

            }
        }
        static void displayContacts()
        {
            // Show All The Contacts : 
        }

        static void addContact(string name, string contact)
        {
            // Add a New Contact
        }

        static void searchContact(string searchName)
        {
            // Search a Contact via its Name
        }

        static void deleteContact(string fullName)
        {
            // Delete a Contact Via its name
        }
    }
}

