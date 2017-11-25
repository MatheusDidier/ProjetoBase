using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Model
{
    public class Fabricante
    {
        public Fabricante(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }


        public string Nome { get; private set; }
        public string Email { get; private set; }


    }
}
