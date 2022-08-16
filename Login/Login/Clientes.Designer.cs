namespace Login
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.dglistaClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPredio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Export_Button = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.editar_Button = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dglistaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dglistaClientes
            // 
            this.dglistaClientes.AllowUserToAddRows = false;
            this.dglistaClientes.AllowUserToDeleteRows = false;
            this.dglistaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglistaClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dglistaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dglistaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglistaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nombre,
            this.Documento,
            this.Estrato,
            this.CodigoPredio,
            this.Direccion,
            this.Correo_Electronico,
            this.Ciudad,
            this.Departamento,
            this.Active});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dglistaClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dglistaClientes.Location = new System.Drawing.Point(2, 40);
            this.dglistaClientes.Name = "dglistaClientes";
            this.dglistaClientes.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dglistaClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dglistaClientes.RowTemplate.Height = 100;
            this.dglistaClientes.Size = new System.Drawing.Size(1360, 682);
            this.dglistaClientes.TabIndex = 20;
            this.dglistaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglistaUsuarios_CellContentClick);
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.FillWeight = 30.23038F;
            this.IdCliente.HeaderText = "Id Usuario";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            this.IdCliente.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 42.07061F;
            this.Nombre.HeaderText = "Nombre completo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Documento.DataPropertyName = "Documento";
            this.Documento.FillWeight = 42.07061F;
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 180;
            // 
            // Estrato
            // 
            this.Estrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estrato.DataPropertyName = "Estrato";
            this.Estrato.HeaderText = "Estrato";
            this.Estrato.Name = "Estrato";
            this.Estrato.ReadOnly = true;
            this.Estrato.Width = 75;
            // 
            // CodigoPredio
            // 
            this.CodigoPredio.DataPropertyName = "CodigoPredio";
            this.CodigoPredio.HeaderText = "COD Predio";
            this.CodigoPredio.Name = "CodigoPredio";
            this.CodigoPredio.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Correo_Electronico
            // 
            this.Correo_Electronico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Correo_Electronico.DataPropertyName = "Correo_Electronico";
            this.Correo_Electronico.FillWeight = 42.07061F;
            this.Correo_Electronico.HeaderText = "Email";
            this.Correo_Electronico.Name = "Correo_Electronico";
            this.Correo_Electronico.ReadOnly = true;
            this.Correo_Electronico.Width = 275;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 150;
            // 
            // Active
            // 
            this.Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Activo";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 75;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(282, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(664, 35);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 41);
            this.panel1.TabIndex = 22;
            // 
            // Export_Button
            // 
            this.Export_Button.BackColor = System.Drawing.Color.Black;
            this.Export_Button.BackgroundImage = global::Login.Properties.Resources.PDF_Export;
            this.Export_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Export_Button.FlatAppearance.BorderSize = 0;
            this.Export_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Export_Button.Location = new System.Drawing.Point(1192, -1);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(46, 41);
            this.Export_Button.TabIndex = 21;
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
            this.RefreshButton.Location = new System.Drawing.Point(1059, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(36, 36);
            this.RefreshButton.TabIndex = 19;
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
            this.BackButton.Location = new System.Drawing.Point(1321, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 38);
            this.BackButton.TabIndex = 18;
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
            this.editar_Button.Location = new System.Drawing.Point(51, 0);
            this.editar_Button.Name = "editar_Button";
            this.editar_Button.Size = new System.Drawing.Size(41, 38);
            this.editar_Button.TabIndex = 16;
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
            this.Deletebutton.Location = new System.Drawing.Point(98, 0);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(41, 38);
            this.Deletebutton.TabIndex = 15;
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Black;
            this.Add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.Add_Button.Image = ((System.Drawing.Image)(resources.GetObject("Add_Button.Image")));
            this.Add_Button.Location = new System.Drawing.Point(0, 0);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(41, 38);
            this.Add_Button.TabIndex = 14;
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 731);
            this.Controls.Add(this.Export_Button);
            this.Controls.Add(this.dglistaClientes);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editar_Button);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglistaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export_Button;
        private System.Windows.Forms.DataGridView dglistaClientes;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button editar_Button;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPredio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}