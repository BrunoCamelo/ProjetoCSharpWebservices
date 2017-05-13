namespace AplicacaoForm
{
    partial class FormPrincipal
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
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.veiculosToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marcasToolStripMenuItem.Text = "Montadoras";
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaToolStripMenuItem,
            this.locaçãoToolStripMenuItem1});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.locaçãoToolStripMenuItem.Text = "Operacional";
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reservaToolStripMenuItem.Text = "Reserva";
            // 
            // locaçãoToolStripMenuItem1
            // 
            this.locaçãoToolStripMenuItem1.Name = "locaçãoToolStripMenuItem1";
            this.locaçãoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.locaçãoToolStripMenuItem1.Text = "Locação";
            // 
            // frotaToolStripMenuItem
            // 
            this.frotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multasToolStripMenuItem,
            this.documentaçãoToolStripMenuItem});
            this.frotaToolStripMenuItem.Name = "frotaToolStripMenuItem";
            this.frotaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.frotaToolStripMenuItem.Text = "Frota";
            // 
            // multasToolStripMenuItem
            // 
            this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
            this.multasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.multasToolStripMenuItem.Text = "Multas";
            // 
            // documentaçãoToolStripMenuItem
            // 
            this.documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            this.documentaçãoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.documentaçãoToolStripMenuItem.Text = "Documentação";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.frotaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(580, 24);
            this.menuPrincipal.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 261);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Loc+ Locadora de Veículos";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaçãoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuPrincipal;


    }
}

