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
            PersonInfo personInfo= new PersonInfo();
            personInfo.SetPersonInfo();

            personInfo.DisplayPersonInfo();
            Console.WriteLine("\n You want to update info ...!! type update or delete info");
            String userDis=Console.ReadLine();
            if (userDis.Equals("update"))
            {
                Console.WriteLine("Enter Index no ");
                int inNo=Int32.Parse(Console.ReadLine());
                personInfo.UpdateInfo(inNo);
                personInfo.DisplayPersonInfo();
            }
            else if (userDis.Equals("delete"))
            {
                Console.WriteLine("Enter Index no ");
                personInfo.DeleteInfo(Int32.Parse(Console.ReadLine()));
                personInfo.DisplayPersonInfo();
            }
        }
    }
}