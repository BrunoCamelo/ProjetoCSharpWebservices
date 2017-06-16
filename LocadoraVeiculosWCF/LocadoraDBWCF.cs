using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Biblioteca;


namespace LocadoraVeiculosWCF
{
    public class LocadoraDBWCF : ConexaoSqlServer , ILocadoraWCF 
    {

        #region Reserva

        public void InsereReserva(Reserva reservaInsere)
        {
            try
            {
                this.abrirConexao();
                string comandoSql = "INSERT INTO Reserva (Res_DataReserva , Res_DataRetorno, Res_Diarias, Res_Horas, Res_CodPlano, Res_Placa, Res_PcDesconto  " +
                                    " , Res_VlDesconto, Res_VlTotal, Cli_Codigo, Vei_Placa) VALUES (@Res_DataReserva " +
                                    " , @Res_DataRetorno, @Res_Diarias, @Res_Horas, @Res_CodPlano " +
                                    " , @Res_Placa, @Res_PcDesconto, @Res_VlDesconto, @Res_VlTotal, @Cli_Codigo, @Vei_Placa)";
                SqlCommand sql = new SqlCommand(comandoSql, this.sqlConn);
                
                sql.Parameters.AddWithValue("@Res_DataReserva", reservaInsere.Res_DataReserva);
                sql.Parameters.AddWithValue("@Res_DataRetorno", reservaInsere.Res_DataRetorno);
                sql.Parameters.AddWithValue("@Res_Diarias", reservaInsere.Res_Diarias);
                sql.Parameters.AddWithValue("@Res_Horas", reservaInsere.Res_Horas);
                sql.Parameters.AddWithValue("@Res_CodPlano", reservaInsere.Res_CodPlano);
                sql.Parameters.AddWithValue("@Res_Placa", reservaInsere.Res_Placa);
                sql.Parameters.AddWithValue("@Res_PcDesconto", reservaInsere.Res_PcDesconto);
                sql.Parameters.AddWithValue("@Res_VlDesconto", reservaInsere.Res_VlDesconto);
                sql.Parameters.AddWithValue("@Res_VlTotal", reservaInsere.Res_VlTotal);
                sql.Parameters.AddWithValue("@Cli_Codigo", reservaInsere.Cli_Codigo);
                sql.Parameters.AddWithValue("@Vei_Placa", reservaInsere.Vei_Placa);

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

        #endregion

        #region Cadastro de clientes

        public DataTable ListarCliente()
        {
            try
            {
                this.abrirConexao();
                string comandoSql = " SELECT Cli_Codigo,Cli_CPF,Cli_Nome,Cli_Endereco,Cli_Bairro,Cli_Cidade,Cli_UF,Cli_Telefone,Cli_CEP " +
                                    " FROM Cliente ";
                SqlCommand sql = new SqlCommand(comandoSql, this.sqlConn);
                SqlDataAdapter daCliente = new SqlDataAdapter();
                daCliente.SelectCommand = sql;
                DataTable dtCliente = new DataTable();
                daCliente.Fill(dtCliente);

                return dtCliente;
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

        public Clientes PesquisarCliente(string pesquisa)
        {
            try
            {
                this.abrirConexao();
                string comandoSql = " SELECT Cli_Codigo, Cli_Endereco, Cli_RG, Cli_DatadeNascimento, Cli_Sexo, " +
                                    " Cli_Bairro, Cli_Cidade, Cli_UF, Cli_CEP, Cli_RegistroRenach, Cli_CPF, Cli_Nome, " +
                                    " Cli_Telefone, Cli_Emissor, Cli_DataHabilitacao, Cli_Validade, Cli_Expedicao, Cli_Categoria FROM Cliente " +
                                    " WHERE Cli_CPF = '" + pesquisa + "'";
                SqlCommand sql = new SqlCommand(comandoSql, this.sqlConn);
                sql.ExecuteNonQuery();
                SqlDataReader datareader;
                Clientes obj_cliente = new Clientes();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_cliente.Cli_Codigo = Convert.ToInt16(datareader["Cli_Codigo"]);
                    obj_cliente.Cli_Endereco = datareader["Cli_Endereco"].ToString();
                    obj_cliente.Cli_RG = datareader["Cli_RG"].ToString();
                    obj_cliente.Cli_DatadeNascimento = datareader["Cli_DatadeNascimento"].ToString();
                    obj_cliente.Cli_Sexo = datareader["Cli_Sexo"].ToString();
                    obj_cliente.Cli_Bairro = datareader["Cli_Bairro"].ToString();
                    obj_cliente.Cli_Cidade = datareader["Cli_Cidade"].ToString();
                    obj_cliente.Cli_UF = datareader["Cli_UF"].ToString();
                    obj_cliente.Cli_CEP = datareader["Cli_CEP"].ToString();
                    obj_cliente.Cli_RegistroRenach = datareader["Cli_RegistroRenach"].ToString();
                    obj_cliente.Cli_CPF = datareader["Cli_CPF"].ToString();
                    obj_cliente.Cli_Nome = datareader["Cli_Nome"].ToString();
                    obj_cliente.Cli_Telefone = datareader["Cli_Telefone"].ToString();
                    obj_cliente.Cli_Emissor = datareader["Cli_Emissor"].ToString();
                    obj_cliente.Cli_DataHabilitacao = datareader["Cli_DataHabilitacao"].ToString();
                    obj_cliente.Cli_Validade = datareader["Cli_Validade"].ToString();
                    obj_cliente.Cli_Expedicao = datareader["Cli_Expedicao"].ToString();
                    obj_cliente.Cli_Categoria = datareader["Cli_Categoria"].ToString();

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

        public void InsereCliente(Clientes cliente)
        {
            try
            {
                this.abrirConexao();
                SqlCommand sql = new SqlCommand("insert into cliente values (@Cli_Endereco, @Cli_RG, @Cli_DatadeNascimento, @Cli_Sexo, @Cli_Bairro, @Cli_Cidade, @Cli_UF, @Cli_CEP,@Cli_RegistroRenach, @Cli_CPF, @Cli_Nome, @Cli_Telefone, @Cli_Emissor, @Cli_DataHabilitacao, @Cli_Validade, @Cli_Expedicao, @Cli_Categoria)", this.sqlConn);

                sql.Parameters.AddWithValue("@Cli_Nome", cliente.Cli_Nome);
                sql.Parameters.AddWithValue("@Cli_CPF", cliente.Cli_CPF);
                sql.Parameters.AddWithValue("@Cli_RG", cliente.Cli_RG);
                sql.Parameters.AddWithValue("@Cli_Emissor", cliente.Cli_Emissor);
                sql.Parameters.AddWithValue("@Cli_DatadeNascimento", cliente.Cli_DatadeNascimento);
                sql.Parameters.AddWithValue("@Cli_Endereco", cliente.Cli_Endereco);
                sql.Parameters.AddWithValue("@Cli_Sexo", cliente.Cli_Sexo);
                sql.Parameters.AddWithValue("@Cli_Bairro", cliente.Cli_Bairro);
                sql.Parameters.AddWithValue("@Cli_Cidade", cliente.Cli_Cidade);
                sql.Parameters.AddWithValue("@Cli_UF", cliente.Cli_UF);
                sql.Parameters.AddWithValue("@Cli_CEP", cliente.Cli_CEP);
                sql.Parameters.AddWithValue("@Cli_Telefone", cliente.Cli_Telefone);
                sql.Parameters.AddWithValue("@Cli_RegistroRenach", cliente.Cli_RegistroRenach);
                sql.Parameters.AddWithValue("@Cli_DataHabilitacao", cliente.Cli_DataHabilitacao);
                sql.Parameters.AddWithValue("@Cli_Validade", cliente.Cli_Validade);
                sql.Parameters.AddWithValue("@Cli_Expedicao", cliente.Cli_Expedicao);
                sql.Parameters.AddWithValue("@Cli_Categoria", cliente.Cli_Categoria);

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

        public void AlteraCliente(Clientes cliente)
        {
            try
            {
                this.abrirConexao();
                string comandoSql = " UPDATE Cliente  SET Cli_Endereco = @Cli_Endereco ,Cli_RG = @Cli_RG ,Cli_DatadeNascimento = @Cli_DatadeNascimento " +
                                    " ,Cli_Sexo = @Cli_Sexo,Cli_Bairro = @Cli_Bairro,Cli_Cidade = @Cli_Cidade,Cli_UF = @Cli_UF,Cli_CEP = @Cli_CEP " +
                                    " ,Cli_RegistroRenach = @Cli_RegistroRenach,Cli_Nome = @Cli_Nome,Cli_Telefone = @Cli_Telefone " +
                                    " ,Cli_Emissor = @Cli_Emissor ,Cli_DataHabilitacao = @Cli_DataHabilitacao,Cli_Validade = @Cli_Validade " +
                                    " ,Cli_Expedicao = @Cli_Expedicao,Cli_Categoria = @Cli_Categoria " +
                                    " WHERE Cli_CPF = @Cli_CPF";

                SqlCommand sql = new SqlCommand(comandoSql, this.sqlConn);
                sql.Parameters.AddWithValue("@Cli_CPF", cliente.Cli_CPF);
                sql.Parameters.AddWithValue("@Cli_Bairro", cliente.Cli_Bairro);
                sql.Parameters.AddWithValue("@Cli_Categoria", cliente.Cli_Categoria);
                sql.Parameters.AddWithValue("@Cli_CEP", cliente.Cli_CEP);
                sql.Parameters.AddWithValue("@Cli_Cidade", cliente.Cli_Cidade);
                sql.Parameters.AddWithValue("@Cli_DatadeNascimento", cliente.Cli_DatadeNascimento);
                sql.Parameters.AddWithValue("@Cli_DataHabilitacao", cliente.Cli_DataHabilitacao);
                sql.Parameters.AddWithValue("@Cli_Emissor", cliente.Cli_Emissor);
                sql.Parameters.AddWithValue("@Cli_Endereco", cliente.Cli_Endereco);
                sql.Parameters.AddWithValue("@Cli_Expedicao", cliente.Cli_Expedicao);
                sql.Parameters.AddWithValue("@Cli_Nome", cliente.Cli_Nome);
                sql.Parameters.AddWithValue("@Cli_RegistroRenach", cliente.Cli_RegistroRenach);
                sql.Parameters.AddWithValue("@Cli_RG", cliente.Cli_RG);
                sql.Parameters.AddWithValue("@Cli_Sexo", cliente.Cli_Sexo);
                sql.Parameters.AddWithValue("@Cli_Telefone", cliente.Cli_Telefone);
                sql.Parameters.AddWithValue("@Cli_UF", cliente.Cli_UF);
                sql.Parameters.AddWithValue("@Cli_Validade", cliente.Cli_Validade);
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

        public void ExcluiCliente(Clientes cliente)
        {
            try
            {
                this.abrirConexao();
                SqlCommand sql = new SqlCommand("delete from cliente where Cli_CPF = @Cli_CPF", this.sqlConn);
                sql.Parameters.AddWithValue("@Cli_CPF", cliente.Cli_CPF);
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

        #endregion

        #region Cadastro de Veículos

        public Veiculos PesquisarVeiculo(string pesquisa)
        {
            try
            {
                this.abrirConexao();
                string comandoSql = " SELECT Vei_Cor,Vei_Cambio,Vei_TipoDirecao,Vei_Motor,Vei_ArCondicionado,Vei_VidroEletrico " +
                                    " ,Vei_TravaEletrica,Vei_Airbags,Vei_NavegadorGPS,Vei_FreiosABS,Vei_RodaLigaLeve,Vei_ConectividadeInternet,Vei_ComputadordeBordo " +
                                    " ,Vei_Placa,Vei_Modelo,Vei_AnoModelo,Vei_UF,Vei_Marca,Vei_Categoria,Vei_BancoCouro,Vei_AnoFabricacao " +
                                    " ,Vei_Descricao FROM Veiculo " +
                                    " WHERE Vei_Placa = '" + pesquisa + "'";

                SqlCommand sql = new SqlCommand(comandoSql, this.sqlConn);
                sql.ExecuteNonQuery();
                SqlDataReader datareader;
                Veiculos obj_veiculos = new Veiculos();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_veiculos.Vei_Placa = datareader["Vei_Placa"].ToString();
                    obj_veiculos.Vei_Cor = datareader["Vei_Cor"].ToString();
                    obj_veiculos.Vei_Cambio = datareader["Vei_Cambio"].ToString();
                    obj_veiculos.Vei_TipoDirecao = datareader["Vei_TipoDirecao"].ToString();
                    obj_veiculos.Vei_Motor = datareader["Vei_Motor"].ToString();
                    obj_veiculos.Vei_ArCondicionado = datareader["Vei_ArCondicionado"].ToString();
                    obj_veiculos.Vei_VidroEletrico = datareader["Vei_VidroEletrico"].ToString();
                    obj_veiculos.Vei_TravaEletrica = datareader["Vei_TravaEletrica"].ToString();
                    obj_veiculos.Vei_Airbags = datareader["Vei_Airbags"].ToString();
                    obj_veiculos.Vei_NavegadorGPS = datareader["Vei_NavegadorGPS"].ToString();
                    obj_veiculos.Vei_FreiosABS = datareader["Vei_FreiosABS"].ToString();
                    obj_veiculos.Vei_RodaLigaLeve = datareader["Vei_RodaLigaLeve"].ToString();
                    obj_veiculos.Vei_ConectividadeInternet = datareader["Vei_ConectividadeInternet"].ToString();
                    obj_veiculos.Vei_ComputadordeBordo = datareader["Vei_ComputadordeBordo"].ToString();
                    obj_veiculos.Vei_Modelo = datareader["Vei_Modelo"].ToString();
                    obj_veiculos.Vei_AnoModelo = datareader["Vei_AnoModelo"].ToString();
                    obj_veiculos.Vei_UF = datareader["Vei_UF"].ToString();
                    obj_veiculos.Vei_Marca = datareader["Vei_Marca"].ToString();
                    obj_veiculos.Vei_Categoria = datareader["Vei_Categoria"].ToString();
                    obj_veiculos.Vei_BancoCouro = datareader["Vei_BancoCouro"].ToString();
                    obj_veiculos.Vei_AnoFabricacao = datareader["Vei_AnoFabricacao"].ToString();
                    obj_veiculos.Vei_Descricao = datareader["Vei_Descricao"].ToString();

                }
                return obj_veiculos;

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

        public void InsereVeiculo(Veiculos veiculo)
        {
            try
            {
                this.abrirConexao();
                string comandoSql = " INSERT INTO Veiculo VALUES (@Vei_Cor, @Vei_Cambio, @Vei_TipoDirecao, @Vei_Motor, @Vei_ArCondicionado " +
                                  " , @Vei_VidroEletrico, @Vei_TravaEletrica, @Vei_Airbags, @Vei_NavegadorGPS, @Vei_FreiosABS, @Vei_RodaLigaLeve " +
                                  " , @Vei_ConectividadeInternet, @Vei_ComputadordeBordo, @Vei_Placa, @Vei_Modelo, @Vei_AnoModelo, @Vei_UF " +
                                  " , @Vei_Marca, @Vei_Categoria, @Vei_BancoCouro, @Vei_AnoFabricacao, @Vei_Descricao) ";

                SqlCommand sql = new SqlCommand(comandoSql, this.sqlConn);
                sql.Parameters.AddWithValue("@Vei_Cor", veiculo.Vei_Cor );
                sql.Parameters.AddWithValue("@Vei_Cambio", veiculo.Vei_Cambio);
                sql.Parameters.AddWithValue("@Vei_TipoDirecao", veiculo.Vei_TipoDirecao);
                sql.Parameters.AddWithValue("@Vei_Motor",  veiculo.Vei_Motor);
                sql.Parameters.AddWithValue("@Vei_ArCondicionado",  veiculo.Vei_ArCondicionado);
                sql.Parameters.AddWithValue("@Vei_VidroEletrico", veiculo.Vei_VidroEletrico);
                sql.Parameters.AddWithValue("@Vei_TravaEletrica", veiculo.Vei_TravaEletrica);
                sql.Parameters.AddWithValue("@Vei_Airbags", veiculo.Vei_Airbags);
                sql.Parameters.AddWithValue("@Vei_NavegadorGPS", veiculo.Vei_NavegadorGPS);
                sql.Parameters.AddWithValue("@Vei_FreiosABS",veiculo.Vei_FreiosABS);
                sql.Parameters.AddWithValue("@Vei_RodaLigaLeve", veiculo.Vei_RodaLigaLeve);
                sql.Parameters.AddWithValue("@Vei_ConectividadeInternet", veiculo.Vei_ConectividadeInternet);
                sql.Parameters.AddWithValue("@Vei_ComputadordeBordo", veiculo.Vei_ComputadordeBordo);
                sql.Parameters.AddWithValue("@Vei_Placa", veiculo.Vei_Placa);
                sql.Parameters.AddWithValue("@Vei_Modelo", veiculo.Vei_Modelo);
                sql.Parameters.AddWithValue("@Vei_AnoModelo", veiculo.Vei_AnoModelo);
                sql.Parameters.AddWithValue("@Vei_UF", veiculo.Vei_UF);
                sql.Parameters.AddWithValue("@Vei_Marca", veiculo.Vei_Marca);
                sql.Parameters.AddWithValue("@Vei_Categoria", veiculo.Vei_Categoria);
                sql.Parameters.AddWithValue("@Vei_BancoCouro", veiculo.Vei_BancoCouro);
                sql.Parameters.AddWithValue("@Vei_AnoFabricacao", veiculo.Vei_AnoFabricacao);
                sql.Parameters.AddWithValue("@Vei_Descricao", veiculo.Vei_Descricao);

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

        public void AlteraVeiculo(Veiculos veiculo)
        {
            try
            {
                this.abrirConexao();
                string comandoSql = " UPDATE Veiculo SET Vei_Cor = @Vei_Cor,Vei_Cambio = @Vei_Cambio,Vei_TipoDirecao = @Vei_TipoDirecao " +
                                    " ,Vei_Motor = @Vei_Motor,Vei_ArCondicionado = @Vei_ArCondicionado,Vei_VidroEletrico = @Vei_VidroEletrico " +
                                    " ,Vei_TravaEletrica = @Vei_TravaEletrica,Vei_Airbags = @Vei_Airbags,Vei_NavegadorGPS = @Vei_NavegadorGPS " +
                                    " ,Vei_FreiosABS = @Vei_FreiosABS,Vei_RodaLigaLeve = @Vei_RodaLigaLeve,Vei_ConectividadeInternet = @Vei_ConectividadeInternet " +
                                    " ,Vei_ComputadordeBordo = @Vei_ComputadordeBordo,Vei_Placa = @Vei_Placa,Vei_Modelo = @Vei_Modelo,Vei_AnoModelo = @Vei_AnoModelo " +
                                    " ,Vei_UF = @Vei_UF,Vei_Marca = @Vei_Marca,Vei_Categoria = @Vei_Categoria,Vei_BancoCouro = @Vei_BancoCouro,Vei_AnoFabricacao = @Vei_AnoFabricacao " +
                                    " ,Vei_Descricao = @Vei_Descricao WHERE Vei_Placa = @Vei_Placa ";

                SqlCommand sql = new SqlCommand(comandoSql, this.sqlConn);
                sql.Parameters.AddWithValue("@Vei_Cor", veiculo.Vei_Cor);
                sql.Parameters.AddWithValue("@Vei_Cambio", veiculo.Vei_Cambio);
                sql.Parameters.AddWithValue("@Vei_TipoDirecao", veiculo.Vei_TipoDirecao);
                sql.Parameters.AddWithValue("@Vei_Motor", veiculo.Vei_Motor);
                sql.Parameters.AddWithValue("@Vei_ArCondicionado", veiculo.Vei_ArCondicionado);
                sql.Parameters.AddWithValue("@Vei_VidroEletrico", veiculo.Vei_VidroEletrico);
                sql.Parameters.AddWithValue("@Vei_TravaEletrica", veiculo.Vei_TravaEletrica);
                sql.Parameters.AddWithValue("@Vei_Airbags", veiculo.Vei_Airbags);
                sql.Parameters.AddWithValue("@Vei_NavegadorGPS", veiculo.Vei_NavegadorGPS);
                sql.Parameters.AddWithValue("@Vei_FreiosABS", veiculo.Vei_FreiosABS);
                sql.Parameters.AddWithValue("@Vei_RodaLigaLeve", veiculo.Vei_RodaLigaLeve);
                sql.Parameters.AddWithValue("@Vei_ConectividadeInternet", veiculo.Vei_ConectividadeInternet);
                sql.Parameters.AddWithValue("@Vei_ComputadordeBordo", veiculo.Vei_ComputadordeBordo);
                sql.Parameters.AddWithValue("@Vei_Placa", veiculo.Vei_Placa);
                sql.Parameters.AddWithValue("@Vei_Modelo", veiculo.Vei_Modelo);
                sql.Parameters.AddWithValue("@Vei_AnoModelo", veiculo.Vei_AnoModelo);
                sql.Parameters.AddWithValue("@Vei_UF", veiculo.Vei_UF);
                sql.Parameters.AddWithValue("@Vei_Marca", veiculo.Vei_Marca);
                sql.Parameters.AddWithValue("@Vei_Categoria", veiculo.Vei_Categoria);
                sql.Parameters.AddWithValue("@Vei_BancoCouro", veiculo.Vei_BancoCouro);
                sql.Parameters.AddWithValue("@Vei_AnoFabricacao", veiculo.Vei_AnoFabricacao);
                sql.Parameters.AddWithValue("@Vei_Descricao", veiculo.Vei_Descricao);

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

        public void ExcluiVeiculo(Veiculos veiculo)
        {
            try
            {
                this.abrirConexao();
                SqlCommand sql = new SqlCommand("delete from veiculo where Vei_Placa = @Vei_Placa ", this.sqlConn);
                sql.Parameters.AddWithValue("@Vei_Placa", veiculo.Vei_Placa);
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




        #endregion


    }
}
