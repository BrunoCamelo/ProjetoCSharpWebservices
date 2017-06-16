using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculosWCF
{
    [DataContract]
    public class Veiculos
    {
        [DataMember]
        public string Vei_Cor { get; set; }
        [DataMember]
        public string Vei_Cambio { get; set; }
        [DataMember]
        public string Vei_TipoDirecao { get; set; }
        [DataMember]
        public string Vei_Motor { get; set; }
        [DataMember]
        public string Vei_ArCondicionado { get; set; }
        [DataMember]
        public string Vei_VidroEletrico { get; set; }
        [DataMember]
        public string Vei_TravaEletrica { get; set; }
        [DataMember]
        public string Vei_Airbags { get; set; }
        [DataMember]
        public string Vei_NavegadorGPS { get; set; }
        [DataMember]
        public string Vei_FreiosABS { get; set; }
        [DataMember]
        public string Vei_RodaLigaLeve { get; set; }
        [DataMember]
        public string Vei_ConectividadeInternet { get; set; }
        [DataMember]
        public string Vei_ComputadordeBordo { get; set; }
        [DataMember]
        public string Vei_Placa { get; set; }
        [DataMember]
        public string Vei_Modelo { get; set; }
        [DataMember]
        public string Vei_AnoModelo { get; set; }
        [DataMember]
        public string Vei_UF { get; set; }
        [DataMember]
        public string Vei_Marca { get; set; }
        [DataMember]
        public string Vei_Categoria { get; set; }
        [DataMember]
        public string Vei_BancoCouro { get; set; }
        [DataMember]
        public string Vei_AnoFabricacao { get; set; }
        [DataMember]
        public string Vei_Descricao { get; set; }
    }
}
