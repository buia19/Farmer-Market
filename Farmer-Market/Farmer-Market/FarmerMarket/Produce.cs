using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Market
{
    public class Produce
    {
        public string Name { get; set; }
        public ProduceType Type { get; set; }
        public int Quantity { get; set; }

        public Produce(string name, ProduceType type, int quantity)
        {
            this.Name = name;
            this.Type = type;
            this.Quantity = quantity;
        }

        public void PrintProduce()
        {
            Console.Write("{ quantity: " + this.Quantity + ", type: " + this.Type + " }");
        }
    }
}
