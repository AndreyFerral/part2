using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6 {
    class Program {
        static void Main(string[] args) {
            int i, j, iteration;
            int max_i, max_j;
            double max;

            const int m = 3, n = 3;
            double[,] a = new double[m, n] {
            {-1.1, -1.2, -1.3 },
            {-2.1, -2.2, -2.3 },
            {-3.1, 3.2, -3.3 }
            };

            Console.WriteLine("Исходный массив: ");
            for (i = 0; i < n; ++i) {
                for (j = 0; j < m; ++j) Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            
            for (iteration = 0; iteration < n; iteration++) {
                max_i = 0;
                max_j = 1;
                for (i = 0; i < n; i++) {
                    for (j = 0; j < n; j++) {
                        if (!(i == j && i < iteration)) {
                            if (a[i,j] > a[max_i,max_j]) {
                                max_i = i;
                                max_j = j;
                            }
                        }
                    }
                }
                max = a[max_i,max_j];
                a[max_i,max_j] = a[iteration,iteration];
                a[iteration,iteration] = max;
            }
           
            Console.WriteLine("\nОтсортированный массив (Макс. элемент находится в (1,1), следующий — в (2, 2), последний в (3, 3)):");
            for (i = 0; i < m; ++i) {
                for (j = 0; j < n; ++j) Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }

            for (i = 0; i < n; ++i) {
                int count = 0;
                for (j = 0; j < n; ++j) if (a[i,j] < 0) ++count;
                if (count == n) {
                    Console.WriteLine("\nПервая строка, не имеющая положительных цифр: "+ (i + 1));
                    Console.ReadLine();
                    System.Environment.Exit(0);
                } 
            }
            Console.WriteLine("\nВ каждой строке есть минимум одно положительное число");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
    }
}
