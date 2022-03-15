using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_Aluno
{
    internal class Aluno
    {
        public string Name;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal;

        public double NotaFinal2()
        {
            NotaFinal = Nota1 + Nota2 + Nota3;

            return NotaFinal;
        }

    
    }
}
