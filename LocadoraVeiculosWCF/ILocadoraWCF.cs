using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocadoraVeiculosWCF
{
    [ServiceContract]
    public interface ILocadoraWCF 
    {

        #region Reserva
        [OperationContract]
        void InsereReserva(Reserva reservaInsere);

        #endregion
        

        #region Cadastro de Clientes
        [OperationContract]
        Clientes PesquisarCliente(string pesquisa);

        [OperationContract]
        DataTable ListarCliente();

        [OperationContract]
        void InsereCliente(Clientes cliente);

        [OperationContract]
        void AlteraCliente(Clientes cliente);

        [OperationContract]
        void ExcluiCliente(Clientes cliente);

        #endregion


        #region Cadastro de Veículos

        [OperationContract]
        Veiculos PesquisarVeiculo(string pesquisa);

        [OperationContract]
        void InsereVeiculo(Veiculos veiculo);

        [OperationContract]
        void AlteraVeiculo(Veiculos veiculo);

        [OperationContract]
        void ExcluiVeiculo(Veiculos veiculo);


        #endregion
    }

}
