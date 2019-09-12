namespace Estrutura.Pilha
{
    class Pilha
    {
        public Flag Topo { get; set; }

        public Pilha()
        {
            Topo = new Flag();
        }


        public void Clear()
        {
            Topo.Prox = null;
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

            Dado pop = Topo.Prox;
            Topo.Prox = pop.Prox;
            return pop;
        }
        public Dado Top()
        {
            if (IsEmpty()) return null;
            return Topo.Prox;
        }


        public int Size()
        {
            int size = 1;

            if (IsEmpty()) return 0;
            return size + Sum(Topo.Prox, size);
        }
        private int Sum(Dado atual, int size)
        {
            if (atual.Prox == null) return 0;
            return size + Sum(atual.Prox, size);
        }
    }
}
