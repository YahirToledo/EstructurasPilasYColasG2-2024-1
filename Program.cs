using System;
using System.Collections.Generic;
using System.Threading;

namespace EstructurasPilasYColasG2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
            Apilamiento();
            Console.WriteLine();
            Cola();
            Console.ReadLine();
        }
        static void Apilamiento()
        {
            Stack<string> Nombres = new Stack<string>();
            Nombres.Push("Yahir");
            Nombres.Push("Sergio");
            Nombres.Push("Juan");
            int total = Nombres.Count;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("{0}", Nombres.Pop());
            }
        }
        static void Cola()
        {
            Queue<string> Fila = new Queue<string>();
            Fila.Enqueue("Yahir");
            Fila.Enqueue("Sergio");
            Fila.Enqueue("Juan");
            int total = Fila.Count;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Turno de {0}", Fila.Dequeue());
                Thread.Sleep(2000);
            }
        }
        static int Factorial(int N)
        {
            if (N == 0)
            {
                return 1;
            }
            return N*Factorial(N-1);
        }
    }
}
