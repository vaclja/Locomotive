using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    public class Train
    {
        public Locomotiva Locomotive { get; set; }
        public IList<IWagon> Wagons { get; set; }

        public Train()
        {
            Wagons = new ObservableCollection<IWagon>();
        }
        public Train(Locomotiva locomotive )
        {
            Locomotive = locomotive;
        }
        public Train(Locomotiva locomotive, ObservableCollection<IWagon> wagons)
        {
            Locomotive = locomotive;
            Wagons = wagons;
            if (Locomotive.Engine.EngineName == "parní" && Wagons.Count() > 5)
            {
                Console.WriteLine("Parní lokomotiva nemůže mít více než 5 vagónů.");
            }
        }
        public void ConnectWagon(IWagon wagon)
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
        public void DisconnectWagon(IWagon wagon)
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
                Console.WriteLine("Zadaný index vagónu je mimo rozsah.");
                return;
            }

            var wagon = Wagons[wagonIndex];

            if (wagon is not PersonalWagon personalWagon)
            {
                Console.WriteLine("Tento vagón není osobní – nelze rezervovat židli.");
                return;
            }

            if (seatIndex < 0 || seatIndex >= personalWagon.Chairs.Count)
            {
                Console.WriteLine("Židle s tímto indexem neexistuje.");
                return;
            }

            if (personalWagon.Chairs[seatIndex].Reserved)
            {
                Console.WriteLine("Židle už je rezervována.");
                return;
            }

            personalWagon.Chairs[seatIndex].Reserved = true;
            Console.WriteLine($"Židle {seatIndex} ve vagónu {wagonIndex} byla úspěšně rezervována.");
        }
        public void ListReservedChairs()
        {
            if (Wagons == null || Wagons.Count == 0)
            {
                Console.WriteLine("Žádné wagony nejsou k dispozici.");
                return;
            }
            int index = 0;
            foreach (var wagon in Wagons)
            {
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

