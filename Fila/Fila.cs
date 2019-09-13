/*
 * Utilizado um modelo de fila em que o ultimo objeto aponta para o primeiro
 * criando assim um modelo circular
 * pelo fato de uma fila normal ser um modelo continuo isso evitará problemas com memoria
*/
namespace Estrutura.Fila
{
    class Fila
    {
        public Flag Primeiro { get; set; }
        public int Tamanho { get; private set; }

        public Fila()
        {
            Primeiro = new Flag();
            Primeiro.Prox = Primeiro;
        }


        public Dado First()
        {
            if (IsEmpty()) return null;
            return Primeiro.Prox;
        }


        public Dado Last()
        {
            if (IsEmpty()) return null;
            return Last(Primeiro.Prox);
        }
        private Dado Last(Dado atual)
        {
            if (atual.Prox == Primeiro) return atual;
            return Last(atual.Prox);
        }


        public void Clear()
        {
            Primeiro.Prox = Primeiro;
            Tamanho = 0;
        }
        public bool IsEmpty()
        {
            if (Primeiro.Prox == Primeiro) return true;
            return false;
        }


        public void Enqueue(Dado dado)
        {
            if (IsEmpty())
            {
                Primeiro.Prox = dado;
                dado.Prox = Primeiro;
                Tamanho++;
            }
            else Enqueue(dado, Primeiro.Prox);
        }
        private void Enqueue(Dado dado, Dado atual)
        {
            if (atual.Prox == Primeiro)
            {
                atual.Prox = dado;
                dado.Prox = Primeiro;
                Tamanho++;
            }
            else Enqueue(dado, atual.Prox);
        }


        public Dado Dequeue()
        {
            if (IsEmpty()) return null;

            Dado dequeue = Primeiro.Prox;
            Primeiro.Prox = dequeue.Prox;
            Tamanho--;

            return dequeue;
        }
        

        public int Size()
        {
            return Tamanho;
        }
    }
}
