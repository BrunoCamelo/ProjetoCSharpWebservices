using Biblioteca;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSqlServer conn = new ConexaoSqlServer();
                conn.abrirConexao();
                conn.fecharConexao();
                MessageBox.Show("Conexão bem coisada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno()
                {
                    Matricula = 1,
                    Nome = "Melo Semi Deus"
                };
                new AlunoBDSqlServerParametros().Insert(a);
                MessageBox.Show("Aluno cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //string caminho = @"C:\Unibratec\3 - DSD";

            //Uri url = new Uri(@""+textBox1.Text);
            //webBrowser1.Url = url;
        }

      
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro formCadastro = new Cadastro();
            formCadastro.Show();
        }

      }
}
