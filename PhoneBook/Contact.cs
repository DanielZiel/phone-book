using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace PhoneBook
{
    class Contact
    {
        public Contact(string Name, string Number)

        {
            this.name = Name;
            this.number = Number;

        }

        private string name;
        private string number;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 3)
                {
                    Console.WriteLine("Invalid Name");
                }
                else
                {
                    name = value;
                }


            }
        }

        
        public string Number
        {
            get { return number; }
            set
            {
                if (value.Length > 9)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    number = value;
                }
            }
        }

        

        
    }
}
