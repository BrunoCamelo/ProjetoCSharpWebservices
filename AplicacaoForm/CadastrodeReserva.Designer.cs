namespace AplicacaoForm
{
    partial class CadastrodeReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGravarReserva = new System.Windows.Forms.Button();
            this.groupBox3Veículo = new System.Windows.Forms.GroupBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbKmdia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.btnSelecionaVeiculo = new System.Windows.Forms.Button();
            this.cbPlano = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVlTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbVlDiaria = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbQtdDias = new System.Windows.Forms.TextBox();
            this.tbAnoFabricacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2Período = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1Locatário = new System.Windows.Forms.GroupBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLocatario = new System.Windows.Forms.TextBox();
            this.btnSelCliente = new System.Windows.Forms.Button();
            this.tbCliCodigo = new System.Windows.Forms.TextBox();
            this.groupBox3Veículo.SuspendLayout();
            this.groupBox2Período.SuspendLayout();
            this.groupBox1Locatário.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravarReserva
            // 
            this.btnGravarReserva.Location = new System.Drawing.Point(12, 409);
            this.btnGravarReserva.Name = "btnGravarReserva";
            this.btnGravarReserva.Size = new System.Drawing.Size(168, 23);
            this.btnGravarReserva.TabIndex = 9;
            this.btnGravarReserva.Text = "Gravar Reserva";
            this.btnGravarReserva.UseVisualStyleBackColor = true;
            this.btnGravarReserva.Click += new System.EventHandler(this.btnGravarReserva_Click);
            // 
            // groupBox3Veículo
            // 
            this.groupBox3Veículo.Controls.Add(this.cbCor);
            this.groupBox3Veículo.Controls.Add(this.label11);
            this.groupBox3Veículo.Controls.Add(this.tbKmdia);
            this.groupBox3Veículo.Controls.Add(this.label1);
            this.groupBox3Veículo.Controls.Add(this.tbPlacaVeiculo);
            this.groupBox3Veículo.Controls.Add(this.btnSelecionaVeiculo);
            this.groupBox3Veículo.Controls.Add(this.cbPlano);
            this.groupBox3Veículo.Controls.Add(this.label17);
            this.groupBox3Veículo.Controls.Add(this.label2);
            this.groupBox3Veículo.Controls.Add(this.tbVlTotal);
            this.groupBox3Veículo.Controls.Add(this.label14);
            this.groupBox3Veículo.Controls.Add(this.label13);
            this.groupBox3Veículo.Controls.Add(this.tbVlDiaria);
            this.groupBox3Veículo.Controls.Add(this.label12);
            this.groupBox3Veículo.Controls.Add(this.label9);
            this.groupBox3Veículo.Controls.Add(this.tbQtdDias);
            this.groupBox3Veículo.Controls.Add(this.tbAnoFabricacao);
            this.groupBox3Veículo.Controls.Add(this.label8);
            this.groupBox3Veículo.Controls.Add(this.tbModelo);
            this.groupBox3Veículo.Controls.Add(this.label7);
            this.groupBox3Veículo.Location = new System.Drawing.Point(12, 202);
            this.groupBox3Veículo.Name = "groupBox3Veículo";
            this.groupBox3Veículo.Size = new System.Drawing.Size(658, 190);
            this.groupBox3Veículo.TabIndex = 8;
            this.groupBox3Veículo.TabStop = false;
            this.groupBox3Veículo.Text = "Veículo";
            // 
            // cbCor
            // 
            this.cbCor.Enabled = false;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Prata",
            "Preto ",
            "Branco",
            "Azul",
            "Verde",
            "Amarelo",
            "Violeta",
            "Cinza",
            "Vermelho"});
            this.cbCor.Location = new System.Drawing.Point(392, 67);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(133, 21);
            this.cbCor.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Km/Dia";
            // 
            // tbKmdia
            // 
            this.tbKmdia.Location = new System.Drawing.Point(176, 115);
            this.tbKmdia.Name = "tbKmdia";
            this.tbKmdia.Size = new System.Drawing.Size(100, 20);
            this.tbKmdia.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ano";
            // 
            // tbPlacaVeiculo
            // 
            this.tbPlacaVeiculo.Location = new System.Drawing.Point(25, 68);
            this.tbPlacaVeiculo.Name = "tbPlacaVeiculo";
            this.tbPlacaVeiculo.Size = new System.Drawing.Size(121, 20);
            this.tbPlacaVeiculo.TabIndex = 10;
            // 
            // btnSelecionaVeiculo
            // 
            this.btnSelecionaVeiculo.Location = new System.Drawing.Point(24, 23);
            this.btnSelecionaVeiculo.Name = "btnSelecionaVeiculo";
            this.btnSelecionaVeiculo.Size = new System.Drawing.Size(112, 23);
            this.btnSelecionaVeiculo.TabIndex = 28;
            this.btnSelecionaVeiculo.Text = "Selecionar Veículo";
            this.btnSelecionaVeiculo.UseVisualStyleBackColor = true;
            this.btnSelecionaVeiculo.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbPlano
            // 
            this.cbPlano.FormattingEnabled = true;
            this.cbPlano.Items.AddRange(new object[] {
            "KM Livre"});
            this.cbPlano.Location = new System.Drawing.Point(25, 115);
            this.cbPlano.Name = "cbPlano";
            this.cbPlano.Size = new System.Drawing.Size(121, 21);
            this.cbPlano.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Formato de Plano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cor";
            // 
            // tbVlTotal
            // 
            this.tbVlTotal.Location = new System.Drawing.Point(227, 163);
            this.tbVlTotal.Name = "tbVlTotal";
            this.tbVlTotal.Size = new System.Drawing.Size(100, 20);
            this.tbVlTotal.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "=";
            // 
            // tbVlDiaria
            // 
            this.tbVlDiaria.Location = new System.Drawing.Point(24, 163);
            this.tbVlDiaria.Name = "tbVlDiaria";
            this.tbVlDiaria.Size = new System.Drawing.Size(100, 20);
            this.tbVlDiaria.TabIndex = 13;
            this.tbVlDiaria.Leave += new System.EventHandler(this.tbVlDiaria_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Valor Diária";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "X";
            // 
            // tbQtdDias
            // 
            this.tbQtdDias.Location = new System.Drawing.Point(152, 163);
            this.tbQtdDias.Name = "tbQtdDias";
            this.tbQtdDias.Size = new System.Drawing.Size(30, 20);
            this.tbQtdDias.TabIndex = 14;
            this.tbQtdDias.TextChanged += new System.EventHandler(this.tbQtdDias_TextChanged);
            // 
            // tbAnoFabricacao
            // 
            this.tbAnoFabricacao.Enabled = false;
            this.tbAnoFabricacao.Location = new System.Drawing.Point(540, 68);
            this.tbAnoFabricacao.Name = "tbAnoFabricacao";
            this.tbAnoFabricacao.Size = new System.Drawing.Size(100, 20);
            this.tbAnoFabricacao.TabIndex = 9;
            this.tbAnoFabricacao.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Placa";
            // 
            // tbModelo
            // 
            this.tbModelo.Enabled = false;
            this.tbModelo.Location = new System.Drawing.Point(176, 68);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(202, 20);
            this.tbModelo.TabIndex = 7;
            this.tbModelo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Modelo";
            // 
            // groupBox2Período
            // 
            this.groupBox2Período.Controls.Add(this.dateTimePickerFinal);
            this.groupBox2Período.Controls.Add(this.label5);
            this.groupBox2Período.Controls.Add(this.dateTimePickerInicio);
            this.groupBox2Período.Controls.Add(this.label4);
            this.groupBox2Período.Location = new System.Drawing.Point(692, 24);
            this.groupBox2Período.Name = "groupBox2Período";
            this.groupBox2Período.Size = new System.Drawing.Size(155, 122);
            this.groupBox2Período.TabIndex = 7;
            this.groupBox2Período.TabStop = false;
            this.groupBox2Período.Text = "Período da Reserva";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(19, 91);
            this.dateTimePickerFinal.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerFinal.TabIndex = 4;
            this.dateTimePickerFinal.ValueChanged += new System.EventHandler(this.dateTimePickerFinal_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Final";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(19, 45);
            this.dateTimePickerInicio.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerInicio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Início";
            // 
            // groupBox1Locatário
            // 
            this.groupBox1Locatário.Controls.Add(this.tbTelefone);
            this.groupBox1Locatário.Controls.Add(this.tbCPF);
            this.groupBox1Locatário.Controls.Add(this.label15);
            this.groupBox1Locatário.Controls.Add(this.tbEndereco);
            this.groupBox1Locatário.Controls.Add(this.label3);
            this.groupBox1Locatário.Controls.Add(this.label6);
            this.groupBox1Locatário.Controls.Add(this.label10);
            this.groupBox1Locatário.Controls.Add(this.tbLocatario);
            this.groupBox1Locatário.Controls.Add(this.btnSelCliente);
            this.groupBox1Locatário.Location = new System.Drawing.Point(12, 24);
            this.groupBox1Locatário.Name = "groupBox1Locatário";
            this.groupBox1Locatário.Size = new System.Drawing.Size(658, 172);
            this.groupBox1Locatário.TabIndex = 6;
            this.groupBox1Locatário.TabStop = false;
            this.groupBox1Locatário.Text = "Locatário";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Enabled = false;
            this.tbTelefone.Location = new System.Drawing.Point(530, 125);
            this.tbTelefone.Mask = "00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 20);
            this.tbTelefone.TabIndex = 6;
            this.tbTelefone.TabStop = false;
            this.tbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(25, 80);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(93, 20);
            this.tbCPF.TabIndex = 1;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(144, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Nome";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Location = new System.Drawing.Point(24, 125);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(483, 20);
            this.tbEndereco.TabIndex = 5;
            this.tbEndereco.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "CPF:";
            // 
            // tbLocatario
            // 
            this.tbLocatario.Enabled = false;
            this.tbLocatario.Location = new System.Drawing.Point(147, 80);
            this.tbLocatario.Name = "tbLocatario";
            this.tbLocatario.Size = new System.Drawing.Size(483, 20);
            this.tbLocatario.TabIndex = 2;
            this.tbLocatario.TabStop = false;
            // 
            // btnSelCliente
            // 
            this.btnSelCliente.Location = new System.Drawing.Point(24, 29);
            this.btnSelCliente.Name = "btnSelCliente";
            this.btnSelCliente.Size = new System.Drawing.Size(112, 23);
            this.btnSelCliente.TabIndex = 0;
            this.btnSelCliente.Text = "Selecionar Cliente";
            this.btnSelCliente.UseVisualStyleBackColor = true;
            this.btnSelCliente.Click += new System.EventHandler(this.btnSelCliente_Click);
            // 
            // tbCliCodigo
            // 
            this.tbCliCodigo.Location = new System.Drawing.Point(692, 152);
            this.tbCliCodigo.Name = "tbCliCodigo";
            this.tbCliCodigo.Size = new System.Drawing.Size(31, 20);
            this.tbCliCodigo.TabIndex = 10;
            this.tbCliCodigo.Visible = false;
            // 
            // CadastrodeReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 449);
            this.Controls.Add(this.tbCliCodigo);
            this.Controls.Add(this.btnGravarReserva);
            this.Controls.Add(this.groupBox3Veículo);
            this.Controls.Add(this.groupBox2Período);
            this.Controls.Add(this.groupBox1Locatário);
            this.Name = "CadastrodeReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.groupBox3Veículo.ResumeLayout(false);
            this.groupBox3Veículo.PerformLayout();
            this.groupBox2Período.ResumeLayout(false);
            this.groupBox2Período.PerformLayout();
            this.groupBox1Locatário.ResumeLayout(false);
            this.groupBox1Locatário.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravarReserva;
        private System.Windows.Forms.GroupBox groupBox3Veículo;
        private System.Windows.Forms.TextBox tbVlTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbVlDiaria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbQtdDias;
        private System.Windows.Forms.TextBox tbAnoFabricacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2Período;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1Locatário;
        private System.Windows.Forms.TextBox tbLocatario;
        private System.Windows.Forms.Button btnSelCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPlano;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbKmdia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlacaVeiculo;
        private System.Windows.Forms.Button btnSelecionaVeiculo;
        private System.Windows.Forms.TextBox tbCliCodigo;
        private System.Windows.Forms.ComboBox cbCor;
    }
}