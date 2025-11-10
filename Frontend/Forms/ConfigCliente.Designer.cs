namespace Frontend.Forms
{
    partial class ConfigCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            btnActualizar = new Button();
            btnVolver = new Button();
            btnCerrar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 0;
            label1.Text = "Perfil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 103);
            label2.Name = "label2";
            label2.Size = new Size(34, 35);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 138);
            label3.Name = "label3";
            label3.Size = new Size(90, 35);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(157, 173);
            label4.Name = "label4";
            label4.Size = new Size(91, 35);
            label4.TabIndex = 3;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(157, 208);
            label5.Name = "label5";
            label5.Size = new Size(93, 35);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Sitka Banner", 14.2499981F);
            txtTelefono.Location = new Point(256, 211);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(317, 31);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Sitka Banner", 14.2499981F);
            txtApellido.Location = new Point(256, 176);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(317, 31);
            txtApellido.TabIndex = 8;
            txtApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(256, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 31);
            txtNombre.TabIndex = 9;
            txtNombre.Text = "adsad";
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Sitka Banner", 14.2499981F);
            txtId.Location = new Point(256, 106);
            txtId.Name = "txtId";
            txtId.Size = new Size(317, 31);
            txtId.TabIndex = 10;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Sitka Banner", 18F);
            btnActualizar.Location = new Point(346, 248);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(123, 56);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Modificar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Banner", 18F);
            btnVolver.Location = new Point(12, 392);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(123, 46);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Sitka Banner", 18F);
            btnCerrar.Location = new Point(665, 392);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(149, 46);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Banner", 18F);
            button1.Location = new Point(332, 377);
            button1.Name = "button1";
            button1.Size = new Size(149, 46);
            button1.TabIndex = 14;
            button1.Text = "Ver compras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ConfigCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(button1);
            Controls.Add(btnCerrar);
            Controls.Add(btnVolver);
            Controls.Add(btnActualizar);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConfigCliente";
            Text = "Cerrar Sesion";
            Load += ConfigCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtId;
        private Button btnActualizar;
        private Button btnVolver;
        private Button btnCerrar;
        private Button button1;
    }
}