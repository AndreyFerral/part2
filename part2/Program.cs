using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] a = new int[n] { 1, 3, 0, 1, 0, 1, -1, 3, 8, 4 };
            int noll = 0;
            int positive = 0; 
            int SumAfterNoll = 0;

            Console.WriteLine("Изначальный массив:");
            for (int i = 0; i < n; ++i) Console.Write(a[i] + " ");

            // Задание 1
            for (int i = 0; i < n; ++i) { if (a[i] > 0) { positive++; } };
            Console.WriteLine("\nКол-во положительных элементов: " + positive + "\n");

            // Задание 2
            for (int i = 0; i < n; ++i) if (a[i] == 0) noll = i;
            Console.WriteLine("Последний ноль на " + (noll+1) + " позиции");

            for (int i = noll; i < n; ++i) SumAfterNoll = SumAfterNoll + a[i];
            Console.WriteLine("Сумма элементов после последнего нуля " + SumAfterNoll + "\n");

            // Задание 3
            int first = 0;
            int lessNoll = 0;
            int another = 0;
            for (int i = 0; i < n; ++i) {
                if (a[i] < 1) {
                    lessNoll = a[i];
                    another = a[first];
                    a[first] = lessNoll;
                    a[i] = another;
                    first++;
                }
             }

            Console.WriteLine("Массив, в которым сначала элементы <1, далее остальные:");
            for (int i = 0; i < n; ++i) Console.Write(a[i] + " ");

            Console.ReadLine();

        }
    }
}
