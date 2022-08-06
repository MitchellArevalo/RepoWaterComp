namespace Login
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.BackColor = System.Drawing.Color.Transparent;
            this.BtnIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngreso.Font = new System.Drawing.Font("Museo Sans Rounded 700", 20F, System.Drawing.FontStyle.Bold);
            this.BtnIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnIngreso.Location = new System.Drawing.Point(158, 421);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(191, 45);
            this.BtnIngreso.TabIndex = 1;
            this.BtnIngreso.Text = "Iniciar sesión";
            this.BtnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnIngreso.UseVisualStyleBackColor = false;
            this.BtnIngreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Museo Sans Rounded 700", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Museo Sans Rounded 700", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(158, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources._01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, -70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 678);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(509, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

