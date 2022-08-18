namespace Login
{
    partial class Consumos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consumos));
            this.dglistaConsumos = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesAño_Consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdConsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Export_Button = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.editar_Button = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dglistaConsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // dglistaConsumos
            // 
            this.dglistaConsumos.AllowUserToAddRows = false;
            this.dglistaConsumos.AllowUserToDeleteRows = false;
            this.dglistaConsumos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dglistaConsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglistaConsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dglistaConsumos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dglistaConsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dglistaConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglistaConsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.MesAño_Consumo,
            this.Consumo,
            this.Valor_Total,
            this.Observaciones,
            this.Direccion,
            this.Ciudad,
            this.Departamento,
            this.IdConsumo,
            this.Estrato,
            this.Impreso,
            this.CodigoPredio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dglistaConsumos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dglistaConsumos.Location = new System.Drawing.Point(0, 40);
            this.dglistaConsumos.Name = "dglistaConsumos";
            this.dglistaConsumos.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dglistaConsumos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dglistaConsumos.RowTemplate.Height = 100;
            this.dglistaConsumos.Size = new System.Drawing.Size(1366, 691);
            this.dglistaConsumos.TabIndex = 29;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 56.27266F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // MesAño_Consumo
            // 
            this.MesAño_Consumo.DataPropertyName = "MesAño_Consumo";
            this.MesAño_Consumo.FillWeight = 56.27266F;
            this.MesAño_Consumo.HeaderText = "Fecha";
            this.MesAño_Consumo.Name = "MesAño_Consumo";
            this.MesAño_Consumo.ReadOnly = true;
            // 
            // Consumo
            // 
            this.Consumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Consumo.DataPropertyName = "Consumo";
            this.Consumo.FillWeight = 56.27266F;
            this.Consumo.HeaderText = "Consumo";
            this.Consumo.Name = "Consumo";
            this.Consumo.ReadOnly = true;
            // 
            // Valor_Total
            // 
            this.Valor_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Valor_Total.DataPropertyName = "Valor_Total";
            this.Valor_Total.FillWeight = 406.0914F;
            this.Valor_Total.HeaderText = "Valor";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            this.Valor_Total.Width = 75;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.FillWeight = 56.27266F;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.FillWeight = 56.27266F;
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ciudad.DataPropertyName = "Ciudad";
            this.Ciudad.FillWeight = 56.27266F;
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 150;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.FillWeight = 56.27266F;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // IdConsumo
            // 
            this.IdConsumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdConsumo.DataPropertyName = "IdConsumo";
            this.IdConsumo.FillWeight = 30.23038F;
            this.IdConsumo.HeaderText = "Id Consumo";
            this.IdConsumo.Name = "IdConsumo";
            this.IdConsumo.ReadOnly = true;
            this.IdConsumo.Visible = false;
            this.IdConsumo.Width = 60;
            // 
            // Estrato
            // 
            this.Estrato.DataPropertyName = "Estrato";
            this.Estrato.HeaderText = "Estrato";
            this.Estrato.Name = "Estrato";
            this.Estrato.ReadOnly = true;
            this.Estrato.Visible = false;
            // 
            // Impreso
            // 
            this.Impreso.DataPropertyName = "Impreso";
            this.Impreso.HeaderText = "Impreso";
            this.Impreso.Name = "Impreso";
            this.Impreso.ReadOnly = true;
            this.Impreso.Visible = false;
            // 
            // CodigoPredio
            // 
            this.CodigoPredio.DataPropertyName = "CodigoPredio";
            this.CodigoPredio.HeaderText = "CodigoPredio";
            this.CodigoPredio.Name = "CodigoPredio";
            this.CodigoPredio.ReadOnly = true;
            this.CodigoPredio.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(280, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(664, 35);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 41);
            this.panel1.TabIndex = 31;
            // 
            // Export_Button
            // 
            this.Export_Button.BackColor = System.Drawing.Color.Black;
            this.Export_Button.BackgroundImage = global::Login.Properties.Resources.PDF_Export;
            this.Export_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Export_Button.FlatAppearance.BorderSize = 0;
            this.Export_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Export_Button.Location = new System.Drawing.Point(1190, 0);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(46, 41);
            this.Export_Button.TabIndex = 30;
            this.Export_Button.UseVisualStyleBackColor = false;
            this.Export_Button.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Black;
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshButton.Location = new System.Drawing.Point(1057, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(36, 36);
            this.RefreshButton.TabIndex = 28;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Black;
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.BackButton.Location = new System.Drawing.Point(1319, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 38);
            this.BackButton.TabIndex = 27;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // editar_Button
            // 
            this.editar_Button.BackColor = System.Drawing.Color.Black;
            this.editar_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar_Button.BackgroundImage")));
            this.editar_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editar_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.editar_Button.Location = new System.Drawing.Point(2, 1);
            this.editar_Button.Name = "editar_Button";
            this.editar_Button.Size = new System.Drawing.Size(41, 38);
            this.editar_Button.TabIndex = 25;
            this.editar_Button.UseVisualStyleBackColor = false;
            this.editar_Button.Click += new System.EventHandler(this.editar_Button_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.Black;
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.Location = new System.Drawing.Point(49, 1);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(41, 38);
            this.Deletebutton.TabIndex = 24;
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Consumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 731);
            this.Controls.Add(this.Export_Button);
            this.Controls.Add(this.dglistaConsumos);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editar_Button);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Consumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumos";
            this.Load += new System.EventHandler(this.Consumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglistaConsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export_Button;
        private System.Windows.Forms.DataGridView dglistaConsumos;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button editar_Button;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesAño_Consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPredio;
    }
}