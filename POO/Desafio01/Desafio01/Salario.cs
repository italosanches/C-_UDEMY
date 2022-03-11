using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Desafio01
{
    internal class Salario
    {
        public float salario;
        public string nome;
        float media;

        public float CalculoMedia(float salario1,float salario2)
        {
            
            media = (salario1 + salario2) / 2;

            return media;
        }
    }

}
