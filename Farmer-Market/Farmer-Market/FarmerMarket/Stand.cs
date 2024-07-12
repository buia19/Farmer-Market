using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Market
{
    public class Stand
    {
        public string LocationId { get; set; }
        public Farmer Farmer { get; set; }
        public Dictionary<string, Produce> ProduceDict { get; set; }

        public Stand(Farmer farmer)
        {
            this.LocationId = Guid.NewGuid().ToString();
            this.Farmer = farmer;
            this.Farmer.LocationId = this.LocationId;
            this.ProduceDict = new Dictionary<string, Produce>();
        }

        public Stand()
        {
            this.LocationId = Guid.NewGuid().ToString();
            this.ProduceDict = new Dictionary<string, Produce>();
        }

        public Dictionary<string, Produce> GetAllProduces()
        {
            return this.ProduceDict;
        }

        public void AddProduce(Produce produce)
        {
            if (!this.ProduceDict.ContainsKey(produce.Name))
            {
                this.ProduceDict.Add(produce.Name, produce);
            }
            else
            {
                this.ProduceDict[produce.Name].Quantity += produce.Quantity;
            }
        }

        public void BuyProduce(string produceName, int quantity)
        {
            if (!this.ProduceDict.ContainsKey(produceName))
            {
                Console.WriteLine("This stand does NOT have " + produceName);
                return;
            }
            if (this.ProduceDict[produceName].Quantity < quantity)
            {
                Console.WriteLine("This stand does NOT have enough " + produceName);
                Console.WriteLine("In stock: " + this.ProduceDict[produceName].Quantity + ", entered amount: " + quantity);
                return;
            }
            this.ProduceDict[produceName].Quantity -= quantity;
        }

        public void printStand()
        {
            Console.WriteLine("locationId: " + this.LocationId);
            this.Farmer.printFarmer();
        }

        public void printProduces()
        {
            Console.WriteLine("produces: ");
            if (this.ProduceDict.Count == 0)
            {
                Console.WriteLine("{}");
                return;
            }
            foreach (var kvp in this.ProduceDict)
            {
                Console.Write(kvp.Key + ": ");
                kvp.Value.PrintProduce();
                Console.WriteLine();
            }
        }
    }
}
