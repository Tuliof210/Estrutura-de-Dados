using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
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
