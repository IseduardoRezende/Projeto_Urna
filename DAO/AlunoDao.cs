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
    class AlunoDao
    {
        //Criar o objeto para conectar o Banco de Dados
        Conexao objconexao = new Conexao();

        public  object inserir(DTOAluno aluno)
        {

            MySqlConnection conexao = objconexao.GetConnection();
            try
            {
                string insert = "insert into Cad_Aluno (Rn,Modulo,Curso,Turma,Senha) values (@Rn,@Modulo,@Curso,@Turma,@Senha)";

                MySqlCommand cmd = new MySqlCommand(insert, conexao);

                cmd.Parameters.AddWithValue("@Rn", aluno.Rn1);
                cmd.Parameters.AddWithValue("@Modulo", aluno.Modulo1);
                cmd.Parameters.AddWithValue("@Curso", aluno.Curso1);
                cmd.Parameters.AddWithValue("@Turma", aluno.Turma1);
                cmd.Parameters.AddWithValue("@Senha", aluno.Senha1);
                conexao.Open();

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex ;
            }
            finally
            {
                conexao.Close();
            }

        }

    }

    }
