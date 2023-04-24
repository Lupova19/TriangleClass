using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi A = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Vavedi H = ");
            double h = double.Parse(Console.ReadLine());

            Triangle triangle1 = new Triangle(a, h);

            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(triangle1);

            triangle1.AreaOfTriangle();
            triangle1.PrintTriangle();
            triangle1.Lenght();
            triangle1.Height();
        }
    }
}
