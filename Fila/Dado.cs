namespace Estrutura.Fila
{
    class Dado
    {
        public char Info { get; set; }
        public Dado Prox { get; set; }

        public Dado(char info)
        {
            Info = info;
        }
        public override string ToString()
        {
            return Info.ToString();
        }
    }
}
