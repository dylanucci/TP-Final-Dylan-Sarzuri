namespace Frontend.Forms
{
    partial class ProductosTable
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
            dgProductos = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(189, 12);
            dgProductos.Name = "dgProductos";
            dgProductos.Size = new Size(371, 254);
            dgProductos.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(522, 334);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 2;
            button1.Text = "Eliminar por Id";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(189, 314);
            button2.Name = "button2";
            button2.Size = new Size(146, 23);
            button2.TabIndex = 3;
            button2.Text = "Agregar Productos";
            button2.UseVisualStyleBackColor = true;
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
            // ProductosTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgProductos);
            Name = "ProductosTable";
            Text = "ProductosTable";
            Load += ProductosTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProductos;
        private Button button1;
        private Button button2;
        private Button btnVolver;
    }
}