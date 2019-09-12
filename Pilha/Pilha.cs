using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Pilha
    {
        public Flag Topo { get; set; }

        public Pilha()
        {
            Topo = new Flag(int.MaxValue);
        }

        public bool IsEmpty()
        {
            if (Topo.Prox == null) return true;
            return false;
        }
        public void Push(Dado dado)
        {
            if (IsEmpty()) Topo.Prox = dado;
            else Push(dado, Topo.Prox);
        }
        private void Push(Dado dado, Dado atual)
        {
            Topo.Prox = dado;
            dado.Prox = atual;
        }
        public Dado Pop()
        {
            if (IsEmpty()) return null;
            else
            {
                Dado pop = Topo.Prox;
                Topo.Prox = pop.Prox;
                return pop;
            }
        }
        public Dado Top()
        {
            if (IsEmpty()) return null;
            else
            {
                return Topo.Prox;
            }
        }
        public int Size()
        {
            int size = 1;

            if (IsEmpty()) return 0;
            else
            {
                return size + Sum(Topo.Prox, size);
            }
        }
        private int Sum(Dado atual, int size)
        {
            if (atual.Prox == null) return 0;
            else
            {
                return size + Sum(atual.Prox, size);
            }
        }
    }
}
