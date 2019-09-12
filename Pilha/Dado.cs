namespace Estrutura.Pilha
{
    class Dado
    {
        public int Info { get; set; }
        public Dado Prox { get; set; }

        public Dado(int info)
        {
            Info = info;
        }
        public override string ToString()
        {
            return Info.ToString();
        }
    }
}
