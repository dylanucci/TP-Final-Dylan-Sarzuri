namespace Frontend.Forms
{
    partial class Login
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
            txtContraseña = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnRegistrarse = new Button();
            lblRegistro = new Label();
            SuspendLayout();
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(257, 168);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(275, 23);
            txtContraseña.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(257, 148);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 16;
            label5.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(257, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 23);
            txtEmail.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(257, 88);
            label4.Name = "label4";
            label4.Size = new Size(134, 17);
            label4.TabIndex = 14;
            label4.Text = "Correo Electronico";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(257, 216);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(275, 49);
            btnRegistrarse.TabIndex = 13;
            btnRegistrarse.Text = "Ingresar";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistro.Location = new Point(334, 9);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(85, 42);
            lblRegistro.TabIndex = 18;
            lblRegistro.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegistro);
            Controls.Add(txtContraseña);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(btnRegistrarse);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContraseña;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private Button btnRegistrarse;
        private Label lblRegistro;
    }
}