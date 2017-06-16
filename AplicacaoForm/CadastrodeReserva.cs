using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoForm
{
    public partial class CadastrodeReserva : Form
    {
        public CadastrodeReserva()
        {
            InitializeComponent();

        }

        private void btnGravarReserva_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dateTimePickerInicio.Value;
            DateTime dataFinal = dateTimePickerFinal.Value;
            
            try
            {
                SFLocadora.Reserva obj_reserva = new SFLocadora.Reserva();
                obj_reserva.Res_DataReserva = dataInicio.ToShortDateString();
                obj_reserva.Res_DataRetorno = dataFinal.ToShortDateString();
                obj_reserva.Res_Diarias = 0;
                obj_reserva.Res_Horas = 0;
                obj_reserva.Res_CodPlano = 0;
                obj_reserva.Res_Placa = "";
                obj_reserva.Res_PcDesconto = Convert.ToDouble(tbVlTotal.Text);
                obj_reserva.Res_VlDesconto = Convert.ToDouble(tbVlTotal.Text);
                obj_reserva.Res_VlTotal = Convert.ToDouble(tbVlTotal.Text);
                obj_reserva.Cli_Codigo = Convert.ToInt16(tbCliCodigo.Text);
                obj_reserva.Vei_Placa = "PFM8410";

                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                locadoraClient.InsereReserva(obj_reserva);

                MessageBox.Show("Reserva confirmada!");

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro na reserva - " + erro);
            }
            
        }

        private void btnSelCliente_Click(object sender, EventArgs e)
        {
            string pesquisaCPF = tbCPF.Text;

            SFLocadora.Clientes obj_cliente = new SFLocadora.Clientes();
            try
            {
                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                obj_cliente = locadoraClient.PesquisarCliente(pesquisaCPF);

                tbCliCodigo.Text = obj_cliente.Cli_Codigo.ToString();
                tbLocatario.Text = obj_cliente.Cli_Nome;
                tbEndereco.Text = obj_cliente.Cli_Endereco;
                tbTelefone.Text = obj_cliente.Cli_Telefone;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na pesquisa" + erro);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pesquisaPlaca = tbPlacaVeiculo.Text;
            SFLocadora.Veiculos obj_veiculo = new SFLocadora.Veiculos();
            try
            {
                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                obj_veiculo = locadoraClient.PesquisarVeiculo(pesquisaPlaca);

                tbModelo.Text = obj_veiculo.Vei_Modelo;
                tbAnoFabricacao.Text = obj_veiculo.Vei_AnoFabricacao;
                cbCor.SelectedItem = obj_veiculo.Vei_Cor;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na pesquisa" + erro);
            }

        }

        private void tbQtdDias_TextChanged(object sender, EventArgs e)
        {
            if (tbQtdDias.Text != string.Empty)
            {
               
                double diarias = Convert.ToDouble(tbVlDiaria.Text) * Convert.ToDouble(tbQtdDias.Text);
                tbVlTotal.Text = Convert.ToString(diarias);
            }
        }

        private void tbVlDiaria_Leave(object sender, EventArgs e)
        {
            if (tbQtdDias.Text == string.Empty)
                tbVlTotal.Text = tbVlDiaria.Text;
        }

        private void dateTimePickerFinal_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataIni = dateTimePickerInicio.Value;
            DateTime dataFim = dateTimePickerFinal.Value;

            TimeSpan ts = dataFim - dataIni;

            int dias = ts.Days;

        }
    }
}
