using System;

namespace Empresa.Model
{
    public class Cliente
    {

        //Construtor
        public Cliente()
        {
            
        }

        //Construtor Sobrecarregado
        public Cliente(string id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }



        public string Versao
        {
            get { return "1.0"; }
        }

               
        private string _email;
        public string Email
        {
            get {
                return _email.ToLower();
            }

            set
            {
                _email = value;
            }
        }


        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Id { get; set; }

        public string Telefone { get; set; }
        public string CPF { get; set; }

       
    }
}
