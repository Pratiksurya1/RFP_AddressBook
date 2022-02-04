using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace AddressBook
{
    public class ReadORWrite
    {
        //============= Uc13============
        AddressBook obj =new AddressBook();
        public void txtFileWriter()
        {
            String path = "D:/.Net/C#/AddressBook/AddressBook.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (KeyValuePair<String, PersonInfo> info in obj.addressBook)
                {
                    sw.WriteLine(info.Value.FName + "\t\t" + info.Value.LName + "\t\t" + info.Value.MobileNO + "\t\t" + info.Value.MailID + "\t\t" + info.Value.City + "\t\t" + info.Value.State + "\t\t" + info.Value.ZipCode);
                }
            }
        }

        //========== Uc14 ===========
        public void CsvWriter()
        {
            String CsvPath = "D:/.Net/C#/AddressBook/CSV.csv";
            using (var writer = new StreamWriter(CsvPath))
            using (var csvWriter = new CsvWriter(writer,CultureInfo.InvariantCulture))
            {
                foreach (KeyValuePair<String, PersonInfo> info in obj.addressBook)
                {
                    csvWriter.WriteRecords(info.Value.FName + "\t\t" + info.Value.LName + "\t\t" + info.Value.MobileNO + "\t\t" + info.Value.MailID + "\t\t" + info.Value.City + "\t\t" + info.Value.State + "\t\t" + info.Value.ZipCode);
                }
            }
        }
        
        public void CsvReader()
        {
            string CsvPath = "D:/.Net/C#/AddressBook/CSV.csv";
            using(var reader = new StreamReader(CsvPath))
            using(var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecord<PersonInfo>().ToList();

                foreach (PersonInfo personInfo in records)
                {
                    Console.WriteLine(" First name :" + personInfo.FName);
                    Console.WriteLine(" Last name :" + personInfo.LName);
                    Console.WriteLine(" Mobile No :" + personInfo.MobileNO);
                    Console.WriteLine(" Email ID :" + personInfo.MailID);
                    Console.WriteLine(" City :" + personInfo.City);
                    Console.WriteLine(" State :" + personInfo.State);
                    Console.WriteLine("Zip Code :" + personInfo.ZipCode);
                }
            }
        }
        
    }
}
