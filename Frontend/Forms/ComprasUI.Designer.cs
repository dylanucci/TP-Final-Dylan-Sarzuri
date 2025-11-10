namespace Frontend.Forms
{
    partial class ComprasUI
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
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
            // 
            // dgClientes
            // 
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Location = new Point(114, 12);
            dgClientes.Name = "dgClientes";
            dgClientes.Size = new Size(539, 274);
            dgClientes.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(12, 396);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(157, 42);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Volver";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // ComprasUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(dgClientes);
            Name = "ComprasUI";
            Text = "ComprasUI";
            Load += ComprasUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgClientes;
        private Button btnConfirmar;
    }
}