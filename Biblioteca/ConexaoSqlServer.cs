using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importação do pacote para conexão com o sqlserver
using System.Data.SqlClient;

namespace Biblioteca
{
    public class ConexaoSqlServer
    {
        #region variáveis
        //tipo responsável para se trabalhar com o sqlserver
        public SqlConnection sqlConn;
        //máquina no qual estará o banco de dados
        private const string local = @"BRUNO-VM\SQLEXPRESS";
        //nome do banco de dados no qual desejamos nos comunicar
        private const string banco_de_dados = "LocadoraVeiculos";
        //usuário que tenha os privilégios para utilizar o banco de dados
        private const string usuario = "sa";
        //senha do usuario
        private const string senha = "ts";
        #endregion
        
        //string de conexão obtida para o sql sever
        string connectionStringSqlServer = @"Data Source="+local+";Initial Catalog="+banco_de_dados+";UId="+usuario+";Password="+senha+";";
        #region abertura da conexão
        public void abrirConexao()
        {
            //iniciando uma conexão com o sql server, utilizando os parâmetros da string de conexão
            this.sqlConn = new SqlConnection(connectionStringSqlServer);
            //abrindo a conexão com a base de dados
            this.sqlConn.Open();
        }
        #endregion

        public void fecharConexao()
        {
            //fechando a conexao com a base de dados
            sqlConn.Close();
            //liberando a conexao da memoria
            sqlConn.Dispose();
        }
    }
}
