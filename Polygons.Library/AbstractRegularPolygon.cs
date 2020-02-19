using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
	public abstract class AbstractRegularPolygon
	{
		private int sides;
		private int length;

		public int NumberOfSides { get; set; }
		public int SideLength
		{
			set;
			get;
		}

		public AbstractRegularPolygon(int sides, int length, int length1)
		{
			NumberOfSides = sides;
			SideLength = length;
		}

		protected AbstractRegularPolygon(int sides, int length)
		{
			//this.v = v;
			//this.length = length;
			NumberOfSides = sides;
			SideLength = length;
		}

		public double GetPerimeter()
		{
			return NumberOfSides * SideLength;
		}
		public abstract double GetArea();
	}
}
