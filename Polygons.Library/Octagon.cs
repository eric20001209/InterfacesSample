using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
	public class Octagon :  Object,  IRegularPolygon
	{
		public Octagon(int length)
		{
			NumberOfSides = 8;
			SideLength = length;
		}

		public int NumberOfSides { get ; set ; } //automatic properties
		public int SideLength { get ; set ; }

		public double GetArea()
		{
			return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
		}

		public double GetPerimeter()
		{
			return SideLength * NumberOfSides;
		}
	}
}
