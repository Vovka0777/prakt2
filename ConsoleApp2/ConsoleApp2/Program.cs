using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1..

            //1.

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //int c = a + b;
            //int d = a * b;
            //Console.WriteLine($"{a}+{b}={a+b}\n{a}*{b}={a*b}");
            //Console.Read();

            //2.

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a}+{b}={b}+{a}\n{a}*{b}={b}*{a}");
            //Console.Read();

            //3.

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a}+{b}+{c}={a + b + c}");
            //Console.Read();

            //4.

            //Console.Write("a = ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //double b = double.Parse(Console.ReadLine());
            //double c = a * b;
            //Console.WriteLine($"{a:f1}*{b:f1}={a * b:f1}");
            //Console.Read();

            //5.

            //Console.Write("a = ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{a:f3}/{b:f3}={a / b:f3}");
            //Console.Read();

            //6.

            //Console.Write("a = ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //double c = double.Parse(Console.ReadLine());
            //Console.WriteLine($"({a:f2}+{b:f2})+{c:f2}={a:f2}+({b:f2}+{c:f2})");
            //Console.Read();

            //7.

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"a+b={a}+{b}={a + b}\ta-b={a}-{b}={a - b}\ta*b={a}*{b}={a * b}");
            //Console.Read();

            //8.

            //Console.Write("Номинал купюры = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Количество купюр = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write($"Сумма денег = {a * b:c}");
            //Console.Read();

            //2..

            //1.

            //Console.Write("Радиус равен = ");
            //double r = double.Parse(Console.ReadLine());
            //Console.Write($"Длина окружности = {2*Math.PI*r:f2}\nПлощадь окружности = {Math.PI * Math.Pow(r, 2):f2}");
            //Console.Read();

            //2.

            //Console.Write("Количество жителей = ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Площадь (км^2) = ");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Плотность составляет {a / b:f2}");
            //Console.ReadLine();

            //3.

            //Console.Write("1 катет = ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("2 катет = ");
            //double b = double.Parse(Console.ReadLine());
            ////double cc = Math.Pow(a, 2) + Math.Pow(b, 2);
            //double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine($"Периметр треугольника = {a+b+c}");
            //Console.ReadLine();

            //4.

            Console.Write("1 сторона = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("2 сторона = ");
            double b = double.Parse(Console.ReadLine());
            double d = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.Write($"Периметр прямоугольника = {(a + b) * 2}\nДлина диагонали прямоугольника = {Math.Sqrt(d)}");
            Console.Read();
        }
    }
}
