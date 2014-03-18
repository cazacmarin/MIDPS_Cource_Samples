using System;

public class Utils
{
	public Utils()
	{
	}
    //adresa fizica/juridica
    class Address
    {
        public string City { get; set; }
        public string street { get; set; }
        public bool type { get; set; }
        public override string ToString()
        {

            return " City: " + City + " street: " + street + " type: " + (type ? "home" : "work");
        }
    }
    //e-mail
    class EMail
    {
        public string eMailAddress { get; set; }
        public bool type { get; set; }//if false then Work, else - HOME
        public override string ToString()
        {
            return " eMailAddress: " + eMailAddress + " type: " + (type ? "home" : "work");
        }
    }
    class Agenda
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNumber { get; set; }
        public List<Address> addressList { get; set; }
        public List<EMail> emailList { get; set; }

        public override string ToString()
        {
            string str = "name:" + name + " surname:" + surname + " phoneNumber:" + phoneNumber + "\n";
            if (addressList != null)
                foreach (var item in addressList)
                {
                    str += item.ToString() + "\n";
                }
            if (emailList != null)
                foreach (var item in emailList)
                {
                    str += item.ToString() + "\n";
                }
            return str;
        }
    }

}
