namespace Frontend.Forms
{
    partial class ClienteUI
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
            btnConfiguracion = new Button();
            btnRealizar = new Button();
            label5 = new Label();
            lblUserName = new Label();
            SuspendLayout();
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Font = new Font("Sitka Banner", 14.2499981F);
            btnConfiguracion.Location = new Point(665, 7);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(124, 39);
            btnConfiguracion.TabIndex = 0;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnRealizar
            // 
            btnRealizar.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRealizar.Location = new Point(309, 7);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(174, 39);
            btnRealizar.TabIndex = 7;
            btnRealizar.Text = "Realizar Compra";
            btnRealizar.UseVisualStyleBackColor = true;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 14.2499981F);
            label5.Location = new Point(12, 7);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 9;
            label5.Text = "Nombre: ";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Sitka Text", 14.2499981F);
            lblUserName.Location = new Point(102, 7);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(96, 28);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "Nombre: ";
            // 
            // ClienteUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(801, 430);
            Controls.Add(lblUserName);
            Controls.Add(label5);
            Controls.Add(btnRealizar);
            Controls.Add(btnConfiguracion);
            Name = "ClienteUI";
            Text = "ClienteUI";
            Load += ClienteUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfiguracion;
        private Button btnRealizar;
        private Label label5;
        private Label lblUserName;
    }
}