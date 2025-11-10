namespace Frontend.Forms
{
    partial class ClientesTable
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
            button1 = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
            // 
            // dgClientes
            // 
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Location = new Point(65, 12);
            dgClientes.Name = "dgClientes";
            dgClientes.Size = new Size(635, 274);
            dgClientes.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(455, 356);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 1;
            button1.Text = "Eliminar por Id";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 396);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(157, 42);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ClientesTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(button1);
            Controls.Add(dgClientes);
            Name = "ClientesTable";
            Text = "ClientesTable";
            Load += ClientesTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgClientes;
        private Button button1;
        private Button btnVolver;
    }
}