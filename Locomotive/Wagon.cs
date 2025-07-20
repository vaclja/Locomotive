using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    internal abstract class PersonalWagon
    {
        public List<Door> Doors { get; set; }
        public List<Chair> Chairs { get; set; }
        public int numberOfChairs { get; set; }

        public PersonalWagon(int numberOfChairs)
        {
            this.numberOfChairs = numberOfChairs;
            Doors = new List<Door>();
            Chairs = new List<Chair>();
        }
        public override string ToString()
        {
            return $"Wagon with {numberOfChairs} chairs, {Doors.Count} doors and {Chairs.Count} chairs.";
        }
    }
    internal class EconomyWagon : PersonalWagon
    {
        public EconomyWagon(int numberOfChairs) : base(numberOfChairs)
        {

        }

        public override string ToString()
        {
            return "This is economy Wagon." + base.ToString();

        }
    }
    internal class BusinessWagon : PersonalWagon
    {
        private Person steward;

        public Person Steward
        {
            get { return steward; }
            set { steward = value; }
        }
        public BusinessWagon(int numberOfChairs, Person steward) : base(numberOfChairs)
        {

        }
        public override string ToString()
        {
            return $"This is business Wagon." + base.ToString() + $"Steward is {steward}";
        }
    }
    internal class NightWagon : PersonalWagon
    {
        List<Bed> beds { get; set; }
        private int numberOfBeds;

        public int NumberOfBeds
        {
            get { return numberOfBeds; }
            set { numberOfBeds = value; }
        }

        public NightWagon(int numberOfChairs, int numberOfBeds) : base(numberOfChairs)
        {
            this.numberOfBeds = numberOfBeds;
            beds = new List<Bed>();
            for (int i = 0; i < numberOfBeds; i++)
            {
                beds.Add(new Bed());
            }
        }
        public override string ToString()
        {
            return "This is night Wagon." + base.ToString() + $"Number of beds {numberOfBeds}";
        }
    }
    internal class Hopper
    {
        private double loadingCapacity;

        public double LoadingCapacity
        {
            get { return loadingCapacity; }
            set { loadingCapacity = value; }
        }
        public Hopper(double loadingCapacity)
        {
            this.loadingCapacity = loadingCapacity;
        }
        public override string ToString()
        {
            return $"This is Hopper, it has loading capacity of {loadingCapacity}";
        }
    }
}
