using System;

namespace Figures
{
    interface IPrint
    {
        void Print(); 
    }

    abstract class GeomFig
    {
        public abstract double Area();

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

    class MainClass {
        public static void Main()
        {
            Rectangle rect = new Rectangle(10, 20);
            Square sq = new Square(10);
            Circle circle = new Circle(25);
            rect.Print();
            sq.Print();
            circle.Print();
        }
    }
}
