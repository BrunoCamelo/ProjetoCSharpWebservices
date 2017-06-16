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
    public partial class CadastrodeVeiculo : Form
    {
        public CadastrodeVeiculo()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                SFLocadora.Veiculos obj_veiculo = new SFLocadora.Veiculos();
                obj_veiculo.Vei_Placa = tbPlacaVeiculo.Text;
                obj_veiculo.Vei_Modelo = tbModelo.Text;
                obj_veiculo.Vei_Marca = cbMarca.SelectedItem.ToString();
                obj_veiculo.Vei_AnoFabricacao = tbAnoFabricacao.Text;
                obj_veiculo.Vei_AnoModelo = tbAnoModelo.Text;
                obj_veiculo.Vei_UF = tbUFVeiculo.Text;
                obj_veiculo.Vei_Categoria = cbCategoria.SelectedItem.ToString();
                obj_veiculo.Vei_Cor = cbCor.SelectedItem.ToString();
                obj_veiculo.Vei_Cambio = cbCambio.SelectedItem.ToString();
                obj_veiculo.Vei_TipoDirecao = cbDirecao.SelectedItem.ToString();
                obj_veiculo.Vei_Motor = tbMotor.Text;
                obj_veiculo.Vei_Airbags =  cbAirbags.Checked.ToString().Substring(0,1);
                obj_veiculo.Vei_ArCondicionado = cbAr.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_BancoCouro = cbCouro.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_ComputadordeBordo = cbComp.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_ConectividadeInternet = cbInternet.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_FreiosABS = cbAbs.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_NavegadorGPS = cbGps.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_RodaLigaLeve = cbRoda.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_TravaEletrica = cbTrava.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_VidroEletrico = cbVidro.Checked.ToString().Substring(0, 1);
                obj_veiculo.Vei_Descricao = "";

                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                locadoraClient.InsereVeiculo(obj_veiculo);

                MessageBox.Show("Veículo Cadastrado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguite erro no cadastro .: " + erro);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SFLocadora.Veiculos obj_veiculo = new SFLocadora.Veiculos();
            obj_veiculo.Vei_Placa = tbPlacaVeiculo.Text;
            obj_veiculo.Vei_Modelo = tbModelo.Text;
            obj_veiculo.Vei_Marca = cbMarca.SelectedItem.ToString();
            obj_veiculo.Vei_AnoFabricacao = tbAnoFabricacao.Text;
            obj_veiculo.Vei_AnoModelo = tbAnoModelo.Text;
            obj_veiculo.Vei_UF = tbUFVeiculo.Text;
            obj_veiculo.Vei_Categoria = cbCategoria.SelectedItem.ToString();
            obj_veiculo.Vei_Cor = cbCor.SelectedItem.ToString();
            obj_veiculo.Vei_Cambio = cbCambio.SelectedItem.ToString();
            obj_veiculo.Vei_TipoDirecao = cbDirecao.SelectedItem.ToString();
            obj_veiculo.Vei_Motor = tbMotor.Text;
            obj_veiculo.Vei_Airbags = cbAirbags.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_ArCondicionado = cbAr.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_BancoCouro = cbCouro.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_ComputadordeBordo = cbComp.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_ConectividadeInternet = cbInternet.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_FreiosABS = cbAbs.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_NavegadorGPS = cbGps.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_RodaLigaLeve = cbRoda.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_TravaEletrica = cbTrava.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_VidroEletrico = cbVidro.Checked.ToString().Substring(0, 1);
            obj_veiculo.Vei_Descricao = "";

            try
            {
                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                locadoraClient.AlteraVeiculo(obj_veiculo);

                MessageBox.Show("Veículo Alterado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Alteração do veículo: " + erro);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SFLocadora.Veiculos obj_veiculo = new SFLocadora.Veiculos();
            obj_veiculo.Vei_Placa = tbPlacaVeiculo.Text;

            try
            {
                if (MessageBox.Show("Confirma exclusão?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                    locadoraClient.ExcluiVeiculo(obj_veiculo);

                    MessageBox.Show("Veículo Excluído com sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na exclusão de veículo: " + erro);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisaPlaca = tbPlacaVeiculo.Text;
            SFLocadora.Veiculos obj_veiculo = new SFLocadora.Veiculos();
            try
            {
                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                obj_veiculo = locadoraClient.PesquisarVeiculo(pesquisaPlaca);

                tbPlacaVeiculo.Text = obj_veiculo.Vei_Placa;
                tbModelo.Text =obj_veiculo.Vei_Modelo;
                cbMarca.SelectedItem = obj_veiculo.Vei_Marca;
                tbAnoFabricacao.Text = obj_veiculo.Vei_AnoFabricacao;
                tbAnoModelo.Text = obj_veiculo.Vei_AnoModelo;
                tbUFVeiculo.Text = obj_veiculo.Vei_UF;
                cbCategoria.SelectedItem = obj_veiculo.Vei_Categoria;
                cbCor.SelectedItem = obj_veiculo.Vei_Cor;
                cbCambio.SelectedItem = obj_veiculo.Vei_Cambio;
                cbDirecao.SelectedItem = obj_veiculo.Vei_TipoDirecao;
                tbMotor.Text = obj_veiculo.Vei_Motor;
                //cbAirbags.Checked = Boolean.Parse(obj_veiculo.Vei_Airbags);
                //cbAr.Checked = Boolean.Parse(obj_veiculo.Vei_ArCondicionado);
                //obj_veiculo.Vei_BancoCouro = cbCouro.Checked.ToString().Substring(0, 1);
                //obj_veiculo.Vei_ComputadordeBordo = cbComp.Checked.ToString().Substring(0, 1);
                //obj_veiculo.Vei_ConectividadeInternet = cbInternet.Checked.ToString().Substring(0, 1);
                //obj_veiculo.Vei_FreiosABS = cbAbs.Checked.ToString().Substring(0, 1);
                //obj_veiculo.Vei_NavegadorGPS = cbGps.Checked.ToString().Substring(0, 1);
                //obj_veiculo.Vei_RodaLigaLeve = cbRoda.Checked.ToString().Substring(0, 1);
                //obj_veiculo.Vei_TravaEletrica = cbTrava.Checked.ToString().Substring(0, 1);
                //obj_veiculo.Vei_VidroEletrico = cbVidro.Checked.ToString().Substring(0, 1);
                //obj_veiculo.Vei_Descricao = "";


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na pesquisa" + erro);
            }

        }
    }
}
