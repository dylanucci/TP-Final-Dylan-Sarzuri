namespace Frontend.Forms
{
    partial class AdminComprasUI
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
            dgClientes = new DataGridView();
            btnConfirmar = new Button();
            btnFiltrar = new Button();
            txtFecha1 = new TextBox();
            txtFecha2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
            // 
            // dgClientes
            // 
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Location = new Point(12, 12);
            dgClientes.Name = "dgClientes";
            dgClientes.Size = new Size(539, 274);
            dgClientes.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(12, 396);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(157, 42);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Volver";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(602, 244);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(157, 42);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtFecha1
            // 
            txtFecha1.Location = new Point(602, 158);
            txtFecha1.Name = "txtFecha1";
            txtFecha1.Size = new Size(157, 23);
            txtFecha1.TabIndex = 5;
            txtFecha1.TextChanged += txtFecha1_TextChanged;
            // 
            // txtFecha2
            // 
            txtFecha2.Location = new Point(602, 215);
            txtFecha2.Name = "txtFecha2";
            txtFecha2.Size = new Size(157, 23);
            txtFecha2.TabIndex = 6;
            txtFecha2.TextChanged += txtFecha2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(602, 132);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 7;
            label1.Text = "Fecha 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(602, 189);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 8;
            label2.Text = "Fecha 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(611, 47);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 9;
            label3.Text = "Filtrar Fechas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(579, 86);
            label4.Name = "label4";
            label4.Size = new Size(222, 23);
            label4.TabIndex = 10;
            label4.Text = "Para filtrar, ingrese las fechas con ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(602, 109);
            label5.Name = "label5";
            label5.Size = new Size(157, 23);
            label5.TabIndex = 11;
            label5.Text = "el formato dd/MM/yyyy";
            // 
            // AdminComprasUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFecha2);
            Controls.Add(txtFecha1);
            Controls.Add(btnFiltrar);
            Controls.Add(btnConfirmar);
            Controls.Add(dgClientes);
            Name = "AdminComprasUI";
            Text = "AdminComprasUI";
            Load += AdminComprasUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgClientes;
        private Button btnConfirmar;
        private Button btnFiltrar;
        private TextBox txtFecha1;
        private TextBox txtFecha2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}