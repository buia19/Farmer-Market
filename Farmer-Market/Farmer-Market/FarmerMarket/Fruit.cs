using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Market
{
    public class Fruit : Produce
    {
        public Fruit(string name, int quantity) : base(name, ProduceType.FRUIT, quantity)
        {
        }
    }
}
