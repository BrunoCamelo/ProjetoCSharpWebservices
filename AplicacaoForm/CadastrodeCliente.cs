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
    public partial class CadastrodeCliente : Form
    {
        public CadastrodeCliente()
        {
            InitializeComponent();
        }

        public string Sexo()
        {
            string sexo = "";

            if (rbSexoM.Checked)
                sexo = "M";
            else
                sexo = "F";

            return sexo;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
                SFLocadora.Clientes obj_cliente = new SFLocadora.Clientes();
                obj_cliente.Cli_Nome = tbNome.Text;
                obj_cliente.Cli_CPF = tbCPF.Text;
                obj_cliente.Cli_RG = tbRG.Text;
                obj_cliente.Cli_Emissor = tbEmissor.Text;
                obj_cliente.Cli_DatadeNascimento = tbNascimento.Text;
                obj_cliente.Cli_Endereco = tbEndereco.Text;
                obj_cliente.Cli_Bairro = tbBairro.Text;
                obj_cliente.Cli_Cidade = tbCidade.Text;
                obj_cliente.Cli_UF = tbUF.Text;
                obj_cliente.Cli_CEP = tbCEP.Text;
                obj_cliente.Cli_Telefone = tbTelefone.Text;
                obj_cliente.Cli_Sexo = Sexo();
                obj_cliente.Cli_RegistroRenach = tbRegistro.Text;
                obj_cliente.Cli_DataHabilitacao = tbPrimeiraHabilitacao.Text;
                obj_cliente.Cli_Validade = tbValidade.Text;
                obj_cliente.Cli_Expedicao = tbExpedicao.Text;
                obj_cliente.Cli_Categoria = tbCategoria.Text;

                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                locadoraClient.InsereCliente(obj_cliente);

                MessageBox.Show("Cliente Cadastrado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguite erro no cadastro .: " + erro);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SFLocadora.Clientes obj_cliente = new SFLocadora.Clientes();
            obj_cliente.Cli_CPF = tbCPF.Text;
            obj_cliente.Cli_Categoria = tbCategoria.Text;
            obj_cliente.Cli_Bairro = tbBairro.Text;
            obj_cliente.Cli_CEP = tbCEP.Text;
            obj_cliente.Cli_Cidade = tbCidade.Text;
            obj_cliente.Cli_DatadeNascimento = tbNascimento.Text;
            obj_cliente.Cli_DataHabilitacao = tbPrimeiraHabilitacao.Text;
            obj_cliente.Cli_Emissor = tbEmissor.Text;
            obj_cliente.Cli_Endereco = tbEndereco.Text;
            obj_cliente.Cli_Expedicao = tbExpedicao.Text;
            obj_cliente.Cli_Nome = tbNome.Text;
            obj_cliente.Cli_RegistroRenach = tbRegistro.Text;
            obj_cliente.Cli_RG = tbRG.Text;
            obj_cliente.Cli_Sexo = Sexo();
            obj_cliente.Cli_Telefone = tbTelefone.Text;
            obj_cliente.Cli_UF = tbUF.Text;
            obj_cliente.Cli_Validade = tbValidade.Text;

            try
            {
                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                locadoraClient.AlteraCliente(obj_cliente);

                MessageBox.Show("Cliente Alterado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Alteração do cliente: " + erro);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SFLocadora.Clientes obj_cliente = new SFLocadora.Clientes();
            obj_cliente.Cli_CPF = tbCPF.Text;
            
            try
            {
                if (MessageBox.Show("Confirma exclusão?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                    locadoraClient.ExcluiCliente(obj_cliente);

                    MessageBox.Show("Cliente Excluído com sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na exclusão de cliente: " + erro);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string pesquisaCPF = tbCPF.Text;
            SFLocadora.Clientes obj_cliente = new SFLocadora.Clientes();
            try
            {
                SFLocadora.LocadoraWCFClient locadoraClient = new SFLocadora.LocadoraWCFClient();
                obj_cliente = locadoraClient.PesquisarCliente(pesquisaCPF);
                
                tbNome.Text = obj_cliente.Cli_Nome;
                tbRG.Text = obj_cliente.Cli_RG;
                tbEmissor.Text = obj_cliente.Cli_Emissor;
                tbNascimento.Text = obj_cliente.Cli_DatadeNascimento;
                tbEndereco.Text = obj_cliente.Cli_Endereco;
                tbBairro.Text = obj_cliente.Cli_Bairro;
                tbCidade.Text = obj_cliente.Cli_Cidade;
                tbUF.Text = obj_cliente.Cli_UF;
                tbCEP.Text = obj_cliente.Cli_CEP;
                tbTelefone.Text = obj_cliente.Cli_Telefone;
                tbPrimeiraHabilitacao.Text = obj_cliente.Cli_DataHabilitacao;
                tbRegistro.Text = obj_cliente.Cli_RegistroRenach;
                tbExpedicao.Text = obj_cliente.Cli_Expedicao;
                tbValidade.Text = obj_cliente.Cli_Validade;
                tbCategoria.Text = obj_cliente.Cli_Categoria;

                if (obj_cliente.Cli_Sexo == "M")
                    rbSexoM.Checked = true;
                else
                    rbSexoF.Checked = true;

                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na pesquisa" + erro);
            }

        }
    }
}
