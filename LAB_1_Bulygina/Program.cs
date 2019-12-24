using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_Bulygina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1");

            Console.Title = "Булыгина Светлана, ИУ5Ц-51Б";

            //double x1, x2, x3, x4;
            double d, t1, t2, t;

            Console.WriteLine("Поиск корней биквадратного уровнения");
            Console.WriteLine(" ax^4 + bx^2 + c = 0");

            double a = ReadDouble("Введите коэффициент A: ");
            double b = ReadDouble("Введите коэффициент B: ");
            double c = ReadDouble("Введите коэффициент C: ");
            Console.ReadLine();

            Console.WriteLine("Вы ввели коэффициенты: ");
            Console.WriteLine("А = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("С = " + c);
            Console.WriteLine(a + "x^4 + " + b + "x^2 + " + c + " = 0");
            Console.ReadLine();


            if (a == 0 && b == 0 && c != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это неравенство!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Заменим x^2 на t: at^2 + bt + c = 0  \r\n и найдем корни t1, t2");

                d = (b * b) - (4 * a * c);

                Console.WriteLine("Дескриминант =  " + d);
                //Console.WriteLine("Корень из дескрименанта =  " + Math.Sqrt(d));

                if (d > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    //t1 = Math.Sqrt(((-b) - (Math.Sqrt(d))) / (2 * a));
                    t1 = ((-b) - (Math.Sqrt(d))) / (2 * a);
                    Console.WriteLine("t1 = " + t1);
                    //t2 = Math.Sqrt(((-b) + (Math.Sqrt(d))) / (2 * a));
                    t2 = ((-b) + (Math.Sqrt(d))) / (2 * a);
                    Console.WriteLine("t2 = " + t2);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();

                    if (t1 >= 0 && t2 >= 0)
                    {
                        Console.WriteLine("Теперь возведем переменные t1 и t2 в корни и получим: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = " + Math.Sqrt(t1));
                        Console.WriteLine("x2 = " + -Math.Sqrt(t1));
                        Console.WriteLine("x3 = " + Math.Sqrt(t2));
                        Console.WriteLine("x4 = " + -Math.Sqrt(t2));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                    else if (t1 >= 0 && t2 < 0)
                    {
                        Console.WriteLine("Теперь проведем обратную замену положительной переменной t1: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = " + Math.Sqrt(t1));
                        Console.WriteLine("x2 = " + -Math.Sqrt(t1));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней от t2!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                    else if (t1 < 0 && t2 >= 0)
                    {
                        Console.WriteLine("Теперь проведем обратную замену положительной переменной t2: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней от t1!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = " + Math.Sqrt(t2));
                        Console.WriteLine("x2 = " + -Math.Sqrt(t2));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                    else if (t1 < 0 && t2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней от t1 и t2!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                    }
                }
                else if (d == 0)
                {
                    t = (-b) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("t = " + t);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();


                    Console.WriteLine("Теперь возведем переменную t в корень и получим: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x1 = " + Math.Sqrt(t));
                    Console.WriteLine("x2 = " + -Math.Sqrt(t));
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();

                }
                else if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет корней!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                }
            }

        }
        static double ReadDouble(string message) // Ввод вещественного числа с проверкой корректности ввода
        {
            string resultString;
            double resultDouble;
            bool flag;
            do
            {
                Console.Write(message);
                resultString = Console.ReadLine();
                //Первый способ преобразования строки в число
                flag = double.TryParse(resultString, out resultDouble);

                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Необходимо ввести вещественное число");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                }
            }
            while (!flag);
            return resultDouble;
        }

    }
}
