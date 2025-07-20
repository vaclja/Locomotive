using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    internal class Train
    {
        public Locomotiva Locomotive { get; set; }
        public List<Object> Wagons { get; set; }

        public Train()
        {
            // Výchozí konstruktor
        }
        public Train(Locomotiva locomotive )
        {
            Locomotive = locomotive;
        }
        public Train(Locomotiva locomotive, List<Object> wagons)
        {
            Locomotive = locomotive;
            Wagons = wagons;
            if (Locomotive.Engine.EngineName == "parní" && Wagons.Count() > 5)
            {
                Console.WriteLine("Parní lokomotiva nemůže mít více než 5 vagónů.");
            }
        }
        public void ConnectWagon(Object wagon)
        {
            if (Wagons == null)
            {
                Console.WriteLine("V listu Wagons není žádný wagon.");
            }
            if(Locomotive.Engine.EngineName == "parní" && Wagons.Count >= 5)
            {
                Console.WriteLine("K parvní lokomotivě nemůžu připojit další vagón, protože jich již táhne 5.");
                return;
            }
            else
            {
                Wagons.Add(wagon);
            }
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
        public void ReserveChair(int wagonIndex, int seatIndex)
        {
            if (Wagons == null || wagonIndex < 0 || wagonIndex >= Wagons.Count)
            {
                Console.WriteLine("Wagon s daným indexem neexistuje.");
                return;
            }
            var wagon = Wagons[wagonIndex];
            if (wagon is not PersonalWagon personalWagon)
            {
                Console.WriteLine("Wagon není typu PersonalWagon.");
                return;
            }
            else
            {
                wagon = wagon as PersonalWagon;
                var chair = personalWagon.Chairs[seatIndex];
            }
            if(seatIndex < 0 || seatIndex >= personalWagon.Chairs.Count)
            {
                Console.WriteLine("Židle s daným indexem ve wagónu neexistuje.");
                return;
            }
            if (personalWagon.Chairs[seatIndex].Reserved)
            {
                Console.WriteLine("Židle je již rezervována.");
                return;
            }
            else
            {
                personalWagon.Chairs[seatIndex].Reserved = true;
                Console.WriteLine($"Židle {seatIndex} ve wagónu {wagonIndex} byla úspěšně rezervována.");
            }
        }
        public void ListReservedChairs()
        {
            if (Wagons == null || Wagons.Count == 0)
            {
                Console.WriteLine("Žádné wagony nejsou k dispozici.");
                return;
            }
            foreach (var wagon in Wagons)
            {
                int index = 0;
                if (wagon is PersonalWagon personalWagon)
                {
                    for (int i = 0; i < personalWagon.Chairs.Count; i++)
                    {
                        if (personalWagon.Chairs[i].Reserved)
                        {
                            Console.WriteLine($"Židle {i} ve wagónu {index} je rezervována.");
                        }
                    }
                    index++;
                }
            }
        }
        public override string ToString()
        {
            return Wagons.ToString() + $"Locomotive: {Locomotive}";
        }
    } 
}

