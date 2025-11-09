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
            panel1 = new Panel();
            label4 = new Label();
            button5 = new Button();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            label1 = new Label();
            button2 = new Button();
            label5 = new Label();
            lblUserName = new Label();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(67, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 34);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(242, -12);
            label4.Name = "label4";
            label4.Size = new Size(143, 39);
            label4.TabIndex = 9;
            label4.Text = "Loading...";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(574, 3);
            button5.Name = "button5";
            button5.Size = new Size(27, 27);
            button5.TabIndex = 15;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F);
            label3.Location = new Point(539, 5);
            label3.Name = "label3";
            label3.Size = new Size(20, 23);
            label3.TabIndex = 14;
            label3.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 4);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 1;
            label2.Text = "1300$";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(495, 1);
            button3.Name = "button3";
            button3.Size = new Size(27, 27);
            button3.TabIndex = 13;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 0;
            label1.Text = "Galletitas Celosas 220g";
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(495, 0);
            button2.Name = "button2";
            button2.Size = new Size(118, 30);
            button2.TabIndex = 11;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(801, 430);
            Controls.Add(lblUserName);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btnRealizar);
            Controls.Add(btnConfiguracion);
            Name = "ClienteUI";
            Text = "ClienteUI";
            Load += ClienteUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfiguracion;
        private Button btnRealizar;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Button button5;
        private Label label4;
        private Label label5;
        private Label lblUserName;
    }
}