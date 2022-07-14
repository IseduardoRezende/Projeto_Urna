using MySql.Data.MySqlClient;
using Projeto_Urna.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Urna.DAO
{
    class VotacaoDao
    {
        //Criar o objeto para conectar o Banco de Dados
        Conexao objconexao = new Conexao();

        public object inserir(DTOVotacao Votacao)
        {
            MySqlConnection conexao = objconexao.GetConnection();
            try
            {
                string insert = "insert into Votacao(nomechapa) values (@nomechapa)";


                MySqlCommand cmd = new MySqlCommand(insert, conexao);

                cmd.Parameters.AddWithValue("nomechapa", Votacao.Nomechapa); 
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

        public DataTable listaResultados()
        {
            MySqlConnection conexao = objconexao.GetConnection();
            try
            {
                DataTable tabelavocao = new DataTable();
                string sql = "select * from votacao";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
               
                conexao.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(tabelavocao);

                conexao.Close();

                return tabelavocao;
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

      


      //  public string RetornaQtdVotos(string nomechapa)
        //{
          //  MySqlConnection conexao = objconexao.GetConnection();
            //try
            //{
              //  string select = "select count(id) as 'Qtd_Votos' from votacao where nomechapa = @Nomechapa;";
                                
            
                //MySqlCommand cmd = new MySqlCommand(select, conexao);

                //cmd.Parameters.AddWithValue("@Nomechapa",nomechapa);

                //conexao.Open();
 
    //               MySqlDataReader reader = cmd.ExecuteReader();

    //              string qtd = reader.GetString("Qtd_Votos");


                //return qtd;
            //}
            //catch (Exception ex)
            //{
              //  throw ex;
            //}
            //finally
            //{
              //  conexao.Close();
            //}
        //}

    }
}

