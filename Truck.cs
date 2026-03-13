using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Truck
{
    public string Model { get; set; }
    public string Registration { get; set; }
    public DateTime LastServiceDate { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Model} | {Registration} | Last Service: {LastServiceDate.ToShortDateString()}");
    }
}