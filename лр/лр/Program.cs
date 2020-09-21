using System;
using System.Collections.Generic;


namespace QuadrEq
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            if (args.Length == 0)
            Console.WriteLine("Никитина Ксения Владимировна ИУ5-32Б");
            double[] coeff = new double[3];
            if (args.Length == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    coeff[i] = ReadDouble(i);
                }
            }
            else 
            {
                for (int i = 0; i < 3; i++)
                {
                    string resultString = Console.ReadLine();
                    if (!double.TryParse(resultString, out coeff[i])) 
                    {
                        Console.WriteLine("Ошибка в чтении параметров командной строки");
                    }
                }
            }
            List<double> roots = Calculate(coeff);
            Console.Write("Ответ: ");
            Write(roots, coeff);
        }

        static void Write(List<double> roots, double[] coeff) 
        { 
            if (roots.Count == 0 && !(coeff[0] == 0 && coeff[1] == 0 && coeff[2] == 0)) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет корней");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (int i in roots)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static List<double> Calculate(double[] coeff) 
        {
            List<double> roots = new List<double>();
            if (coeff[0] == 0)
            {
                if (coeff[1] != 0)
                {
                    if (coeff[2] == 0) {
                        roots.Add(0); 
                    }
                    else
                    {
                        if (coeff[2] / coeff[1] < 0)
                        {
                            roots.Add(Math.Sqrt(-(coeff[2] / coeff[1])));
                            roots.Add(-Math.Sqrt(-(coeff[2] / coeff[1])));
                        }
                    }
                }
                else
                {
                    if (coeff[2] == 0) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Бесконечное множество решений");
                    }

                }
            }
            else
            {
                double D = (coeff[1] * coeff[1] - 4 * coeff[0] * coeff[2]);
                if (D>0)
                {
                    double t1 = (-coeff[1] + Math.Sqrt(D)) / 2.0 / coeff[0];
                    double t2 = (-coeff[1] - Math.Sqrt(D)) / 2.0 / coeff[0];
                    if (t1 > 0)
                    {
                        roots.Add(Math.Sqrt(t1));
                        roots.Add(-Math.Sqrt(t1));
                    }
                    if (t2 > 0)
                    {
                        roots.Add(Math.Sqrt(t2));
                        roots.Add(-Math.Sqrt(t2));
                    }
                }
            }
            return roots;
        }

        static double ReadDouble(int num)
        {
            string resultString;
            double resultDouble;
            bool flag;
            do
            {
                Console.Write("Введите коффициент при х^" + (4- num*2) + ": ");
                resultString = Console.ReadLine();
                flag = double.TryParse(resultString, out resultDouble);
                if (!flag)
                {
                    Console.WriteLine("Необходимо ввести вещественное число");
                }
            }
            while (!flag);
            return resultDouble;
        }
    }
}

