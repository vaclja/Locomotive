using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    internal class Train 
    {
        public Locomotive Locomotive { get; set; }
        public List<Object> Wagons { get; set; }

        public Train()
        {
            // Výchozí konstruktor
        }
        public Train(Locomotive locomotive, )
        {
            Locomotive = locomotive;
        }
        public Train(Locomotive locomotive, List<Object> wagons)
        {
            Locomotive = locomotive;
            Wagons = wagons;
        }
        public void ConnectWagon(Object wagon)
        {
            if (Wagons == null)
            {
                Console.WriteLine("V listu Wagons není žádný wagon.");
            }
            Wagons.Add(wagon);
        }
        public void DisconnectWagon(Object wagon)
        {
            if (Wagons == null || !Wagons.Contains(wagon))
            {
                Console.WriteLine("Wagon není v seznamu Wagons.");
                return;
            }
            Wagons.Remove(wagon);
        }
        public void ReserveChair() : base (
    }
}
