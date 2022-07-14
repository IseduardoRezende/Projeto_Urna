using MySql.Data.MySqlClient;
using Projeto_Urna.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Urna.DAO
{
    class ProfessorDao
    {
        //Criar o objeto para conectar o Banco de Dados
        Conexao objconexao = new Conexao();

        public object inserir(DTOProfessor Professor)
        {
            MySqlConnection conexao = objconexao.GetConnection();
            try
            {
                string insert = "insert into Cad_Professor (Rn,Senha) values (@Rn,@Senha)";

                MySqlCommand cmd = new MySqlCommand(insert, conexao);

                cmd.Parameters.AddWithValue("@Rn", Professor.Rn1);
                cmd.Parameters.AddWithValue("@Senha", Professor.Senha1);
                conexao.Open();

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }

        }

        public bool EfetuaLogin(string rn, string senha, string tipo)
        {
            MySqlConnection conexao = objconexao.GetConnection();
            string sql = null;

            try
            {
                if (tipo.Equals("Professor"))
                {
                     sql = "select * from cad_professor where rn = @rn and senha = @senha";
                }

                else if (tipo.Equals("Aluno"))
                {
                     sql = "select * from cad_aluno where rn = @rn and senha = @senha";
                }


                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@rn", rn);
                cmd.Parameters.AddWithValue("@senha", senha);
               
                conexao.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //Fez o login
                    return true;
                }

                else
                {
                    //nao fez o login
                    return false;
                }
               

            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show("Erro: " + ex);
            }

        }
    }
}
