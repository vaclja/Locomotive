using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    public class Bed
    {
		private double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		private double width;

		public double Width
		{
			get { return width; }
			set { width = value; }
		}

		public Bed() 
		{
            // Výchozí konstruktor
        }
    }
}
