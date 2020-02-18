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
			var area = square.GetArea();
			Console.WriteLine($"Area is：\t{area}");
		}
	}
}
