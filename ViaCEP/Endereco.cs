using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViaCEP
{
    internal class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

        public DataTable Listar()
        {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();

            // Instanciar e conectar ao banco:
            ConexaoBD banco = new ConexaoBD();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM enderecos";

            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);

            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);

            // Desconectar:
            banco.Desconectar();

            return tabela;
        }

        public DataTable Verificar()
        {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();

            // Instanciar e conectar ao banco:
            ConexaoBD banco = new ConexaoBD();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM enderecos WHERE cep =" + cep;

            
            //            NÃO FUNCIONOU           
            //cmd.Parameters.AddWithValue("@Cep", cep);
            //cmd.Parameters.Add(new SQLiteParameter("@Cep", cep));

            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);

            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);

            // Desconectar:
            banco.Desconectar();

            return tabela;
        }

        public bool Favoritar()
        {
            ConexaoBD banco = new ConexaoBD();

            if (logradouro == "" && uf == "" && ddd == "")
            {
                MessageBox.Show("Não foram encontrados valores", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            // Definir qual comando DML (Insert - Delete - Update) será executado:
            cmd.CommandText = "INSERT INTO enderecos (cep, logradouro, bairro, ddd, localidade, complemento, uf) " +
                              "VALUES (@Cep, @Logradouro, @Bairro, @Ddd, @Localidade, @Complemento, @Uf)";

            // Substituir parâmetros da query:
            cmd.Parameters.AddWithValue("@Cep", cep);
            cmd.Parameters.AddWithValue("@Logradouro", logradouro);
            cmd.Parameters.AddWithValue("@Bairro", bairro);
            cmd.Parameters.AddWithValue("@Ddd", ddd);
            cmd.Parameters.AddWithValue("@Localidade", localidade);
            cmd.Parameters.AddWithValue("@Complemento", complemento);
            cmd.Parameters.AddWithValue("@Uf", uf);

            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();

            return true;
        }

        public bool RemoverSelecionado()
        {
            ConexaoBD banco = new ConexaoBD();

            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            // Definir qual comando DML (Insert - Delete - Update) será executado:
            cmd.CommandText = "DELETE FROM enderecos WHERE cep = @Cep";

            // Substituir parâmetros da query:
            cmd.Parameters.AddWithValue("@Cep", cep);

            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();

            return true;
        }

        public bool RemoverTudo()
        {
            ConexaoBD banco = new ConexaoBD();

            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            // Definir qual comando DML (Insert - Delete - Update) será executado:
            cmd.CommandText = "DELETE FROM enderecos";

            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();

            return true;
        }
    }
}
