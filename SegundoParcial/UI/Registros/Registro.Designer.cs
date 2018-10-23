namespace SegundoParcial.UI.Registros
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            this.vendedorIDLabel = new System.Windows.Forms.Label();
            this.nombresLabel = new System.Windows.Forms.Label();
            this.sueldoLabel = new System.Windows.Forms.Label();
            this.retencionCalculoLabel = new System.Windows.Forms.Label();
            this.retencionPorcentajeLabel = new System.Windows.Forms.Label();
            this.vendedorIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.sueldoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.retencionCalculoTextBox = new System.Windows.Forms.TextBox();
            this.RetencionPorcentajeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.AddButtonClick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CuotatextBox = new System.Windows.Forms.TextBox();
            this.MetasButtonClick = new System.Windows.Forms.Button();
            this.MetascomboBox1 = new System.Windows.Forms.ComboBox();
            this.RemoverFilarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionPorcentajeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendedorIDLabel
            // 
            this.vendedorIDLabel.AutoSize = true;
            this.vendedorIDLabel.Location = new System.Drawing.Point(3, 64);
            this.vendedorIDLabel.Name = "vendedorIDLabel";
            this.vendedorIDLabel.Size = new System.Drawing.Size(89, 17);
            this.vendedorIDLabel.TabIndex = 16;
            this.vendedorIDLabel.Text = "vendedor ID:";
            // 
            // nombresLabel
            // 
            this.nombresLabel.AutoSize = true;
            this.nombresLabel.Location = new System.Drawing.Point(3, 90);
            this.nombresLabel.Name = "nombresLabel";
            this.nombresLabel.Size = new System.Drawing.Size(69, 17);
            this.nombresLabel.TabIndex = 18;
            this.nombresLabel.Text = "Nombres:";
            // 
            // sueldoLabel
            // 
            this.sueldoLabel.AutoSize = true;
            this.sueldoLabel.Location = new System.Drawing.Point(3, 127);
            this.sueldoLabel.Name = "sueldoLabel";
            this.sueldoLabel.Size = new System.Drawing.Size(56, 17);
            this.sueldoLabel.TabIndex = 19;
            this.sueldoLabel.Text = "Sueldo:";
            // 
            // retencionCalculoLabel
            // 
            this.retencionCalculoLabel.AutoSize = true;
            this.retencionCalculoLabel.Location = new System.Drawing.Point(3, 167);
            this.retencionCalculoLabel.Name = "retencionCalculoLabel";
            this.retencionCalculoLabel.Size = new System.Drawing.Size(135, 17);
            this.retencionCalculoLabel.TabIndex = 20;
            this.retencionCalculoLabel.Text = "Retencion A Pagar: ";
            // 
            // retencionPorcentajeLabel
            // 
            this.retencionPorcentajeLabel.AutoSize = true;
            this.retencionPorcentajeLabel.Location = new System.Drawing.Point(250, 127);
            this.retencionPorcentajeLabel.Name = "retencionPorcentajeLabel";
            this.retencionPorcentajeLabel.Size = new System.Drawing.Size(148, 17);
            this.retencionPorcentajeLabel.TabIndex = 21;
            this.retencionPorcentajeLabel.Text = "Retencion Porcentaje:";
            // 
            // vendedorIDNumericUpDown
            // 
            this.vendedorIDNumericUpDown.Location = new System.Drawing.Point(110, 59);
            this.vendedorIDNumericUpDown.Name = "vendedorIDNumericUpDown";
            this.vendedorIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.vendedorIDNumericUpDown.TabIndex = 17;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(110, 87);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(252, 22);
            this.NombresTextBox.TabIndex = 19;
            this.NombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombresTextBox_KeyPress);
            // 
            // sueldoNumericUpDown
            // 
            this.sueldoNumericUpDown.DecimalPlaces = 2;
            this.sueldoNumericUpDown.Location = new System.Drawing.Point(110, 125);
            this.sueldoNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.sueldoNumericUpDown.Name = "sueldoNumericUpDown";
            this.sueldoNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.sueldoNumericUpDown.TabIndex = 20;
            this.sueldoNumericUpDown.ValueChanged += new System.EventHandler(this.SueldoNumericUpDown_ValueChanged);
            // 
            // retencionCalculoTextBox
            // 
            this.retencionCalculoTextBox.Location = new System.Drawing.Point(144, 164);
            this.retencionCalculoTextBox.MaxLength = 10;
            this.retencionCalculoTextBox.Name = "retencionCalculoTextBox";
            this.retencionCalculoTextBox.ReadOnly = true;
            this.retencionCalculoTextBox.Size = new System.Drawing.Size(100, 22);
            this.retencionCalculoTextBox.TabIndex = 21;
            // 
            // RetencionPorcentajeNumericUpDown
            // 
            this.RetencionPorcentajeNumericUpDown.DecimalPlaces = 2;
            this.RetencionPorcentajeNumericUpDown.Location = new System.Drawing.Point(253, 164);
            this.RetencionPorcentajeNumericUpDown.Name = "RetencionPorcentajeNumericUpDown";
            this.RetencionPorcentajeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.RetencionPorcentajeNumericUpDown.TabIndex = 22;
            this.RetencionPorcentajeNumericUpDown.ValueChanged += new System.EventHandler(this.RetencionPorcentajeNumericUpDown_ValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::SegundoParcial.Properties.Resources.if_cross_24_103181;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(253, 518);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 62);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::SegundoParcial.Properties.Resources.if_floppy_disk_save_103863;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(137, 518);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 62);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::SegundoParcial.Properties.Resources.if_new10_216291;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(21, 519);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 61);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::SegundoParcial.Properties.Resources.if_search_126577;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(244, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(86, 58);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha";
            // 
            // FechaDataTimePicker
            // 
            this.FechaDataTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDataTimePicker.Location = new System.Drawing.Point(110, 200);
            this.FechaDataTimePicker.Name = "FechaDataTimePicker";
            this.FechaDataTimePicker.Size = new System.Drawing.Size(123, 22);
            this.FechaDataTimePicker.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Controls.Add(this.AddButtonClick);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CuotatextBox);
            this.groupBox1.Controls.Add(this.MetasButtonClick);
            this.groupBox1.Controls.Add(this.MetascomboBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 285);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metas";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(8, 52);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.RowTemplate.Height = 24;
            this.DetalledataGridView.Size = new System.Drawing.Size(381, 199);
            this.DetalledataGridView.TabIndex = 5;
            // 
            // AddButtonClick
            // 
            this.AddButtonClick.Location = new System.Drawing.Point(336, 18);
            this.AddButtonClick.Name = "AddButtonClick";
            this.AddButtonClick.Size = new System.Drawing.Size(53, 23);
            this.AddButtonClick.TabIndex = 4;
            this.AddButtonClick.Text = "Add";
            this.AddButtonClick.UseVisualStyleBackColor = true;
            this.AddButtonClick.Click += new System.EventHandler(this.AddButtonClick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuota";
            // 
            // CuotatextBox
            // 
            this.CuotatextBox.Location = new System.Drawing.Point(230, 19);
            this.CuotatextBox.Name = "CuotatextBox";
            this.CuotatextBox.Size = new System.Drawing.Size(100, 22);
            this.CuotatextBox.TabIndex = 2;
            // 
            // MetasButtonClick
            // 
            this.MetasButtonClick.Location = new System.Drawing.Point(135, 22);
            this.MetasButtonClick.Name = "MetasButtonClick";
            this.MetasButtonClick.Size = new System.Drawing.Size(30, 23);
            this.MetasButtonClick.TabIndex = 1;
            this.MetasButtonClick.Text = "+";
            this.MetasButtonClick.UseVisualStyleBackColor = true;
            this.MetasButtonClick.Click += new System.EventHandler(this.MetasButtonClick_Click);
            // 
            // MetascomboBox1
            // 
            this.MetascomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetascomboBox1.FormattingEnabled = true;
            this.MetascomboBox1.Location = new System.Drawing.Point(8, 21);
            this.MetascomboBox1.Name = "MetascomboBox1";
            this.MetascomboBox1.Size = new System.Drawing.Size(121, 24);
            this.MetascomboBox1.TabIndex = 0;
            // 
            // RemoverFilarButton
            // 
            this.RemoverFilarButton.Location = new System.Drawing.Point(17, 485);
            this.RemoverFilarButton.Name = "RemoverFilarButton";
            this.RemoverFilarButton.Size = new System.Drawing.Size(139, 27);
            this.RemoverFilarButton.TabIndex = 26;
            this.RemoverFilarButton.Text = "Remover Fila";
            this.RemoverFilarButton.UseVisualStyleBackColor = true;
            this.RemoverFilarButton.Click += new System.EventHandler(this.RemoverFilarButton_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 592);
            this.Controls.Add(this.RemoverFilarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaDataTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retencionPorcentajeLabel);
            this.Controls.Add(this.RetencionPorcentajeNumericUpDown);
            this.Controls.Add(this.retencionCalculoLabel);
            this.Controls.Add(this.retencionCalculoTextBox);
            this.Controls.Add(this.sueldoLabel);
            this.Controls.Add(this.sueldoNumericUpDown);
            this.Controls.Add(this.nombresLabel);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.vendedorIDLabel);
            this.Controls.Add(this.vendedorIDNumericUpDown);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionPorcentajeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown vendedorIDNumericUpDown;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.NumericUpDown sueldoNumericUpDown;
        private System.Windows.Forms.TextBox retencionCalculoTextBox;
        private System.Windows.Forms.NumericUpDown RetencionPorcentajeNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker FechaDataTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vendedorIDLabel;
        private System.Windows.Forms.Label nombresLabel;
        private System.Windows.Forms.Label sueldoLabel;
        private System.Windows.Forms.Label retencionCalculoLabel;
        private System.Windows.Forms.Label retencionPorcentajeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MetasButtonClick;
        private System.Windows.Forms.ComboBox MetascomboBox1;
        private System.Windows.Forms.TextBox CuotatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButtonClick;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button RemoverFilarButton;
    }
}