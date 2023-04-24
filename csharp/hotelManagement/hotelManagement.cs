using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement
{
    internal class hotelManagement
    {
       public int id { get; set; }
       public string name { get; set; }

    }
    class Employee:hotelManagement
    {
        public string jobTitle { get; set; }
        public int salary { get; set; }
    }
    class Guest:hotelManagement
    {
        public string address { get; set; }
        public int mobileNumber { get; set; }

    }
}
