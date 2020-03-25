using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Equation {
        private double arg;
        public Equation(double A) {
            this.arg = A;
        }

        // точность вычисления
        const double e = 10e-5;
        private double function(double x) {
            return arg * x - Math.Cos(x);
        }

        public void SolveFunction(double a, double b) {
            if (function(a) * function(b) > 0) {
                try {
                    throw new Exception("Корней нет");
                }
                catch (Exception Exc) {
                    Console.WriteLine($"Ошибка: {Exc.Message}");
                }
            }
            else {
                double c = (a + b) / 2;
                while (Math.Abs(b - a) >= e) {
                    if (function(a) * function(c) < 0) b = c;
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
            double.TryParse(Console.ReadLine(), out double catch_a);

            Console.Write("Введите начало интервала: ");
            double.TryParse(Console.ReadLine(), out double catch_S);

            Console.Write("Введите конец интервала: ");
            double.TryParse(Console.ReadLine(), out double catch_E);

            Equation eq = new Equation(catch_a);

            eq.SolveFunction(catch_S, catch_E); 

            Console.ReadKey();
        }
    }
}
