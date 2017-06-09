using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace LocadoraVeiculosWCF
{
    public class ReservaWCF : IReservaWCF
    {

        string conexao_sql = @"Data Source=.\SQLEXPRESS;Initial Catalog=LocadoraVeiculos;UId=sa;Password=ts;";
        SqlConnection conexao = null;

        public void abrirConexao()
        {
            conexao = new SqlConnection(conexao_sql);
            conexao.Open();
        }

        public void fecharConexao()
        {
            conexao.Close();
            conexao.Dispose();
        }

        public void InsereReserva(Reserva reservaInsere)
        {
            try
            {
                abrirConexao();
                string comandoSql = "INSERT INTO Reserva (Res_DataReserva , Res_DataRetorno, Res_Diarias, Res_Horas, Res_CodPlano, Res_Placa, Res_PcDesconto  " +
                                    " , Res_VlDesconto, Res_VlTotal, Cli_Codigo, Vei_Placa) VALUES (@Res_DataReserva " +
                                    " , @Res_DataRetorno, @Res_Diarias, @Res_Horas, @Res_CodPlano " +
                                    " , @Res_Placa, @Res_PcDesconto, @Res_VlDesconto, @Res_VlTotal, @Cli_Codigo, @Vei_Placa)";
                SqlCommand sql = new SqlCommand(comandoSql, conexao);

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


    }
}
