using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;

namespace AddressBook
{
    public class ReadORWrite: AddressBook
    {
        //============= Uc13============
        public void txtFileWriter()
        {
            String path = "D:/.Net/C#/AddressBook/AddressBook.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (KeyValuePair<String, PersonInfo> info in addressBook)
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
                foreach (KeyValuePair<String, PersonInfo> info in addressBook)
                {
                    csvWriter.WriteRecords(info.Value.FName + "\t\t" + info.Value.LName + "\t\t" + info.Value.MobileNO + "\t\t" + info.Value.MailID + "\t\t" + info.Value.City + "\t\t" + info.Value.State + "\t\t" + info.Value.ZipCode);
                }
            }
        }

        public void CsvReader()
        {
            string CsvPath = "D:/.Net/C#/AddressBook/CSV.csv";
            using (var reader = new StreamReader(CsvPath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
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

        //========== Uc15 =======

        public void JsonFileWriter()
        {
           JsonSerializer jsonSerializer = new JsonSerializer();
            using(StreamWriter writer= new StreamWriter("D:/.Net/C#/AddressBook/JSON.json"))
            using(JsonWriter jsonWriter = new JsonTextWriter(writer))
            {
                foreach (PersonInfo info in addressBook.Values)
                {
                    jsonSerializer.Serialize(jsonWriter, info);
                }
            }
        }
         public void JsonFileReader()
        {
            String jsonFilePath = "D:/.Net/C#/AddressBook/JSON.json";
             List<PersonInfo> jsonAddressList = JsonConvert.DeserializeObject <List<PersonInfo>>(File.ReadAllText(jsonFilePath));
            foreach (PersonInfo info in jsonAddressList)
            {
                Console.WriteLine("First name : "+info.FName);
                Console.WriteLine("Last name : "+info.LName);
                Console.WriteLine("Mobile No : " + info.MobileNO);
                Console.WriteLine("Email ID : "+info.MailID);
                Console.WriteLine("City : "+info.City);
                Console.WriteLine("State : " + info.State);
                Console.WriteLine("Zip code : "+info.ZipCode);
            }
        }
    }
}
