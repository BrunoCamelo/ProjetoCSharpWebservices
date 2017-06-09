using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Biblioteca
{
    public class ClienteDB : ConexaoSqlServer, ClienteInterface
    {
        
        public Cliente PesquisarCliente(string pesquisa)
        {
            try { 
                this.abrirConexao();
                string comandoSql = " SELECT Cli_Codigo, Cli_Endereco, Cli_RG, Cli_DatadeNascimento, Cli_Sexo, " +
                                    " Cli_Bairro, Cli_Cidade, Cli_UF, Cli_CEP, Cli_RegistroRenach, Cli_CPF, Cli_Nome, " +
                                    " Cli_Telefone, Cli_Emissor, Cli_DataHabilitacao, Cli_Validade, Cli_Expedicao, Cli_Categoria FROM Cliente " +
                                    " WHERE Cli_CPF = '" + pesquisa + "'";
                SqlCommand sql = new SqlCommand(comandoSql, this.sqlConn);
                sql.ExecuteNonQuery();
                SqlDataReader datareader;
                Cliente obj_cliente = new Cliente();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_cliente.cli_codigo = Convert.ToInt16(datareader["Cli_Codigo"]);
                    obj_cliente.cli_endereco = datareader["Cli_Endereco"].ToString();
                    obj_cliente.cli_rg = datareader["Cli_RG"].ToString();
                    obj_cliente.cli_datanascimento = datareader["Cli_DatadeNascimento"].ToString();
                    obj_cliente.cli_sexo = datareader["Cli_Sexo"].ToString();
                    obj_cliente.cli_bairro = datareader["Cli_Bairro"].ToString();
                    obj_cliente.cli_cidade = datareader["Cli_Cidade"].ToString();
                    obj_cliente.cli_uf = datareader["Cli_UF"].ToString();
                    obj_cliente.cli_cep = datareader["Cli_CEP"].ToString();
                    obj_cliente.cli_registrorenach = datareader["Cli_RegistroRenach"].ToString();
                    obj_cliente.cli_cpf = datareader["Cli_CPF"].ToString();
                    obj_cliente.cli_nome = datareader["Cli_Nome"].ToString();
                    obj_cliente.cli_telefone = datareader["Cli_Telefone"].ToString();
                    obj_cliente.cli_emissor = datareader["Cli_Emissor"].ToString();
                    obj_cliente.cli_datahabilitacao = datareader["Cli_DataHabilitacao"].ToString();
                    obj_cliente.cli_validade = datareader["Cli_Validade"].ToString();
                    obj_cliente.cli_expedicao = datareader["Cli_Expedicao"].ToString();
                    obj_cliente.cli_categoria = datareader["Cli_Categoria"].ToString();

                }
                return obj_cliente;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                fecharConexao();
            }

        }

        public void InsereCliente(Cliente cliente)
        {

            try
            {
                this.abrirConexao();
                SqlCommand sql = new SqlCommand("insert into cliente values (@Cli_Endereco, @Cli_RG, @Cli_DatadeNascimento, @Cli_Sexo, @Cli_Bairro, @Cli_Cidade, @Cli_UF, @Cli_CEP,@Cli_RegistroRenach, @Cli_CPF, @Cli_Nome, @Cli_Telefone, @Cli_Emissor, @Cli_DataHabilitacao, @Cli_Validade, @Cli_Expedicao, @Cli_Categoria)", this.sqlConn);

                sql.Parameters.AddWithValue("@Cli_Nome", cliente.cli_nome);
                sql.Parameters.AddWithValue("@Cli_CPF", cliente.cli_cpf);
                sql.Parameters.AddWithValue("@Cli_RG", cliente.cli_rg);
                sql.Parameters.AddWithValue("@Cli_Emissor", cliente.cli_emissor);
                sql.Parameters.AddWithValue("@Cli_DatadeNascimento", cliente.cli_datanascimento);
                sql.Parameters.AddWithValue("@Cli_Endereco", cliente.cli_endereco);
                sql.Parameters.AddWithValue("@Cli_Sexo", cliente.cli_sexo);
                sql.Parameters.AddWithValue("@Cli_Bairro", cliente.cli_bairro);
                sql.Parameters.AddWithValue("@Cli_Cidade", cliente.cli_cidade);
                sql.Parameters.AddWithValue("@Cli_UF", cliente.cli_uf);
                sql.Parameters.AddWithValue("@Cli_CEP", cliente.cli_cep);
                sql.Parameters.AddWithValue("@Cli_Telefone", cliente.cli_telefone);
                sql.Parameters.AddWithValue("@Cli_RegistroRenach", cliente.cli_registrorenach);
                sql.Parameters.AddWithValue("@Cli_DataHabilitacao", cliente.cli_datahabilitacao); 
                sql.Parameters.AddWithValue("@Cli_Validade", cliente.cli_validade);
                sql.Parameters.AddWithValue("@Cli_Expedicao", cliente.cli_expedicao);
                sql.Parameters.AddWithValue("@Cli_Categoria", cliente.cli_categoria);
                
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                fecharConexao();
            }

        }
    }
}
