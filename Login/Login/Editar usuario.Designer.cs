namespace Login
{
    partial class Editar_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_usuario));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CheckContra = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar_usuario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Img_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.Expandir_Checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(398, 388);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(328, 21);
            this.checkedListBox1.TabIndex = 38;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // CheckContra
            // 
            this.CheckContra.AutoSize = true;
            this.CheckContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.CheckContra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckContra.Location = new System.Drawing.Point(673, 285);
            this.CheckContra.Name = "CheckContra";
            this.CheckContra.Size = new System.Drawing.Size(150, 19);
            this.CheckContra.TabIndex = 37;
            this.CheckContra.Text = "Mostrar contraseña";
            this.CheckContra.UseVisualStyleBackColor = true;
            this.CheckContra.CheckedChanged += new System.EventHandler(this.CheckContra_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(393, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Rol";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_salir.Location = new System.Drawing.Point(397, 463);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(103, 39);
            this.btn_salir.TabIndex = 34;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar_usuario
            // 
            this.btn_guardar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_guardar_usuario.Location = new System.Drawing.Point(736, 463);
            this.btn_guardar_usuario.Name = "btn_guardar_usuario";
            this.btn_guardar_usuario.Size = new System.Drawing.Size(103, 39);
            this.btn_guardar_usuario.TabIndex = 33;
            this.btn_guardar_usuario.Text = "Guardar";
            this.btn_guardar_usuario.UseVisualStyleBackColor = true;
            this.btn_guardar_usuario.Click += new System.EventHandler(this.btn_guardar_usuario_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(101, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "Foto de perfil";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_email.Location = new System.Drawing.Point(397, 323);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(425, 19);
            this.txt_email.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(392, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Correo electrónico";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_password.Location = new System.Drawing.Point(397, 253);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(425, 19);
            this.txt_password.TabIndex = 29;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(392, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Contraseña";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_username.Location = new System.Drawing.Point(398, 182);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(425, 19);
            this.txt_username.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(393, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Username";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nombre.Location = new System.Drawing.Point(398, 116);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(425, 19);
            this.txt_nombre.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(393, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre completo";
            // 
            // txt_documento
            // 
            this.txt_documento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txt_documento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_documento.Location = new System.Drawing.Point(398, 40);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(425, 19);
            this.txt_documento.TabIndex = 23;
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_documento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(393, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Documento";
            // 
            // Img_Button
            // 
            this.Img_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Img_Button.Location = new System.Drawing.Point(94, 427);
            this.Img_Button.Name = "Img_Button";
            this.Img_Button.Size = new System.Drawing.Size(214, 43);
            this.Img_Button.TabIndex = 42;
            this.Img_Button.Text = "Importar imagen";
            this.Img_Button.UseVisualStyleBackColor = true;
            this.Img_Button.Click += new System.EventHandler(this.Img_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "strech";
            this.pictureBox1.Location = new System.Drawing.Point(52, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ActiveCheckbox
            // 
            this.ActiveCheckbox.AutoSize = true;
            this.ActiveCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActiveCheckbox.Location = new System.Drawing.Point(397, 422);
            this.ActiveCheckbox.Name = "ActiveCheckbox";
            this.ActiveCheckbox.Size = new System.Drawing.Size(86, 28);
            this.ActiveCheckbox.TabIndex = 43;
            this.ActiveCheckbox.Text = "Activo";
            this.ActiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // Expandir_Checkbox
            // 
            this.Expandir_Checkbox.AutoSize = true;
            this.Expandir_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Expandir_Checkbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Expandir_Checkbox.Location = new System.Drawing.Point(740, 390);
            this.Expandir_Checkbox.Name = "Expandir_Checkbox";
            this.Expandir_Checkbox.Size = new System.Drawing.Size(83, 19);
            this.Expandir_Checkbox.TabIndex = 44;
            this.Expandir_Checkbox.Text = "Expandir";
            this.Expandir_Checkbox.UseVisualStyleBackColor = true;
            this.Expandir_Checkbox.CheckedChanged += new System.EventHandler(this.Expandir_Checkbox_CheckedChanged_1);
            // 
            // Editar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(860, 520);
            this.Controls.Add(this.Expandir_Checkbox);
            this.Controls.Add(this.Img_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.CheckContra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar_usuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActiveCheckbox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editar_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar usuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Editar_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox CheckContra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Img_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox ActiveCheckbox;
        private System.Windows.Forms.CheckBox Expandir_Checkbox;
    }
}