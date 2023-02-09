﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABdemo
{
    internal class Person
    {
        public static List<Contacts> person = new List<Contacts>();
        Dictionary<string, List<Contacts>> book = new Dictionary<string, List<Contacts>>();
        public static void CreateContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter EmailID ");
            contacts.Email = Console.ReadLine();

            Console.WriteLine("Enter Address");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter City");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode ");
            contacts.Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());


            person.Add(contacts);
            Console.WriteLine("Contact added to your Address book");
        }
        public static void Display()
        {
            foreach (var data in person)
            {
                Console.WriteLine();
                Console.WriteLine("1.FirstName: " + data.FirstName + "2.LastName: " + data.LastName + "3.Address: " + data.Address + "4.City: " + data.City + "5.State: " + data.State + "6.Zipcode: " + data.Zipcode + "7.PhoneNumber: " + data.PhoneNumber);
            }
        }
        public static void editContact()
        {
            Console.WriteLine("Enter the First Name: ");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string fName = Console.ReadLine();
                                data.FirstName = fName;
                                break;

                            case 2:
                                string lName = Console.ReadLine();
                                data.LastName = lName;
                                break;

                            case 3:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;

                            case 4:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;

                            case 5:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;

                            case 6:
                                int zipcode = Convert.ToInt32(Console.ReadLine());
                                data.Zipcode = zipcode;
                                break;

                            case 7:
                                int phoneNumber = Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = phoneNumber;
                                break;

                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name doesnot match");
                    }
                }
            }
        }
        public static void DeleteContact(string name)
        {
            Contacts contacts = new Contacts();
            foreach (var data in person)
            {
                if (data.FirstName == name)
                {
                    contacts = data;
                }
            }
            person.Remove(contacts);
        }
        public static void AddMultipleContacts()
        {
            Console.WriteLine("Enter the Number of Records you want to Insert");
            int number = (int)Convert.ToInt64(Console.ReadLine());
            while (number > 0)
            {
                CreateContacts();
                number--;
            }
        }
        public void NewUser()
        {
            Console.WriteLine("Enter the Bookname: ");
            string Bookname = Console.ReadLine();
            Console.WriteLine("Enter The Number of Contacts To Add");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {

                number--;
                CreateContacts();
            }
            book.Add(Bookname, person.ToList());
        }
        public void DisplayList()
        {
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (Contacts data in book[pair])
                {
                    Console.WriteLine("****First Name***: " + data.FirstName);
                    Console.WriteLine("Last Name: " + data.LastName);
                    Console.WriteLine("Address: " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State: " + data.State);
                    Console.WriteLine("Zip : " + data.Zipcode);
                    Console.WriteLine("Phone Number: " + data.PhoneNumber);
                    Console.WriteLine("EmailID: " + data.Email);
                }
            }
        }
    }
}
