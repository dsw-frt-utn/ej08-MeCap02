using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Methods
{
    internal class Problema4
    {

        public double CalcularPromedio(int? nota1 = null, int? nota2 = null, int? nota3 = null)
        {
            int? Verificar(int? aux)
            {
                if ((aux < 0) || (aux > 10))
                {
                    aux = 0;
                }
                return aux;
            }

            nota1 = Verificar(nota1);
            nota2 = Verificar(nota2);
            nota3 = Verificar(nota3);

            return (nota1 ?? 0 + nota2 ?? 0 + nota3 ?? 0) / 3;
        }
    }
}
