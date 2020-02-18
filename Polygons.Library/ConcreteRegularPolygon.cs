using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
	public class ConcreteRegularPolygon
	{
		public int NumberOfSides{ get; set; }
		private int _sideLength;
		public int SideLength
		{
			set { _sideLength = value; }
			get { return _sideLength; }
		}
//		public int SideLength { get; set; }

		public ConcreteRegularPolygon()
		{
			NumberOfSides = 4;
			SideLength = 12;
		}
		public ConcreteRegularPolygon(int sides, int length)
		{
			NumberOfSides = sides;
			SideLength = length;
		}

		public double GetPerimeter()
		{
			return NumberOfSides * SideLength;
		}

		public virtual double GetArea()
		{
			throw new NotImplementedException();
		}
	}
}
