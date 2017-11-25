using System;
using System.Collections.Generic;
using Empresa.Model;
using System.Data.SqlClient;

namespace Empresa.DAL
{
    public class ClienteDAL
    {
        

        public void Incluir(Cliente cliente)
        {
            string sql = @"INSERT INTO Cliente(Id,Nome,Email,Telefone,CPF)
                        values (@Id,@Nome,@Email,@Telefone,@CPF)";

            var cn = new SqlConnection();
            cn.ConnectionString = Db.Conexao;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Cpf", cliente.CPF);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Alterar(Cliente cliente)
        {
            string sql = @"UPDATE Cliente
                           SET Nome=@Nome,Email=@Email,
                               Telefone=@telefone, CPF=@CPF
                           WHERE Id=@ID";
                        

            var cn = new SqlConnection();
            cn.ConnectionString = Db.Conexao;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Cpf", cliente.CPF);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }


        public void Excluir(Cliente cli)
        {
            Excluir(cli.Id);
        }

        public void Excluir(string id, string nome)
        {
            if (!string.IsNullOrEmpty(id))
            {
                Excluir(id);
            }
            else
            {

            }
           
        }


        public void Excluir(string Id)
        {
            string sql = @"DELETE FROM Cliente
                           WHERE Id=@Id";


            var cn = new SqlConnection();

            

            cn.ConnectionString = Db.Conexao;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Id", Id);
            
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public List<Cliente> Listar()
        {
            


            string sql = @"SELECT Id,Nome,Email,Telefone,CPF 
                         FROM Cliente";

            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            

            cn.Open();
            var reader = cmd.ExecuteReader();

            var lista = new List<Cliente>();

            while (reader.Read())
            {
                var cliente = new Cliente(reader["Id"].ToString(), reader["Nome"].ToString());
                //cliente.Id = 
                //cliente.Nome = 
                cliente.Telefone = reader["Telefone"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.CPF = reader["CPF"].ToString();

                lista.Add(cliente);
            }

            reader.Close();
            cn.Close();


            return lista;
        }

        public Cliente ObterPorId(string id)
        {
            string sql = @"SELECT Id,Nome,Email,Telefone,CPF 
                         FROM Cliente
                         WHERE id=@id";

            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);

            cn.Open();
            var reader = cmd.ExecuteReader();

            Cliente cliente = null;

            if (reader.Read())
            {
                cliente = new Cliente(reader["Id"].ToString(), reader["Nome"].ToString());
                
                cliente.Telefone = reader["Telefone"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.CPF = reader["CPF"].ToString();
            }

            reader.Close();
            cn.Close();    


            return cliente;
        }

        
    }
}
