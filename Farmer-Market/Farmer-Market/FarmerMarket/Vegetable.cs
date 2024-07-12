using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Market
{
    public class Vegetable : Produce
    {
        public Vegetable(string name, int quantity) : base(name, ProduceType.VEGETABLE, quantity)
        {
        }
    }
}
