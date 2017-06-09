using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacaoForm.ReservaReference;


namespace AplicacaoForm
{
    public partial class CadastrodeReserva : Form
    {
        public CadastrodeReserva()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnGravarReserva_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dateTimePickerInicio.Value;
            DateTime dataFinal = dateTimePickerFinal.Value;

            try
            {
                Reserva obj_reserva = new Reserva();
                obj_reserva.Res_DataReserva = dataInicio.ToShortDateString();
                obj_reserva.Res_DataRetorno = dataFinal.ToShortDateString();
                obj_reserva.Res_Diarias = 0;
                obj_reserva.Res_Horas = 0;
                obj_reserva.Res_CodPlano = 0;
                obj_reserva.Res_Placa = "";
                obj_reserva.Res_PcDesconto = Convert.ToDouble(tbVlTotal.Text);
                obj_reserva.Res_VlDesconto = Convert.ToDouble(tbVlTotal.Text);
                obj_reserva.Res_VlTotal = Convert.ToDouble( tbVlTotal.Text);
                obj_reserva.Cli_Codigo = Convert.ToInt16(tbCliCodigo.Text);
                obj_reserva.Vei_Placa = "PFM8410";

                ReservaWCFClient clienteReserva = new ReservaWCFClient();
                clienteReserva.InsereReserva(obj_reserva);

                MessageBox.Show("Reserva confirmada!");

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro na reserva - " + erro);
            }
            
        }

        private void btnSelCliente_Click(object sender, EventArgs e)
        {
            CadastrodeCliente formcadCli = new CadastrodeCliente();
            formcadCli.ShowDialog(this);
        }
        
        private void tbCPF_Leave(object sender, EventArgs e)
        {
            
            //string pesquisaCPF = tbCPF.Text;
            
            //Cliente obj_cliente = new Cliente();
            //try
            //{
            //    ClienteDB obj_clienteDB = new ClienteDB();
            //    obj_cliente = obj_clienteDB.PesquisarCliente(pesquisaCPF);

            //    tbCliCodigo.Text = obj_cliente.cli_codigo.ToString();
            //    tbLocatario.Text = obj_cliente.cli_nome;
            //    tbEndereco.Text = obj_cliente.cli_endereco;
            //    tbTelefone.Text = obj_cliente.cli_telefone;

            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Erro na alteração" + erro);
            //}
            
        }
    }
}
