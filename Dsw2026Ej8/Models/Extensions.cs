using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Models
{
    public static class Extensions
    {
        public static string ToProductCode(this string? code)
        {
            string newCode = "";
            if(code is null)
            {
                newCode = "SIN-CODIGO";
            }
            else
            {
                foreach (char aux in code.ToUpper())
                {
                    if (aux == ' ')
                    {
                        newCode += '-';
                    }
                    else
                    {
                        newCode += aux;
                    }
                }
            }
            return newCode;
        }
    }
}
