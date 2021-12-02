
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Решение квадратного уравнения");
            ввод данных
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());

            double x1, x2;
            дискриминант
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");
            }
            else
            {
                if (discriminant == 0) /квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                    Console.WriteLine("Корни: {x}+yi и {x}-yi");
                }
                else /уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                /вывод корней уравнения
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }

            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey(true);*/

            //2

            /*double pi = 0, num = 1;
            Console.WriteLine("Введите количество слагаемых");
            int member = int.Parse(Console.ReadLine());
            for (int i = 0; i < member; i++)
            {
                if (i % 2 == 0)
                {
                    pi += (1 / num);
                }
                else
                {
                    pi -= (1 / num);
                }
                num += 2;
            }
            pi = 4 * pi;
            Console.WriteLine("Ответ: " + pi);*/

            //3

            /*            Console.WriteLine("Введите число элементов для ряда Фибоначчи");
                        int element = int.Parse(Console.ReadLine());
                        int num = 0;
                        int f0 = 1, f1 = 1;
                        for (int i = 2; i < element + 2; i++)
                        {
                            int f2 = f0 + f1;
                            double n_2 = f2;
                            if (n_2 >= 1000 && n_2 < 10000)
                            {
                                num++;
                            }
                            f0 = f1;
                            f1 = f2;
                        }
                        Console.WriteLine("Количесво 4х значных чисел :" + num);*/

            //4
            /*            double x, s, c, q;
                        int i, fakt, z;
                        Console.WriteLine("Введите x: ");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите  q: ");
                        q = double.Parse(Console.ReadLine());
                        s = x * x;
                        fakt = 2;
                        c = 1;
                        i = 2;
                        z = -1;
                        while (s / fakt >= q)
                        {
                            c = c + z * s / fakt;
                            i += 2;
                            s = s * x * x;
                            fakt = fakt * (i - 1) * i;
                            z = z * (-1);
                        }
                        i = i / 2 + 1;
                        x = Math.Cos(x);
                        Console.WriteLine($"Количество слагаемых =  {i}");
                        Console.WriteLine("Значение cos(x) = " + c);
                        Console.ReadKey();*/
            //5
            /*Console.Write("Введите натуральное число: ");

            double Q, W, E, R, T, Y;
            Q = double.Parse(Console.ReadLine());
            if (Q < 0)
                Console.WriteLine("Не является натуральным числом");
            else
            {


                Y = 0;

                for (double a = 1; a < Q; a++)
                {
                    for (double b = 1; b < Q; b++)
                    {

                        for (double c = 1; c < Q; c++)
                        {
                            W = a * a * a;
                            E = b * b * b;
                            R = c * c * c;
                            T = W + E + R;

                            if (T == Q)
                            {
                                Console.WriteLine("кубы числа T= " + W + " " + E + " " + R);
                                Y = 1;

                            }
                        }

                    }

                }
                if (Y != 1)
                    Console.Write("No such combinations!");*/
            //6
            Console.Write("Введие число от 0 до 100: ");
            int i;
            i = int.Parse(Console.ReadLine());


            if ((i >= 0) & (i <= 100))
            {
                if ((i >= 5) & (i < 15))
                {
                    if (i % 100 == 1)
                        Console.WriteLine(i + " год");

                    else
                        Console.WriteLine(i + " лет");
                }


                if ((i >= 15) | (i < 5))
                {


                    if (i % 10 == 1)
                        Console.WriteLine(i + " год");
                    if ((i % 10 > 1) & (i % 10 < 5))
                        Console.WriteLine(i + " года");
                    if ((i % 10 == 0) | (i % 10 >= 5))
                        Console.WriteLine(i + " лет");
                }
            }
        }
    }
}


