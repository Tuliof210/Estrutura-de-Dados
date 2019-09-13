namespace Estrutura.Lista
{
    class Dado
    {
        public char Info { get; set; }
        public Dado Proximo { get; set; }
        public Dado Anterior { get; set; }

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
