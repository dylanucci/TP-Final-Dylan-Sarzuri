namespace Frontend
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnCliente = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 62);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 109);
            label2.Name = "label2";
            label2.Size = new Size(202, 42);
            label2.TabIndex = 1;
            label2.Text = "Ingresar Como:";
            // 
            // btnCliente
            // 
            btnCliente.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCliente.Location = new Point(259, 176);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(230, 48);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(259, 243);
            button2.Name = "button2";
            button2.Size = new Size(230, 48);
            button2.TabIndex = 3;
            button2.Text = "Administrador";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCliente;
        private Button button2;
    }
}
