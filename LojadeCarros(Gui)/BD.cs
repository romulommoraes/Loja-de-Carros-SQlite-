using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace ClasseCarro
{
    public class BD
    {
        private static SQLiteConnection conexao; //cria a variavel pra conexao com o SQlite 

        private static SQLiteConnection ConexaoBd()//método pra criar a conexão com o banco e retorna a variável conexao
        {
            string filepathRaiz = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            //MessageBox.Show($"{filepathRaiz}");
            conexao = new SQLiteConnection(@$"Data Source={filepathRaiz}\bd\bdLoja.db");
            conexao.Open();
            return conexao;
        }
        
        public static DataTable CarregarCarros()
        {
            SQLiteDataAdapter da = null; //data adapter que vai receber os dados do Banco
            DataTable dt = new DataTable();// data table que vai servir pra transferir os dados do banco pra criar os objetos pra minhaLoja.ListaCarros
            try
            {
                var vcon = ConexaoBd();//variavel com o caminho pra conexao com o bd
                var cmd = vcon.CreateCommand();//variavel com os comandos a serem realizados
                cmd.CommandText = "SELECT * FROM listaCarros";//comando especifico de cada função
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);//carrega o data adapter com os dados do banco
                da.Fill(dt); //transfere os dados pra um datatable
                vcon.Close();//fecha a conexão

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                throw;
            }
           
        }

        public static DataTable BuscarCarros(string a, string c)//busca carros no bd usando Marca ou Modelo (variavel a)
        {
            SQLiteDataAdapter da = null; //data adapter que vai receber os dados do Banco
            DataTable dt = new DataTable();// data table que vai servir pra transferir os dados do banco pra criar os objetos pra minhaLoja.ListaCarros
            try
            {
                var vcon = ConexaoBd();//variavel com o caminho pra conexao com o bd
                var cmd = vcon.CreateCommand();//variavel com os comandos a serem realizados
                cmd.CommandText = "SELECT * FROM listaCarros WHERE "+a+" LIKE'"+c+"%'";//comando especifico de cada função
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);//carrega o data adapter com os dados do banco
                da.Fill(dt); //transfere os dados pra um datatable
                vcon.Close();//fecha a conexão
                
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                throw;
            }

        }

        public static void novoCarro (Carro c)

        {
            var vcon = ConexaoBd();
            var cmd = vcon.CreateCommand();
            try //adiciona os itens nas caixas de texto ao banco de dados
            {
                cmd.CommandText = "INSERT INTO listaCarros (T_MARCA, T_MODELO, N_PRECO, N_ANO, N_ESTADO, N_PORTAS, N_QTD, N_CODIGO) VALUES (@marca, @modelo, @preço, @ano, @estado, @portas, @qtd, @codigo)";
                cmd.Parameters.AddWithValue("@marca", c.Marca);
                cmd.Parameters.AddWithValue("@modelo", c.Modelo);
                cmd.Parameters.AddWithValue("@preço", c.Preço);
                cmd.Parameters.AddWithValue("@ano", c.Ano);
                cmd.Parameters.AddWithValue("@estado", c.Estado);
                cmd.Parameters.AddWithValue("@portas", c.Portas.ToString());
                cmd.Parameters.AddWithValue("@qtd", c.Qtd);
                cmd.Parameters.AddWithValue("@codigo", int.Parse(c.Codigo));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item adicionado com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                vcon.Close();
            }
        }

        public static void deletarCarro(string cdgo)

        {
            var vcon = ConexaoBd();
            var cmd = vcon.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM listaCarros WHERE N_CODIGO=" + cdgo; 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item excluido com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                vcon.Close();
            }
        }

        public static void atualizarCarro(Carro c)

        {
            var vcon = ConexaoBd();
            var cmd = vcon.CreateCommand();
            try
            { 
                cmd.CommandText = "UPDATE listaCarros SET T_MARCA='"+c.Marca+"', T_MODELO= '"+c.Modelo+"', N_PRECO="+c.Preço+", N_ANO="+c.Ano+", N_ESTADO='"+c.Estado+"', N_PORTAS='"+c.Portas+"', N_QTD="+c.Qtd+", N_CODIGO='"+c.Codigo+"' WHERE N_CODIGO="+c.Codigo;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item atualizado com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                vcon.Close();
            }
        }  

    }    

}

