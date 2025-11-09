namespace Frontend.Forms
{
    partial class LoginOrRegisterUI
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
            btnRegister = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(422, 202);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(230, 48);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(147, 202);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(230, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginOrRegisterUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "LoginOrRegisterUI";
            Text = "LoginOrRegisterUI";
            Load += LoginOrRegisterUI_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnLogin;
    }
}