namespace Login
{
    partial class Recuperar_Contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar_Contraseña));
            this.CorreoRecuperar = new System.Windows.Forms.TextBox();
            this.RecuperarPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CorreoRecuperar
            // 
            this.CorreoRecuperar.BackColor = System.Drawing.Color.Silver;
            this.CorreoRecuperar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CorreoRecuperar.Font = new System.Drawing.Font("Museo Sans Rounded 700", 13.75F, System.Drawing.FontStyle.Bold);
            this.CorreoRecuperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.CorreoRecuperar.Location = new System.Drawing.Point(195, 107);
            this.CorreoRecuperar.Name = "CorreoRecuperar";
            this.CorreoRecuperar.Size = new System.Drawing.Size(473, 22);
            this.CorreoRecuperar.TabIndex = 0;
            this.CorreoRecuperar.TextChanged += new System.EventHandler(this.CorreoRecuperar_TextChanged);
            // 
            // RecuperarPassword
            // 
            this.RecuperarPassword.BackColor = System.Drawing.Color.Transparent;
            this.RecuperarPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RecuperarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecuperarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecuperarPassword.Font = new System.Drawing.Font("Museo Sans Rounded 700", 12F);
            this.RecuperarPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.RecuperarPassword.Location = new System.Drawing.Point(561, 168);
            this.RecuperarPassword.Name = "RecuperarPassword";
            this.RecuperarPassword.Size = new System.Drawing.Size(107, 30);
            this.RecuperarPassword.TabIndex = 1;
            this.RecuperarPassword.Text = "Recuperar contraseña";
            this.RecuperarPassword.UseVisualStyleBackColor = false;
            this.RecuperarPassword.Click += new System.EventHandler(this.RecuperarPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Museo Sans Rounded 700", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(326, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo electrónico";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Museo Sans Rounded 700", 12F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(195, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Login.Properties.Resources._01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 250);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Recuperar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 240);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecuperarPassword);
            this.Controls.Add(this.CorreoRecuperar);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recuperar_Contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar_Contraseña";
            this.Load += new System.EventHandler(this.Recuperar_Contraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CorreoRecuperar;
        private System.Windows.Forms.Button RecuperarPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}