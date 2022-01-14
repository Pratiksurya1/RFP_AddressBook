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
            Console.WriteLine("You want to update info .... type yes or no");
            if (Console.ReadLine().Equals("yes"))
            {
                Console.WriteLine("Enter Index no ");
                int inNo=Int32.Parse(Console.ReadLine());
                personInfo.UpdateInfo(inNo);
                personInfo.DisplayPersonInfo();
            }
        }
    }
}