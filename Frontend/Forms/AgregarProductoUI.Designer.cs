namespace Frontend.Forms
{
    partial class AgregarProductoUI
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
            txtPrecio = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnIngresar = new Button();
            lblRegistro = new Label();
            label1 = new Label();
            cbCategorias = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(212, 177);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(275, 23);
            txtPrecio.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(212, 157);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 21;
            label5.Text = "Precio ($)";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(212, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 23);
            txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(212, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 17);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(212, 217);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(275, 49);
            btnIngresar.TabIndex = 18;
            btnIngresar.Text = "Crear Producto";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistro.Location = new Point(281, 1);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(226, 42);
            lblRegistro.TabIndex = 23;
            lblRegistro.Text = "Agregar Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 43);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 24;
            label1.Text = "Por favor, complete los campos";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(505, 117);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(175, 23);
            cbCategorias.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(505, 97);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 26;
            label2.Text = "Categoria";
            // 
            // AgregarProductoUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(cbCategorias);
            Controls.Add(label1);
            Controls.Add(lblRegistro);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnIngresar);
            Name = "AgregarProductoUI";
            Text = "AgregarProductoUI";
            Load += AgregarProductoUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnIngresar;
        private Label lblRegistro;
        private Label label1;
        private ComboBox cbCategorias;
        private Label label2;
    }
}