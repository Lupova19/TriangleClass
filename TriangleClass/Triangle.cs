using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClass
{
    internal class Triangle
    {

        private double a;
        private double h;

        //public double A { get; set; }
        //public double H { get; set; }

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double H
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }

        public Triangle(double a, double h)
        {
            this.a = a;
            this.h = h;
        }

        //public Triangle()
        //{
        //    this.A = 0;
        //    this.H = 0;                
        //}

        public double AreaOfTriangle()
        {
            return a * h / 2;         // s = ?; s = a * h / 2;!!!
        }
        public void PrintTriangle()
        {
            Console.WriteLine($"Stranata e {this.A}, visocinata kam neq e {this.H} s lice {AreaOfTriangle()}!");
        }
        public double Lenght()
        {
            return a;
        }
        public double Height()
        {
            return h;
        }
    }
}
