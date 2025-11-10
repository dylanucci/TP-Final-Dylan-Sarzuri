namespace Frontend.Forms
{
    partial class ClienteCompraUI
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
            btnConfirmar = new Button();
            label6 = new Label();
            label7 = new Label();
            lblTotal = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(675, 12);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(157, 42);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(344, 9);
            label6.Name = "label6";
            label6.Size = new Size(88, 30);
            label6.TabIndex = 2;
            label6.Text = "Resumen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(82, 46);
            label7.Name = "label7";
            label7.Size = new Size(57, 28);
            label7.TabIndex = 4;
            label7.Text = "Total: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(135, 49);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 23);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "2600$";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 369);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(157, 42);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ClienteCompraUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(844, 423);
            Controls.Add(btnVolver);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnConfirmar);
            Name = "ClienteCompraUI";
            Text = "D";
            Load += ClienteCompraUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConfirmar;
        private Label label6;
        private Label label7;
        private Label lblTotal;
        private Button btnVolver;
    }
}