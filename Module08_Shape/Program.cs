using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_Shape
{
    class Rectangle : Shape
    {
        public double Length_Rectangle(double Length)
        {
            Console.WriteLine("The length of the rectangle is {0} ", Length);
            return Length;
        }
        public double Width_Rectangle(double Width)
        {
            Console.WriteLine("The width of the rectangle is {0} ", Width);
            return Width;
        }
    }
    class Shape
    {
        double length;
        public double Length
        {
            get
            {
                return length;
            }
            set 
            {
                length = Length;
            }
        }
            
        double width;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = Width;
            }
        }
        public Shape()
        {
 
        }
        public double Area(double length, double width)
        {
            double area = length * width;
            Console.WriteLine("The area of the shape is: {0} ", area);
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Area(4.0, 5.0);
            Rectangle r = new Rectangle();
            r.Length_Rectangle(3.0);
            r.Width_Rectangle(7.0);
            r.Area(3.0, 7.0);
            Console.ReadKey();
        }
    }
}
