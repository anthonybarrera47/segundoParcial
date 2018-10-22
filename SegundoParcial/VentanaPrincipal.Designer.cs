namespace SegundoParcial
{
    partial class VentanaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroVendedorToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroVendedorToolStripMenuItem
            // 
            this.registroVendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVendedorToolStripMenuItem});
            this.registroVendedorToolStripMenuItem.Name = "registroVendedorToolStripMenuItem";
            this.registroVendedorToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.registroVendedorToolStripMenuItem.Text = "Registro Vendedor";
            // 
            // registrarVendedorToolStripMenuItem
            // 
            this.registrarVendedorToolStripMenuItem.Checked = true;
            this.registrarVendedorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.registrarVendedorToolStripMenuItem.Name = "registrarVendedorToolStripMenuItem";
            this.registrarVendedorToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.registrarVendedorToolStripMenuItem.Text = "Registrar Vendedor";
            this.registrarVendedorToolStripMenuItem.Click += new System.EventHandler(this.RegistrarVendedorToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaVendedoresToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultaVendedoresToolStripMenuItem
            // 
            this.consultaVendedoresToolStripMenuItem.Name = "consultaVendedoresToolStripMenuItem";
            this.consultaVendedoresToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.consultaVendedoresToolStripMenuItem.Text = "Consulta Vendedores";
            this.consultaVendedoresToolStripMenuItem.Click += new System.EventHandler(this.ConsultaVendedoresToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "Segundo Parcial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaVendedoresToolStripMenuItem;
    }
}

