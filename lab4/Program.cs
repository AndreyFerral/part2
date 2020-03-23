using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Equation {
        public double arg;
        public Equation(double A) {
            this.arg = A;
        }

        // точность вычисления
        const double e = 10e-5;
        private double f(double x) {
            return arg * x - Math.Cos(x);
        }

        public void Solve(double a, double b) {
            if (f(a) * f(b) > 0)
                Console.WriteLine("Корней нет");
            else {
                double c = (a + b) / 2;
                while (Math.Abs(b - a) >= e) {
                    if (f(a) * f(c) < 0) b = c;
                    else a = c;
                    c = (a + b) / 2;
                }
                Console.WriteLine("x = {0}", c);
            }
        }
    }

    class Program {
        public static void Main(string[] args) {

            Console.WriteLine("Исходное уравнение: ax - cos(x) = 0");

            Console.Write("Введите аргумент а: ");
            double catch_a = Double.Parse(Console.ReadLine()); // 1

            Console.Write("Введите начало интервала: ");
            double catch_S = Double.Parse(Console.ReadLine()); // 6 

            Console.Write("Введите конец интервала: ");
            double catch_E = Double.Parse(Console.ReadLine()); // 10

            Equation eq = new Equation(catch_a);

            eq.Solve(catch_S, catch_E); // Корней нет
            // eq.arg = 5;
            //eq.Solve(-1, 1.0);

            Console.ReadKey();
        }
    }
}
