using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadORWrite personAdd = new ReadORWrite();
           
            while (true)
            {
                Console.WriteLine("\n Enter Index Name :");
                String IndexName = Console.ReadLine();

                Console.WriteLine("\n Enter person First Name :");
                String firstName = Console.ReadLine();

                Console.WriteLine("\n Enter person Last Name :");
                String lastName = Console.ReadLine();

                Console.WriteLine("\n Enter person mobile number :");
                long mobailNo = long.Parse(Console.ReadLine());

                Console.WriteLine("\n Enter person Email ID :");
                String mail = Console.ReadLine();

                Console.WriteLine("\n Enter person City :");
                String city = Console.ReadLine();

                Console.WriteLine("\n Enter person State :");
                String state = Console.ReadLine();

                Console.WriteLine("\n Enter person Zip Code :");
                long zipCode = long.Parse(Console.ReadLine());

                PersonInfo personInfo = new PersonInfo(firstName, lastName, mobailNo, mail, city, state, zipCode);

                if (personAdd.CheckDuplicateInfo(personInfo) != true)
                {
                    personAdd.AddBook(IndexName, personInfo);
                    Console.WriteLine("Added successfully");
                }
                else
                    Console.WriteLine("This person already present in the dictionary");

                Console.WriteLine("\n you want add anathar person yes or no :");
                String check = Console.ReadLine();
                if (check.Equals("no"))
                    break;
            }

            personAdd.DisplayAddressBook();
            Console.WriteLine("\n You want to update info ...!! type \n update \n delete info \n search info \n search count");
            String userDis = Console.ReadLine();
            if (userDis.Equals("update"))
            {
                personAdd.UpdateInfo();
                personAdd.DisplayAddressBook();
            }
            else if (userDis.Equals("delete"))
            {
                personAdd.DeleteInfo();
                personAdd.DisplayAddressBook();
            }
            else if (userDis.Equals("search"))             
            {
                personAdd.SearchInCityORState();
            }
            else if (userDis.Equals("search count"))    
                personAdd.SearchCountCityORState();
            else
                Console.WriteLine("Value not found");

            personAdd.ToString();  
      
            personAdd.txtFileWriter();

            personAdd.JsonFileWriter();
        }
    }
}