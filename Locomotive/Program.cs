using Locomotive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Program;

internal class Program
{
    static void Main(string[] args)
    {
        BusinessWagon businessWagon = new BusinessWagon(10, new Person("Lenka", "Kozáková"));
        NightWagon nightWagon = new NightWagon(20, 10);
        Hopper hopper = new Hopper(1000);
        Locomotiva locomotive = new Locomotiva(new Person("Karel", "Novák"), new Engine("diesel"));
        Train train = new Train(locomotive, new List<IWagon> { businessWagon, nightWagon, hopper });
        Hopper hopper1 = new Hopper(2000);
        train.ConnectWagon(hopper1);
        Console.WriteLine(train.ToString());
        foreach (var wagon in train.Wagons)
        {
            Debug.WriteLine(wagon.ToString());
        }

        //Locomotiva locomotive = new Locomotiva(new Person("Karel", "Novák"), new Engine("parní"));
        //BusinessWagon BusinessWagon = new BusinessWagon(10, new Person("Lenka", "Kozáková"));
        //NightWagon NightWagon = new NightWagon(20, 10);
        //Hopper Hopper = new Hopper(1000);
        //Hopper Hopper1 = new Hopper(2000);
        //Hopper Hopper2 = new Hopper(3000);
        //Hopper Hopper3 = new Hopper(4000);
        //Train train = new Train(locomotive, new List<IWagon> { BusinessWagon, NightWagon, Hopper, Hopper1, Hopper2 });
        //foreach(var wagon in train.Wagons)
        //{
        //    Console.WriteLine(wagon);
        //}
        //train.ConnectWagon(Hopper3);
        //train.ReserveChair(0, 5); // Rezervace sedadla v BusinessWagon
        //train.ReserveChair(2, 6); // Rezervace sedadla v Hopper
        //train.ReserveChair(0, 5); // Rezervace stejného sedadla znovu
        //train.ListReservedChairs(); // Výpis rezervovaných sedadel
    }
}
