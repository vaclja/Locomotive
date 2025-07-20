using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Který program chcete spustit?");
        Console.WriteLine("1. Locomotive");
        string program = Console.ReadLine();
        switch (program)
        {
            case "1":
                Locomotive.Locomotive.Run();
                break;
            default:
                Console.WriteLine("Neplatná volba.");
                break;
        }
    }
}
