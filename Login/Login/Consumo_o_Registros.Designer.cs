namespace Login
{
    partial class Consumo_o_Registros
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
            this.Btn_Lectura = new System.Windows.Forms.Button();
            this.Btn_consumo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Lectura
            // 
            this.Btn_Lectura.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Lectura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Lectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Lectura.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Lectura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Lectura.Location = new System.Drawing.Point(12, 22);
            this.Btn_Lectura.Name = "Btn_Lectura";
            this.Btn_Lectura.Size = new System.Drawing.Size(294, 46);
            this.Btn_Lectura.TabIndex = 0;
            this.Btn_Lectura.Text = "Registrar consumo";
            this.Btn_Lectura.UseVisualStyleBackColor = false;
            this.Btn_Lectura.Click += new System.EventHandler(this.Btn_Lectura_Click);
            // 
            // Btn_consumo
            // 
            this.Btn_consumo.BackColor = System.Drawing.Color.Transparent;
            this.Btn_consumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_consumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consumo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_consumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_consumo.Location = new System.Drawing.Point(12, 106);
            this.Btn_consumo.Name = "Btn_consumo";
            this.Btn_consumo.Size = new System.Drawing.Size(294, 46);
            this.Btn_consumo.TabIndex = 1;
            this.Btn_consumo.Text = "Visualizar registros";
            this.Btn_consumo.UseVisualStyleBackColor = false;
            this.Btn_consumo.Click += new System.EventHandler(this.Btn_consumo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(12, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consumo_o_Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(315, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_consumo);
            this.Controls.Add(this.Btn_Lectura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Consumo_o_Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿Que desea realizar?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Lectura;
        private System.Windows.Forms.Button Btn_consumo;
        private System.Windows.Forms.Button button1;
    }
}