using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViaCEP
{
    public class ConexaoBD
    {
        // Objeto de conexão SQL:
        public SQLiteConnection conexao;

        // Contrutor de conexão:
        public ConexaoBD()
        {
            // Apontar onde estará nosso arquivo de banco de dados:
            conexao = new SQLiteConnection("Data Source=banco.sqlite3");
            // Verificar se o arquivo banco.sqlite3 NÃO existe:
            if (!File.Exists("./banco.sqlite3"))
            {
                // Criar o arquivo de banco de dados:
                SQLiteConnection.CreateFile("banco.sqlite3");
            }
        }
        // Método para conectar:
        public void Conectar()
        {
            // Verificar se a conexão não está aberta:
            if (conexao.State != ConnectionState.Open)
            {
                // Abrir a conexão:
                conexao.Open();
            }
        }

        // Método para desconectar:
        public void Desconectar()
        {
            // Verificar se a conexão não está fechada:
            if (conexao.State != ConnectionState.Closed)
            {
                // Fechar a conexão:
                conexao.Close();
            }
        }

    }
}
