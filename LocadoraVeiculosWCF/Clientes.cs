using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculosWCF
{
    [DataContract]
    public class Clientes
    {
        [DataMember]
        public int Cli_Codigo { get; set; }
        [DataMember]
        public string Cli_Endereco { get; set; }
        [DataMember]
        public string Cli_RG { get; set; }
        [DataMember]
        public string Cli_DatadeNascimento { get; set; }
        [DataMember]
        public string Cli_Sexo { get; set; }
        [DataMember]
        public string Cli_Bairro { get; set; }
        [DataMember]
        public string Cli_Cidade { get; set; }
        [DataMember]
        public string Cli_UF { get; set; }
        [DataMember]
        public string Cli_CEP { get; set; }
        [DataMember]
        public string Cli_RegistroRenach { get; set; }
        [DataMember]
        public string Cli_CPF { get; set; }
        [DataMember]
        public string Cli_Nome { get; set; }
        [DataMember]
        public string Cli_Telefone { get; set; }
        [DataMember]
        public string Cli_Emissor { get; set; }
        [DataMember]
        public string Cli_DataHabilitacao { get; set; }
        [DataMember]
        public string Cli_Validade { get; set; }
        [DataMember]
        public string Cli_Expedicao { get; set; }
        [DataMember]
        public string Cli_Categoria { get; set; }
        
    }
}
