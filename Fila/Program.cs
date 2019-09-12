using System;

namespace Estrutura.Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            Console.WriteLine($"Tamanho: {fila.Size()}");
            Console.WriteLine($"Vazia? {fila.IsEmpty()}");

            fila.Enqueue(new Dado('A'));
            fila.Enqueue(new Dado('B'));

            Console.WriteLine($"\nVazia? {fila.IsEmpty()}");

            fila.Enqueue(new Dado('C'));

            Console.WriteLine($"First: {fila.First()}");
            Console.WriteLine($"Last: {fila.Last()}");

            Console.WriteLine($"Desenfilerado: {fila.Dequeue()}");
            Console.WriteLine($"Desenfilerado: {fila.Dequeue()}");
            Console.WriteLine($"Desenfilerado: {fila.Dequeue()}");

            Console.WriteLine($"\nVazia? {fila.IsEmpty()}");

            Console.ReadKey();
        }
    }
}
