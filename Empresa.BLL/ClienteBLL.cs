using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Model;
using Empresa.DAL;

namespace Empresa.BLL
{
    public class ClienteBLL
    {
        ClienteDAL dal = new ClienteDAL();

        public void Alterar(Cliente cliente)
        {
            dal.Alterar(cliente);
        }

        public void Excluir(string id)
        {

            dal.Excluir(id);
        }


        

        public void Incluir(Cliente cliente)
        {
           

            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new Exception("O nome do cliente deve ser informado");
            }

            dal.Incluir(cliente);
        }

        public List<Cliente> Listar()
        {
            return dal.Listar();
        }

        public Cliente ObterPorId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("O id deve ser informado");
            }

            return dal.ObterPorId(id);
        }

    }
}
