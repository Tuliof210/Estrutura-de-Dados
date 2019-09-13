using System;

namespace Estrutura.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            Console.WriteLine($"Vazia? {lista.IsEmpty()}");

            lista.Add(new Dado('a'));
            lista.Add(new Dado('b'));
            lista.Add(new Dado('c'));
            lista.Add(new Dado('d'));
            lista.Add(new Dado('e'));
            lista.Add(new Dado('f'));
            lista.Add(new Dado('g'));

            Console.WriteLine($"Vazia? {lista.IsEmpty()}");

            Console.WriteLine($"First: {lista.First()}, Last: {lista.Last()}");

            Console.WriteLine($"Tamanho: {lista.Size()}");

            lista.Remove();
            Console.WriteLine($"Tamanho: {lista.Size()}");

            lista.Remove();
            Console.WriteLine($"Tamanho: {lista.Size()}");

            Console.WriteLine($"First: {lista.First()}, Last: {lista.Last()}");

            Console.WriteLine($"Procurado(c): {lista.Find('c')}");

            lista.Clear();
            Console.WriteLine($"Vazia? {lista.IsEmpty()}");

            Console.ReadKey();
        }
    }
}
