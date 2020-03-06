using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial1
{
    public class Person
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
    }
}
