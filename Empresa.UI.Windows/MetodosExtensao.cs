using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Model;

namespace Empresa.UI.Windows
{
    public static class MetodosExtensao
    {

        public static bool Valido(this Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                return false;
            }
            else
            {
                return true;
            }


        }


        public static bool EmailValido(this string texto)
        {
            if (!texto.Contains("@"))
            {
                return false;
            }

            return true;
        }


        public static string PrimeiraLetra(this string texto)
        {
            return texto.Substring(0, 1);
        }

        public static int Dobro(this int valor)
        {
            return valor * 2;
        }


    }
}
