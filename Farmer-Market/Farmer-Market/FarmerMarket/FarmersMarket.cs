using System;
using System.Collections.Generic;
namespace Farmer_Market
{
    public class FarmersMarket
    {
        public List<Stand> Stands { get; set; }
        public Dictionary<string, List<Farmer>> FarmerDict { get; set; }

        public FarmersMarket(List<Stand> stands)
        {
            this.Stands = stands;
            this.FarmerDict = new Dictionary<string, List<Farmer>>();
        }

        public FarmersMarket()
        {
            this.Stands = new List<Stand>();
            this.FarmerDict = new Dictionary<string, List<Farmer>>();
        }

        public List<Stand> GetAllStands()
        {
            return this.Stands;
        }

        public void PrintAllStands(List<Stand> stands)
        {
            if (stands.Count == 0)
            {
                Console.WriteLine("[]");
                return;
            }
            foreach (var stand in stands)
            {
                stand.printStand();
                stand.printProduces();
            }
        }

        public void AddStand(Stand stand)
        {
            this.Stands.Add(stand);
        }


        public List<Farmer> SearchProduce(string produceName)
        {
            if (!this.FarmerDict.ContainsKey(produceName))
            {
                this.FarmerDict.Add(produceName, new List<Farmer>());
            }
            return this.FarmerDict[produceName];
        }

        public void AddProduceToStand(string standLocationId, Produce produce)
        {
            Stand foundStand = this.FindStandByLocationId(standLocationId);
            foundStand.AddProduce(produce);
            Farmer farmer = this.FindFarmerByLocationId(standLocationId);
            this.UpdateFarmerDict(produce, farmer);
        }

        private void UpdateFarmerDict(Produce produce, Farmer farmer)
        {
            if (!this.FarmerDict.ContainsKey(produce.Name))
            {
                this.FarmerDict.Add(produce.Name, new List<Farmer>());
            }
            this.FarmerDict[produce.Name].Add(farmer);
        }

        public void BuyProduceFromStand(string standLocationId, string produceName, int quantity)
        {
            Stand foundStand = this.FindStandByLocationId(standLocationId);
            foundStand.BuyProduce(produceName, quantity);
        }

        public void AssignFarmer(string standLocationId, Farmer farmer)
        {
            Stand foundStand = this.FindStandByLocationId(standLocationId);
            foundStand.Farmer = farmer;
            farmer.LocationId = foundStand.LocationId;
        }


        public Dictionary<string, Produce> GetAllProducesByStandLocationId(string standLocationId)
        {
            Stand foundStand = this.FindStandByLocationId(standLocationId);
            return foundStand.GetAllProduces();
        }

        public Dictionary<string, Produce> GetAllProducesByFarmerName(string farmerName)
        {
            Stand foundStand = this.FindStandByFarmerName(farmerName);
            return foundStand.GetAllProduces();
        }

        public Farmer FindFarmerByLocationId(string standLocationId)
        {
            Stand foundStand = this.Stands.FirstOrDefault(stand => stand.LocationId.Equals(standLocationId));
            return foundStand.Farmer;
        }

        public Stand FindStandByLocationId(string locationId)
        {
            return this.Stands.FirstOrDefault(stand => stand.LocationId.Equals(locationId));
        }

        public Stand FindStandByFarmerName(string farmerName)
        {
            return this.Stands.FirstOrDefault(stand => stand.Farmer.Name.Equals(farmerName));
        }

        public void PrintAllProducesByStandLocationId(string standLocationId)
        {
            Stand foundStand = this.FindStandByLocationId(standLocationId);
            foundStand.printProduces();
        }

        public void PrintAllProducesByFarmerName(string farmerName)
        {
            Stand foundStand = this.FindStandByFarmerName(farmerName);
            foundStand.printProduces();
        }

        public void PrintAllFarmersOfProduce(string produceName)
        {
            if (!this.FarmerDict.ContainsKey(produceName))
            {
                this.FarmerDict.Add(produceName, new List<Farmer>());
                Console.WriteLine("[]");
                return;
            }
            foreach (var farmer in this.FarmerDict[produceName])
            {
                farmer.printFarmer();
            }
        }
    }
}