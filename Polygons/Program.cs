using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygons.Library;

namespace Polygons
{
	class Program
	{
		static void Main(string[] args)
		{
			Square square = new Square(10);
			DisplayPolygon("Square", square);

			var triangle = new Triangle(10);
			DisplayPolygon("Triangle", triangle);

			var octagon = new Octagon(10);
			DisplayPolygon("Octagon", octagon);

			Console.Read();

		}

		private static void DisplayPolygon(string ploygonType, dynamic polygon)
		{
			Console.WriteLine($"{ploygonType} number of Sides:\t{polygon.NumberOfSides}");
			Console.WriteLine($"{ploygonType} side length:\t{polygon.SideLength}");
			Console.WriteLine($"{ploygonType} perimeter:\t{polygon.GetPerimeter()}");
			Console.WriteLine($"{ploygonType} area:\t{polygon.GetArea()}\r\n");
		}
	}
}
