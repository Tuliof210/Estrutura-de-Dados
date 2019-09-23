/*
 * Utilizado um modelo de lista duplamente encadeada
*/
namespace Estrutura.Lista
{
    class Lista
    {
        public Flag Marcador { get; set; }
        public int Tamanho { get; private set; }

        public Lista()
        {
            Marcador = new Flag();
            Marcador.Proximo = Marcador;
            Marcador.Anterior = Marcador;
        }


        public Dado First()
        {
            if (IsEmpty()) return null;
            return Marcador.Proximo;
        }
        public Dado Last()
        {
            if (IsEmpty()) return null;
            return Marcador.Anterior;
        }


        public void Clear()
        {
            Marcador.Proximo = Marcador;
            Marcador.Anterior = Marcador;
            Tamanho = 0;
        }
        public bool IsEmpty()
        {
            return Marcador.Proximo == Marcador;
        }

        
        public void Add(Dado dado)
        {
            if (IsEmpty())
            {
                Marcador.Proximo = dado;
                Marcador.Anterior = dado;
                dado.Proximo = Marcador;
                dado.Anterior = Marcador;

                Tamanho++;
            }
            else Add(dado, Marcador.Proximo);
        }
        private void Add(Dado dado, Dado atual)
        {
            if (atual.Proximo == Marcador)
            {
                atual.Proximo = dado;
                dado.Proximo = Marcador;
                dado.Anterior = atual;
                Marcador.Anterior = dado;

                Tamanho++;
            }
            else Add(dado, atual.Proximo);
        }


        public Dado Remove()
        {
            if (IsEmpty()) return null;

            Dado remove = Marcador.Anterior;
            Marcador.Anterior = remove.Anterior;
            Marcador.Anterior.Proximo = Marcador;

            remove.Proximo = null;
            remove.Anterior = null;

            Tamanho--;

            return remove;
        }


        public Dado Find(char info)
        {
            if (IsEmpty()) return null;
            if (Marcador.Proximo.Info == info) return Marcador.Proximo;
            return Find(info, Marcador.Proximo);
        }
        private Dado Find(char info, Dado atual)
        {
            if (atual.Proximo == Marcador) return null;
            if (atual.Proximo.Info == info) return atual.Proximo;
            return Find(info, atual.Proximo);
        }


        public int Size()
        {
            return Tamanho;
        }
    }
}
