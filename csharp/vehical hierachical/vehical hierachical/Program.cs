using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehical_hierachical
{
    class vehical
    {
        string model;
        string type;
        string colour;
        int number;
        public void getvehicaldata(string model, string type, string colour)
        {
            this.model = model;
            this.type = type;
            this.colour = colour;
        }  
        public void displayvehicaldata()
        {
            Console.WriteLine("type :" + type);
            Console.WriteLine("model :" + model);
            Console.WriteLine("colour :" + colour);
        }
    }
    class car : vehical
    {
        string fuel;
        string emmision;

        public void getcardata(string fuel,string emmision)
        {
            this.fuel = fuel;
            this.emmision = emmision;
        }
        public void displaycardata()
        {
            Console.WriteLine("fuel type :" + fuel);
            Console.WriteLine("emmision :" + emmision);
        }
    }
    class bike:vehical
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
