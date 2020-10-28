using System;
using System.Collections.Generic;


namespace Figures
{
    interface IPrint
    {
        void Print();
    }

    abstract class GeomFig : IComparable
    {
        public abstract double Area();

        public int CompareTo(object obj)
        {
            GeomFig p = (GeomFig)obj;
            if (this.Area() < p.Area())
                return -1; 
            else if (this.Area() == p.Area()) 
                return 0;
            else 
                return 1;
        }

    }

    class Rectangle : GeomFig, IPrint
    {
        public double height { get; set; }
        public double width { get; set; }

        public Rectangle(double width, double height)
        {
            this.height = height;
            this.width = width;
        }

        public override double Area()
        {
            return height * width;
        }

        public override string ToString()
        {
            return ("Прямоугольник: \n   ширина: " + width + "\n   высота: " + height + "\n   площадь: " + Area());
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

    }

    class Square : Rectangle
    {
        public double squareSide { get; set; }
        public Square(double squareSide) : base(squareSide, squareSide)
        {
            this.squareSide = squareSide;
        }

        public override double Area()
        {
            return squareSide * squareSide;
        }

        public override string ToString()
        {
            return ("Квадрат: \n   длина стороны: " + squareSide + "\n   площадь: " + Area());
        }

    }

    class Circle : GeomFig, IPrint
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }

        public override string ToString()
        {
            return ("Круг: \n   радиус: " + radius + "\n   площадь: " + Area());
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

}
