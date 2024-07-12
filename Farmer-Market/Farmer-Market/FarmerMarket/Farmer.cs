using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Market
{
    public class Farmer
    {
        public string Name { get; set; }
        public string LocationId { get; set; }
        public Farmer(string name)
        {
            this.Name = name;
        }

        public void printFarmer()
        {
            Console.WriteLine("farmer_info: ");
            Console.WriteLine("\tfarmer_name: " + this.Name);
            Console.WriteLine("\tfarmer_locationId: " + this.LocationId);
        }
    }
}
