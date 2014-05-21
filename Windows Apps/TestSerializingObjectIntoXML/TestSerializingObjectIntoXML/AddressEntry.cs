using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSerializingObjectIntoXML
{
    //[Serializable]
    public class AddressEntry
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address1;
        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        
        private string _address2;
        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        
        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        
        private string _zip;
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public AddressEntry() { }
    }
}
