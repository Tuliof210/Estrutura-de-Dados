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
            if (Marcador.Proximo == Marcador) return true;
            return false;
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
        

        public int Size()
        {
            return Tamanho;
        }
    }
}
