using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculosWCF
{
    [DataContract]
    public class Reserva
    {
        [DataMember]
        public int Res_Codigo { get; set; }

        [DataMember]
        public string Res_DataReserva { get; set; }

        [DataMember]
        public string Res_DataRetorno { get; set; }

        [DataMember]
        public int Res_Diarias { get; set; }

        [DataMember]
        public int Res_Horas { get; set; }

        [DataMember]
        public int Res_CodPlano { get; set; }

        [DataMember]
        public string Res_Placa { get; set; }

        [DataMember]
        public double Res_PcDesconto { get; set; }

        [DataMember]
        public double Res_VlDesconto { get; set; }

        [DataMember]
        public double Res_VlTotal { get; set; }

        [DataMember]
        public int Cli_Codigo { get; set; }

        [DataMember]
        public string Vei_Placa { get; set; }

    
    }
}
