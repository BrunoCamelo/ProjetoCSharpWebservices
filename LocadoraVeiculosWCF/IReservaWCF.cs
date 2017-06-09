using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocadoraVeiculosWCF
{
    [ServiceContract]
    public interface IReservaWCF 
    {

        [OperationContract]
        void InsereReserva(Reserva reservaInsere);


    }

}
