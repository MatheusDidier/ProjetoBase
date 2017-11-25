using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DAL
{
    public static class Db
    {

        public const string Versao = "1.0";


        public static string Conexao= @"Data Source=localhost\sqlexpress;
                               Initial Catalog=EmpresaDb;
                               Integrated Security=True;Pooling=False";
    }
}
