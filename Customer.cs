using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class Customer
    {
        private string uid;
        private string name;
        private string address;

        public Customer ( string a, string b, string c)
        {
            uid = a;
            name = b;
            address = c;
        }

        public string Uid
        { get; set; }

        public string Name
        { get; set; }

        public string Address
        { get; set; }

        public void ViewPolicies(string uid)
        {
            Console.WriteLine("");
        }

    }


}
