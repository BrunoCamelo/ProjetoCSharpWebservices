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

        
        private void btnGravar_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    string sexo = "";
            //    Cliente obj_cliente = new Cliente();

            //    if (rbSexoM.Checked)
            //        sexo = "M";
            //    else
            //        sexo = "F";
            //    obj_cliente.cli_nome = tbNome.Text;
            //    obj_cliente.cli_cpf = tbCPF.Text;
            //    obj_cliente.cli_rg = tbRG.Text;
            //    obj_cliente.cli_emissor = tbEmissor.Text;
            //    obj_cliente.cli_datanascimento = tbNascimento.Text;
            //    obj_cliente.cli_endereco = tbEndereco.Text;
            //    obj_cliente.cli_bairro = tbBairro.Text;
            //    obj_cliente.cli_cidade = tbCidade.Text;
            //    obj_cliente.cli_uf = tbUF.Text;
            //    obj_cliente.cli_cep = tbCEP.Text;
            //    obj_cliente.cli_telefone = tbTelefone.Text;
            //    obj_cliente.cli_sexo = sexo;
            //    obj_cliente.cli_registrorenach = tbRenach.Text;
            //    obj_cliente.cli_datahabilitacao = tbPrimeiraHabilitacao.Text;
            //    obj_cliente.cli_validade = tbValidade.Text;
            //    obj_cliente.cli_expedicao = tbExpedicao.Text;
            //    obj_cliente.cli_categoria = tbCategoria.Text;

            //    ClienteDB obj_clientedb = new ClienteDB();
            //    obj_clientedb.InsereCliente(obj_cliente);

            //    MessageBox.Show("Cadastrado com sucesso!");

            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Ocorreu o seguite erro no cadastro .: " + erro);
            //}
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            //string pesquisaCPF = tbCPF.Text;
            //Cliente obj_cliente = new Cliente();
            //try
            //{
            //    ClienteDB obj_clienteDB = new ClienteDB();
            //    obj_cliente = obj_clienteDB.PesquisarCliente(pesquisaCPF);

            //    tbNome.Text = obj_cliente.cli_nome;
            //    tbRG.Text = obj_cliente.cli_rg;
            //    tbEmissor.Text = obj_cliente.cli_emissor;
            //    tbNascimento.Text = obj_cliente.cli_datanascimento;
            //    tbEndereco.Text = obj_cliente.cli_endereco;
            //    tbBairro.Text = obj_cliente.cli_bairro;
            //    tbCidade.Text = obj_cliente.cli_cidade;
            //    tbUF.Text = obj_cliente.cli_uf;
            //    tbCEP.Text = obj_cliente.cli_cep;
            //    tbTelefone.Text = obj_cliente.cli_telefone;
            //    if (obj_cliente.cli_sexo == "M")
            //        rbSexoM.Checked = true;
            //    else
            //        rbSexoF.Checked = true;


            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Erro na alteração" + erro);
            //}
            
        }
    }
}
