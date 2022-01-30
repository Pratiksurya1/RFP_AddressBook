using System;
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

        //================ UC8 =================
        public void SearchInCityORState()
        {
            Console.WriteLine("Enter city or state");
            String search = Console.ReadLine();
            foreach(PersonInfo info in addressBook.Values)
            {
                if (info.State.Equals(search) || info.City.Equals(search))
                    Console.WriteLine("NAME : " + info.FName + "         LAST NAME :" + info.LName);
               
            }
        }
    }
}
