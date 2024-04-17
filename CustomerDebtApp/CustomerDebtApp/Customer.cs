using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDebtApp
{
    internal class Customer
    {
        private string name;
        private int age;
        private string address;
        private float amountOwed;

        //Constructor
        public Customer(string name, int age,string address, float amountOwed) 
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.amountOwed = amountOwed;
        }

        public Customer()
        {
            this.name = "";
            this.age = 0;
            this.address = "empty";
            this.amountOwed = 0;
        }

        //Properties
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public float amountowed
        {
            get { return amountowed; }
            set { amountowed = value; }
        }

        //concatenation of customer informationm 
        public string GetInformation()
        {
            return Name + " ," + age + " ," + Address + " ," + amountOwed;
        }


    }

}
