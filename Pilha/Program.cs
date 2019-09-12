using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            pilha.Push(new Dado(1));

            Console.WriteLine("Pilha Vazia: " + pilha.IsEmpty());

            pilha.Push(new Dado(2));
            Console.WriteLine("\nTopo da Pilha: " + pilha.Top());

            pilha.Push(new Dado(7));

            Console.WriteLine("\nTamanho da Pilha: " + pilha.Size());

            Console.WriteLine("\nRetirado: " + pilha.Pop());
            Console.WriteLine("Retirado: " + pilha.Pop());
            Console.WriteLine("Retirado: " + pilha.Pop());

            Console.WriteLine("\nPilha Vazia: " + pilha.IsEmpty());

            Console.ReadKey();
        }
    }
}
