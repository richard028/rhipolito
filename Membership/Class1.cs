using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    class membership
    {
        //PRIVATE GETTERS AND SETTERS//
        private string name;
        private string address;
        private string contact;
        private string age;
        private string sex;

        //CONSTRUCTOR CLASS//
        public membership(string name, string address, string contact, string age, string sex)
        {
            Name = name;
            Address = address;
            Contact = contact;
            Age = age;
            Sex = sex;
        }
        //GETTERS AND SETTERS
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
    }
}
