
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

      
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrodeCliente formcadCli = new CadastrodeCliente();
            formcadCli.ShowDialog(this);
        }

        private void locaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Locacao formlocacao = new Locacao();
            formlocacao.ShowDialog(this);
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CadastrodeReserva formreserva = new CadastrodeReserva();
            formreserva.ShowDialog(this);
        }
    }
}
