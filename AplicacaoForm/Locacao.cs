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
    public partial class Locacao : Form
    {
        public Locacao()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DateTime data = dateTimePickerInicio.Value;
            
            MessageBox.Show("Data: " + data.ToShortDateString() + " Hora: "+ data.ToShortTimeString());
        }

    }
}
