using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class PersonInfo
    {

        public String FName;
        public String LName;
        public long MobileNO;
        public String MailID;
        public String City;
        public String State;
        public long ZipCode;

        public PersonInfo(String FName, String LName, long MobileNo, String MailID, String City, String State, long ZipCode)
        {
            this.FName = FName;
            this.LName = LName;
            this.MobileNO = MobileNo;
            this.MailID = MailID;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
        }
    }
}
