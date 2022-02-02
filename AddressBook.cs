﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<String, PersonInfo> addressBook = new Dictionary<string, PersonInfo>();

        public void AddBook(String indexName, PersonInfo personObj)
        {
            addressBook.Add(indexName, personObj);
        }

        public void DisplayAddressBook()
        {
            Console.WriteLine("\n ============= Person Information =============\n");
            foreach (KeyValuePair<string, PersonInfo> author in addressBook)
            {
                Console.WriteLine(author.Key);
                PersonInfo info = author.Value;
                Console.WriteLine("NAME : " + info.FName + " LAST NAME : " + info.LName + " MOBILE NO : " + info.MobileNO + "EMAIL ID : " + info.MailID + " CITY : " + info.City + " STATE : " + info.State + "ZIP CODE : " + info.ZipCode);
            }
        }

        public void UpdateInfo()
        {
            Console.WriteLine("Enter index name for update :");
            String check = Console.ReadLine();
            PersonInfo info = addressBook[check];

            Console.WriteLine("\n Enter person First Name :");
            info.FName = Console.ReadLine();

            Console.WriteLine("\n Enter person Last Name :");
            info.LName = Console.ReadLine();

            Console.WriteLine("\n Enter person mobile number :");
            info.MobileNO = long.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter person Email ID :");
            info.MailID = Console.ReadLine();

            Console.WriteLine("\n Enter person City :");
            info.City = Console.ReadLine();

            Console.WriteLine("\n Enter person State :");
            info.State = Console.ReadLine();

            Console.WriteLine("\n Enter person Zip Code :");
            info.ZipCode = long.Parse(Console.ReadLine());
        }

        public void DeleteInfo()
        {
            Console.WriteLine("Enter index name for delete :");
            String check = Console.ReadLine();
            PersonInfo info = addressBook[check];

            addressBook.Remove(check);
        }
        //================= UC7 =================
        public bool CheckDuplicateInfo(PersonInfo personInfo)
        {
            foreach(PersonInfo info in addressBook.Values)
            {
                if (info.FName.Equals(personInfo.FName))
                    return true;    
                else
                    return false;
            }
            return false;
        }

        //================ UC8 and UC9 =================
        public void SearchInCityORState()
        {
            Console.WriteLine("Enter city or state");
            String search = Console.ReadLine();

            Console.WriteLine("This person form "+search);
            foreach(PersonInfo info in addressBook.Values)
            {
                if (info.State.Equals(search) || info.City.Equals(search))
                    Console.WriteLine("NAME : " + info.FName + "         LAST NAME : " + info.LName);   
            }
        }
        //================== UC10 ===============
        public void SearchCountCityORState()
        {
            Console.WriteLine("Enter city or state");
            String search = Console.ReadLine();
            int count = 0;

            Console.WriteLine("This person form " + search);
            foreach (PersonInfo info in addressBook.Values)
            {
                if (info.State.Equals(search) || info.City.Equals(search))
                    count++;
            }
            Console.WriteLine(count +" person in "+search);
        }
        //=============== Uc11 ================
        public override String ToString()
        {
            foreach (KeyValuePair<String, PersonInfo> info in addressBook.OrderBy(key => key.Value.FName))
            {
                Console.WriteLine(info.Key + "\t\t" + info.Value.FName);
            }
            return "";
        }

        // ============= Uc12 ==============
        public void SortedAddressBook()
        {

            Console.WriteLine("Sort by City");
            foreach (KeyValuePair<String, PersonInfo> info in addressBook.OrderBy(key => key.Value.City))
            {
                Console.WriteLine(info.Key + "\t\t" + info.Value.FName);
            }

            Console.WriteLine("Sort by State");
            foreach (KeyValuePair<String, PersonInfo> info in addressBook.OrderBy(key => key.Value.State))
            {
                Console.WriteLine(info.Key + "\t\t" + info.Value.FName);
            }

            Console.WriteLine("Sort by zipcode");
            foreach (KeyValuePair<String, PersonInfo> info in addressBook.OrderBy(key => key.Value.ZipCode))
            {
                Console.WriteLine(info.Key + "\t\t" + info.Value.FName);
            }
        }
    }
}
