namespace AplicacaoForm
{
    partial class CadastrodeCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbSexoM = new System.Windows.Forms.RadioButton();
            this.rbSexoF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbRG = new System.Windows.Forms.TextBox();
            this.tbEmissor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPrimeiraHabilitacao = new System.Windows.Forms.MaskedTextBox();
            this.tbValidade = new System.Windows.Forms.MaskedTextBox();
            this.tbExpedicao = new System.Windows.Forms.MaskedTextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbRegistro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.tbCEP = new System.Windows.Forms.MaskedTextBox();
            this.tbDDD = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emissor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento";
            // 
            // rbSexoM
            // 
            this.rbSexoM.AutoSize = true;
            this.rbSexoM.Location = new System.Drawing.Point(13, 15);
            this.rbSexoM.Name = "rbSexoM";
            this.rbSexoM.Size = new System.Drawing.Size(34, 17);
            this.rbSexoM.TabIndex = 5;
            this.rbSexoM.TabStop = true;
            this.rbSexoM.Text = "M";
            this.rbSexoM.UseVisualStyleBackColor = true;
            // 
            // rbSexoF
            // 
            this.rbSexoF.AutoSize = true;
            this.rbSexoF.Location = new System.Drawing.Point(50, 15);
            this.rbSexoF.Name = "rbSexoF";
            this.rbSexoF.Size = new System.Drawing.Size(31, 17);
            this.rbSexoF.TabIndex = 6;
            this.rbSexoF.TabStop = true;
            this.rbSexoF.Text = "F";
            this.rbSexoF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSexoM);
            this.groupBox1.Controls.Add(this.rbSexoF);
            this.groupBox1.Location = new System.Drawing.Point(645, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 38);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(133, 46);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(280, 20);
            this.tbNome.TabIndex = 2;
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(429, 46);
            this.tbRG.MaxLength = 10;
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(94, 20);
            this.tbRG.TabIndex = 3;
            // 
            // tbEmissor
            // 
            this.tbEmissor.Location = new System.Drawing.Point(539, 46);
            this.tbEmissor.MaxLength = 10;
            this.tbEmissor.Name = "tbEmissor";
            this.tbEmissor.Size = new System.Drawing.Size(100, 20);
            this.tbEmissor.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "UF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CEP";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(133, 89);
            this.tbEndereco.MaxLength = 50;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(280, 20);
            this.tbEndereco.TabIndex = 6;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(429, 89);
            this.tbBairro.MaxLength = 30;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(276, 20);
            this.tbBairro.TabIndex = 7;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(27, 134);
            this.tbCidade.MaxLength = 30;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(386, 20);
            this.tbCidade.TabIndex = 8;
            // 
            // tbUF
            // 
            this.tbUF.Location = new System.Drawing.Point(429, 134);
            this.tbUF.MaxLength = 2;
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(34, 20);
            this.tbUF.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPrimeiraHabilitacao);
            this.groupBox2.Controls.Add(this.tbValidade);
            this.groupBox2.Controls.Add(this.tbExpedicao);
            this.groupBox2.Controls.Add(this.tbCategoria);
            this.groupBox2.Controls.Add(this.tbRegistro);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(27, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 86);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habilitação";
            // 
            // tbPrimeiraHabilitacao
            // 
            this.tbPrimeiraHabilitacao.Location = new System.Drawing.Point(528, 45);
            this.tbPrimeiraHabilitacao.Mask = "00/00/0000";
            this.tbPrimeiraHabilitacao.Name = "tbPrimeiraHabilitacao";
            this.tbPrimeiraHabilitacao.Size = new System.Drawing.Size(100, 20);
            this.tbPrimeiraHabilitacao.TabIndex = 20;
            this.tbPrimeiraHabilitacao.ValidatingType = typeof(System.DateTime);
            // 
            // tbValidade
            // 
            this.tbValidade.Location = new System.Drawing.Point(240, 45);
            this.tbValidade.Mask = "00/00/0000";
            this.tbValidade.Name = "tbValidade";
            this.tbValidade.Size = new System.Drawing.Size(100, 20);
            this.tbValidade.TabIndex = 15;
            this.tbValidade.ValidatingType = typeof(System.DateTime);
            // 
            // tbExpedicao
            // 
            this.tbExpedicao.Location = new System.Drawing.Point(383, 45);
            this.tbExpedicao.Mask = "00/00/0000";
            this.tbExpedicao.Name = "tbExpedicao";
            this.tbExpedicao.Size = new System.Drawing.Size(100, 20);
            this.tbExpedicao.TabIndex = 16;
            this.tbExpedicao.ValidatingType = typeof(System.DateTime);
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(161, 45);
            this.tbCategoria.MaxLength = 3;
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(34, 20);
            this.tbCategoria.TabIndex = 14;
            // 
            // tbRegistro
            // 
            this.tbRegistro.Location = new System.Drawing.Point(40, 45);
            this.tbRegistro.MaxLength = 30;
            this.tbRegistro.Name = "tbRegistro";
            this.tbRegistro.Size = new System.Drawing.Size(100, 20);
            this.tbRegistro.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(525, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Data da 1ª Habilitação";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Validade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Expedição";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Categoria";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Regristro";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(27, 285);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(133, 29);
            this.btnGravar.TabIndex = 20;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(564, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "DDD";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(609, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Telefone";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(209, 285);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 29);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(391, 285);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(133, 29);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(573, 285);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(133, 29);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbCPF
            // 
            this.tbCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.tbCPF.Location = new System.Drawing.Point(27, 46);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 20);
            this.tbCPF.TabIndex = 1;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbNascimento
            // 
            this.tbNascimento.Location = new System.Drawing.Point(27, 88);
            this.tbNascimento.Mask = "00/00/0000";
            this.tbNascimento.Name = "tbNascimento";
            this.tbNascimento.Size = new System.Drawing.Size(100, 20);
            this.tbNascimento.TabIndex = 5;
            this.tbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(475, 134);
            this.tbCEP.Mask = "00000-999";
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(68, 20);
            this.tbCEP.TabIndex = 10;
            this.tbCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbDDD
            // 
            this.tbDDD.Location = new System.Drawing.Point(565, 134);
            this.tbDDD.Mask = "(99)";
            this.tbDDD.Name = "tbDDD";
            this.tbDDD.Size = new System.Drawing.Size(35, 20);
            this.tbDDD.TabIndex = 11;
            this.tbDDD.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbTelefone
            // 
            this.tbTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.tbTelefone.Location = new System.Drawing.Point(612, 134);
            this.tbTelefone.Mask = "00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(93, 20);
            this.tbTelefone.TabIndex = 12;
            this.tbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // CadastrodeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 351);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbDDD);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.tbNascimento);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbUF);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmissor);
            this.Controls.Add(this.tbRG);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrodeCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbSexoM;
        private System.Windows.Forms.RadioButton rbSexoF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbRG;
        private System.Windows.Forms.TextBox tbEmissor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbUF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbRegistro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.MaskedTextBox tbNascimento;
        private System.Windows.Forms.MaskedTextBox tbCEP;
        private System.Windows.Forms.MaskedTextBox tbDDD;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.MaskedTextBox tbPrimeiraHabilitacao;
        private System.Windows.Forms.MaskedTextBox tbValidade;
        private System.Windows.Forms.MaskedTextBox tbExpedicao;
    }
}

