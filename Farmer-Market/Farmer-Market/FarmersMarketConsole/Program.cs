using System;
using System.Collections.Generic;
using Farmer_Market;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Farmer Market!\n=========================");

        FarmersMarket market = new FarmersMarket();
        Start(market);
    }

    private static void Start(FarmersMarket market)
    {
        Console.WriteLine("\nPlease select an option:");
        Console.WriteLine("{Please run option 1 & 2 first before running other options}");
        Console.WriteLine("1. Show all stands");
        Console.WriteLine("2. Create new stand");
        Console.WriteLine("3. Assign farmer to a stand");
        Console.WriteLine("4. Show all produces of a stand");
        Console.WriteLine("5. Show all produces of a farmer");
        Console.WriteLine("6. Add produce");
        Console.WriteLine("7. Search produce");
        Console.WriteLine("8. Buy produce");
        Console.WriteLine("9. Quit");
        Console.Write("\nPlease enter option number: ");

        string choice = Console.ReadLine();
        Execute(choice, market);
    }

    private static void Execute(string choice, FarmersMarket market)
    {
        switch (choice)
        {
            case "1":
                ShowAllStands(market);
                Start(market);
                break;
            case "2":
                CreateNewStand(market);
                Start(market);
                break;
            case "3":
                AssignFarmer(market);
                Start(market);
                break;
            case "4":
                ShowProducesOfStand(market);
                Start(market);
                break;
            case "5":
                ShowProducesOfFarmer(market);
                Start(market);
                break;
            case "6":
                AddProduce(market);
                Start(market);
                break;
            case "7":
                SearchProduce(market);
                Start(market);
                break;
            case "8":
                BuyProduce(market);
                Start(market);
                break;
            case "9":
                Console.WriteLine("Exiting the program. Goodbye!");
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input. Please try again.");
                Start(market);
                break;
        }
    }


    private static void ShowAllStands(FarmersMarket market)
    {
        Console.WriteLine("---------------------------- All Stands --------------------------");
        market.PrintAllStands(market.GetAllStands());
    }


    private static void CreateNewStand(FarmersMarket market)
    {
       
        Console.WriteLine("What is the Farmer's name for this stand ?");
        string farmerName = Console.ReadLine();
        Stand newStand = new Stand(new Farmer(farmerName));
        market.AddStand(newStand);
        Console.WriteLine("---------------------------- Added New Stand --------------------------");
    }


    private static void AssignFarmer(FarmersMarket market)
    {
        
        Console.WriteLine("Enter standLocationId: ");
        string standLocationId = Console.ReadLine();
        Console.Write("Enter farmer's name: ");
        string farmerName = Console.ReadLine();
        market.AssignFarmer(standLocationId, new Farmer(farmerName));
        Console.WriteLine("---------------------------- Assigned Farmer --------------------------");
    }


    private static void ShowProducesOfStand(FarmersMarket market)
    {
        Console.Write("Enter standLocationId: ");
        string standLocationId = Console.ReadLine();
        market.PrintAllProducesByStandLocationId(standLocationId);
        Console.WriteLine("---------------------------- All Produces --------------------------");
    }


    private static void ShowProducesOfFarmer(FarmersMarket market)
    {
        Console.Write("Enter farmer's name: ");
        string farmerName = Console.ReadLine();
        market.PrintAllProducesByFarmerName(farmerName);
        Console.WriteLine("---------------------------- All Produces --------------------------");
    }

    private static void AddProduce(FarmersMarket market)
    {
        

        Console.WriteLine("Enter standLocationId: ");
        string standLocationId = Console.ReadLine();
        Console.Write("Enter produce name: ");
        string produceName = Console.ReadLine();
        Console.Write("Enter produce quantity: ");
        int quantity = int.Parse(Console.ReadLine());   
        market.AddProduceToStand(standLocationId, new Fruit(produceName, quantity));
        Console.WriteLine("---------------------------- Added Produce --------------------------");

    }


    private static void SearchProduce(FarmersMarket market)
    {
        Console.Write("Enter produceName: ");
        string produceName = Console.ReadLine();
        market.PrintAllFarmersOfProduce(produceName);
        Console.WriteLine("---------------------------- Output --------------------------");
    }


    private static void BuyProduce(FarmersMarket market)
    {
        
        Console.Write("Enter standLocationId: ");
        string standLocationId = Console.ReadLine();

        Console.Write("Enter produceName: ");
        string produceName = Console.ReadLine();

        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        market.BuyProduceFromStand(standLocationId, produceName, quantity);
        Console.WriteLine("---------------------------- Bought --------------------------");
    }
}