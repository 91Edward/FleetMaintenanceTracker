using System;
using System.Collections.Generic;

class Program
{
    static List<Truck> fleet = new List<Truck>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Fleet Maintenance Tracker ===");
            Console.WriteLine("1. Add Truck");
            Console.WriteLine("2. View Fleet");
            Console.WriteLine("3. Exit");

            Console.Write("Select option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    AddTruck();
                    break;
                case "2":
                    ViewFleet();
                    break;
                case "3":
                    running = false;
                    break;
            }
        }
    }

    static void AddTruck()
    {
        Truck truck = new Truck();
        Console.Write("Truck Model: ");
        truck.Model = Console.ReadLine();

        Console.Write("Resigstration: ");
        truck.Registration = Console.ReadLine();

        Console.Write("Last Service Date (yyyy- mm-dd): ");
        truck.LastServiceDate = DateTime.Parse(Console.ReadLine());

        fleet.Add(truck);

        Console.WriteLine("Truck added successfully");
    }

    static void ViewFleet()
    {
        Console.WriteLine("\nFleet List:");

        foreach(Truck truck in fleet)
        {
            truck.DisplayInfo();
        }
    }
}
