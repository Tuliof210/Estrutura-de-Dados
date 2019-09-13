namespace Estrutura.Pilha
{
    class Pilha
    {
        public Flag Topo { get; set; }
        public int Tamanho { get; private set; }

        public Pilha()
        {
            Topo = new Flag();
        }


        public void Clear()
        {
            Topo.Prox = null;
            Tamanho = 0;
        }
        public bool IsEmpty()
        {
            if (Topo.Prox == null) return true;
            return false;
        }


        public void Push(Dado dado)
        {
            if (IsEmpty())
            {
                Topo.Prox = dado;
                Tamanho++;
            }
            else Push(dado, Topo.Prox);
        }
        private void Push(Dado dado, Dado atual)
        {
            Topo.Prox = dado;
            dado.Prox = atual;
            Tamanho++;
        }


        public Dado Pop()
        {
            if (IsEmpty()) return null;

            Dado pop = Topo.Prox;
            Topo.Prox = pop.Prox;
            Tamanho--;

            pop.Prox = null;

            return pop;
        }
        public Dado Top()
        {
            if (IsEmpty()) return null;
            return Topo.Prox;
        }


        public int Size()
        {
            return Tamanho;
        }
    }
}
