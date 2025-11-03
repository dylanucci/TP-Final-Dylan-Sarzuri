namespace Frontend
{
    partial class Register
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
            lblRegistro = new Label();
            label1 = new Label();
            xd = new Label();
            btnRegistrarse = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistro.Location = new Point(245, 7);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(251, 42);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "Registro de Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 49);
            label1.Name = "label1";
            label1.Size = new Size(369, 21);
            label1.TabIndex = 1;
            label1.Text = "Por favor, ingrese sus datos para ingresar al sistema";
            // 
            // xd
            // 
            xd.AutoSize = true;
            xd.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xd.Location = new Point(245, 87);
            xd.Name = "xd";
            xd.Size = new Size(61, 17);
            xd.TabIndex = 2;
            xd.Text = "Nombre";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(245, 356);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(275, 49);
            btnRegistrarse.TabIndex = 3;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += this.btnRegistrarse_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(245, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(245, 158);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(275, 23);
            txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 138);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(245, 210);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(275, 23);
            txtTelefono.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 190);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(245, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 23);
            txtEmail.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(245, 243);
            label4.Name = "label4";
            label4.Size = new Size(134, 17);
            label4.TabIndex = 9;
            label4.Text = "Correo Electronico";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(245, 318);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(275, 23);
            txtContraseña.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(245, 298);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 11;
            label5.Text = "Contraseña";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContraseña);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistrarse);
            Controls.Add(xd);
            Controls.Add(label1);
            Controls.Add(lblRegistro);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private Label label1;
        private Label xd;
        private Button btnRegistrarse;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtContraseña;
        private Label label5;
    }
}