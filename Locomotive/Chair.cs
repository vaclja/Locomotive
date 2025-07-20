using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    internal class Chair
    {
		private bool nearWindow;

		public bool NearWindow
		{
			get { return nearWindow; }
			set { nearWindow = value; }
		}
		private int number;

		public int Number
		{
			get { return number; }
			set { number = value; }
		}
		private bool reserved;

		public bool Reserved
		{
			get { return reserved; }
			set { reserved = value; }
		}

		public Chair(bool nearWindow, int number)
        {
            this.nearWindow = nearWindow;
            this.number = number;
            this.reserved = false; // Výchozí hodnota pro rezervaci
        }
    }
}
