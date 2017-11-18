namespace EquinalDesktop
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
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Tb_Pass = new System.Windows.Forms.TextBox();
            this.Tb_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(78, 351);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(142, 32);
            this.Btn_Login.TabIndex = 9;
            this.Btn_Login.Text = "Iniciar sesión";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Tb_Pass
            // 
            this.Tb_Pass.Location = new System.Drawing.Point(78, 305);
            this.Tb_Pass.Name = "Tb_Pass";
            this.Tb_Pass.PasswordChar = '*';
            this.Tb_Pass.Size = new System.Drawing.Size(142, 22);
            this.Tb_Pass.TabIndex = 8;
            this.Tb_Pass.TextChanged += new System.EventHandler(this.Tb_Pass_TextChanged);
            // 
            // Tb_Usuario
            // 
            this.Tb_Usuario.Location = new System.Drawing.Point(78, 247);
            this.Tb_Usuario.Name = "Tb_Usuario";
            this.Tb_Usuario.Size = new System.Drawing.Size(142, 22);
            this.Tb_Usuario.TabIndex = 7;
            this.Tb_Usuario.TextChanged += new System.EventHandler(this.Tb_Usuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EquinalDesktop.Properties.Resources.logo_equinal;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::EquinalDesktop.Properties.Resources.logo_equinal;
            this.pictureBox1.Location = new System.Drawing.Point(78, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 135);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Tb_Pass);
            this.Controls.Add(this.Tb_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Tb_Pass;
        private System.Windows.Forms.TextBox Tb_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

