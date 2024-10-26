namespace PuntoDeVenta
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtUsername = new TextBox();
            lblUsername = new Label();
            pnlLoginInputs = new Panel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblTitle = new Label();
            errorProvider = new ErrorProvider(components);
            pnlLoginInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(0, 18);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nombre de usuario";
            txtUsername.Size = new Size(250, 23);
            txtUsername.TabIndex = 0;
            txtUsername.KeyPress += inputKeyPress;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(47, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Usuario";
            // 
            // pnlLoginInputs
            // 
            pnlLoginInputs.Anchor = AnchorStyles.None;
            pnlLoginInputs.Controls.Add(btnLogin);
            pnlLoginInputs.Controls.Add(txtPassword);
            pnlLoginInputs.Controls.Add(lblPassword);
            pnlLoginInputs.Controls.Add(lblUsername);
            pnlLoginInputs.Controls.Add(txtUsername);
            pnlLoginInputs.Location = new Point(275, 192);
            pnlLoginInputs.MaximumSize = new Size(250, 0);
            pnlLoginInputs.MinimumSize = new Size(250, 100);
            pnlLoginInputs.Name = "pnlLoginInputs";
            pnlLoginInputs.RightToLeft = RightToLeft.No;
            pnlLoginInputs.Size = new Size(250, 160);
            pnlLoginInputs.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(73, 130);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(0, 76);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(250, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += inputKeyPress;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(3, 58);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(328, 149);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 30);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Iniciar Sesión";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblTitle);
            Controls.Add(pnlLoginInputs);
            Name = "LoginControl";
            Size = new Size(800, 500);
            pnlLoginInputs.ResumeLayout(false);
            pnlLoginInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label lblUsername;
        private Panel pnlLoginInputs;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblTitle;
        private ErrorProvider errorProvider;
    }
}
