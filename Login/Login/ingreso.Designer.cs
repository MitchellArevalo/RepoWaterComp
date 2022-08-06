namespace Login
{
    partial class ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingreso));
            this.Username_Text_Box = new System.Windows.Forms.TextBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username_Text_Box
            // 
            this.Username_Text_Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Username_Text_Box.BackColor = System.Drawing.Color.Silver;
            this.Username_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_Text_Box.Font = new System.Drawing.Font("Museo Sans Rounded 700", 13.75F, System.Drawing.FontStyle.Bold);
            this.Username_Text_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.Username_Text_Box.Location = new System.Drawing.Point(1047, 156);
            this.Username_Text_Box.Name = "Username_Text_Box";
            this.Username_Text_Box.Size = new System.Drawing.Size(432, 22);
            this.Username_Text_Box.TabIndex = 0;
            this.Username_Text_Box.TextChanged += new System.EventHandler(this.Username_Text_Box_TextChanged);
            this.Username_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_TextBox_KeyPress);
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Museo Sans Rounded 700", 14.25F);
            this.Label_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Label_Username.Location = new System.Drawing.Point(939, 153);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(102, 24);
            this.Label_Username.TabIndex = 1;
            this.Label_Username.Text = "Username:";
            this.Label_Username.Click += new System.EventHandler(this.Label_Username_Click);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Museo Sans Rounded 700", 14.25F);
            this.Label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Label_Password.Location = new System.Drawing.Point(940, 215);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(97, 24);
            this.Label_Password.TabIndex = 2;
            this.Label_Password.Text = "Password:";
            this.Label_Password.Click += new System.EventHandler(this.Label_Password_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Password_TextBox.BackColor = System.Drawing.Color.Silver;
            this.Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_TextBox.Font = new System.Drawing.Font("Museo Sans Rounded 700", 13.75F, System.Drawing.FontStyle.Bold);
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.Password_TextBox.Location = new System.Drawing.Point(1049, 216);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(430, 22);
            this.Password_TextBox.TabIndex = 3;
            this.Password_TextBox.UseSystemPasswordChar = true;
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            this.Password_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_TextBox_KeyPress);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Museo Sans Rounded 700", 14.25F);
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnIngresar.Location = new System.Drawing.Point(1375, 316);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(105, 34);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            this.BtnIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnIngresar_KeyPress);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Museo Sans Rounded 700", 14.25F);
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnSalir.Location = new System.Drawing.Point(1050, 316);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(105, 34);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Museo Sans Rounded 700", 9F);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(1049, 247);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 15);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources._01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.Password_TextBox);
            this.panel1.Controls.Add(this.BtnIngresar);
            this.panel1.Controls.Add(this.Label_Password);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.Label_Username);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.Username_Text_Box);
            this.panel1.Location = new System.Drawing.Point(-724, -60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1681, 422);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.ingreso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Username_Text_Box;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}