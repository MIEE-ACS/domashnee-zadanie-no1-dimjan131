using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C; 
            Console.Write("Введите А: ");
            if( !int.TryParse(Console.ReadLine(), out A))
                Console.WriteLine("Некорретный ввод данных!");
            else
            {
                Console.Write("Введите B: ");
                if (!int.TryParse(Console.ReadLine(), out B))
                    Console.WriteLine("Некорретный ввод данных!");
                else
                {
                    Console.Write("Введите C: ");
                    if (!int.TryParse(Console.ReadLine(), out C))
                        Console.WriteLine("Некорретный ввод данных!");
                    else
                    {
                        int T = A;
                        A = B;
                        B = C;
                        C = T;
                        Console.WriteLine("Результат после обработки: A={0},  B={1},  C={2}", A, B, C);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
