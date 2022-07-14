using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Urna.DAO
{
    class Conexao
    {
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection("user id= root;" +
                "password='root';server=localhost;port=3306;database=Urna;SslMode=none");

        }
    }
}
