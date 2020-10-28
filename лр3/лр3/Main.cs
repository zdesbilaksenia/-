using System;
using System.Collections;
using System.Collections.Generic;

namespace Figures
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("    Перечень фигур:\n");
            Rectangle rect = new Rectangle(10, 20);
            Square sq = new Square(10);
            Circle circle = new Circle(25);
            rect.Print();
            sq.Print();
            circle.Print();

            Console.WriteLine("\n    Коллекция ArrayList до сортировки:\n");
            ArrayList arrayListFigures = new ArrayList();
            arrayListFigures.Add(rect);
            arrayListFigures.Add(sq);
            arrayListFigures.Add(circle);
            foreach (GeomFig x in arrayListFigures)
                Console.WriteLine(x);
            Console.WriteLine("\n    После сортировки:\n");
            arrayListFigures.Sort();
            foreach (GeomFig x in arrayListFigures)
                Console.WriteLine(x);

            Console.WriteLine("\n    Коллекция List<GeomFig> до сортировки:\n");
            List<GeomFig> fl = new List<GeomFig>();
            fl.Add(circle);
            fl.Add(rect);
            fl.Add(sq);
            fl.Sort();
            foreach (GeomFig x in fl)
                Console.WriteLine(x);
            Console.WriteLine("\n    После сортировки:\n");
            foreach (GeomFig x in fl)
                Console.WriteLine(x);

            Console.WriteLine("\n    Матрица\n");
            Matrix<GeomFig> matrix = new Matrix<GeomFig>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = sq;
            matrix[2, 2, 2] = circle;
            Console.WriteLine(matrix.ToString());

            Console.WriteLine("\n    Пример работы класса  SimpleStack:\n");
            Console.WriteLine("Фигуры добавлены в SimpleStack с помощью метода Push() и выведены с помощью метода Pop()\n");
            SimpleStack<GeomFig> simpleStackFigures = new SimpleStack<GeomFig>();
            simpleStackFigures.Push(rect);
            simpleStackFigures.Push(sq);
            simpleStackFigures.Push(circle);
            while (simpleStackFigures.Count != 0)
                Console.WriteLine(simpleStackFigures.Pop());
        }
    }
}
