namespace Login
{
    partial class Imprimir_Factura
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
            this.Download = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fecha_Factura = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Download
            // 
            this.Download.BackColor = System.Drawing.Color.Transparent;
            this.Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Download.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Download.Location = new System.Drawing.Point(511, 298);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(141, 54);
            this.Download.TabIndex = 0;
            this.Download.Text = "Descargar Factura";
            this.Download.UseVisualStyleBackColor = false;
            this.Download.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Menu.Location = new System.Drawing.Point(606, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(141, 54);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menú principal";
            this.Menu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(11, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento cliente";
            // 
            // txtDocCliente
            // 
            this.txtDocCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.txtDocCliente.Location = new System.Drawing.Point(16, 223);
            this.txtDocCliente.Name = "txtDocCliente";
            this.txtDocCliente.Size = new System.Drawing.Size(386, 29);
            this.txtDocCliente.TabIndex = 3;
            this.txtDocCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtDocCliente.Leave += new System.EventHandler(this.txtDocCliente_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(468, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // Fecha_Factura
            // 
            this.Fecha_Factura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fecha_Factura.CustomFormat = "MM/yyyy";
            this.Fecha_Factura.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.Fecha_Factura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_Factura.Location = new System.Drawing.Point(473, 223);
            this.Fecha_Factura.Name = "Fecha_Factura";
            this.Fecha_Factura.Size = new System.Drawing.Size(212, 29);
            this.Fecha_Factura.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources._01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Location = new System.Drawing.Point(-9, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 194);
            this.panel1.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.Location = new System.Drawing.Point(16, 289);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(386, 29);
            this.TxtNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(11, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.TxtDireccion.Location = new System.Drawing.Point(16, 356);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(386, 29);
            this.TxtDireccion.TabIndex = 10;
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labeldireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.labeldireccion.Location = new System.Drawing.Point(11, 328);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(109, 24);
            this.labeldireccion.TabIndex = 9;
            this.labeldireccion.Text = "Dirección";
            // 
            // Imprimir_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(739, 405);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fecha_Factura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Download);
            this.Name = "Imprimir_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir_Factura";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Fecha_Factura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label labeldireccion;
    }
}