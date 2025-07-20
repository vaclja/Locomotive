using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    internal class Door
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
		public Door(double height, double width)
		{
            this.height = height;
            this.width = width;
        }
	}
}
