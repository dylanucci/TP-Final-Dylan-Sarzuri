namespace Frontend.Forms
{
    partial class AdminUI
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
            btnClientes = new Button();
            btnProductos = new Button();
            btnCompras = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(118, 155);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(230, 48);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(428, 155);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(230, 48);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCompras
            // 
            btnCompras.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.Location = new Point(278, 250);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(230, 48);
            btnCompras.TabIndex = 7;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 396);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(157, 42);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // AdminUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnCompras);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Name = "AdminUI";
            Text = "AdminUI";
            Load += AdminUI_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProductos;
        private Button btnCompras;
        private Button btnVolver;
    }
}