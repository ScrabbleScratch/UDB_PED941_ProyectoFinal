namespace PuntoDeVenta.Controls.Client
{
    partial class ClientRegistrationControl
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
            lblTitle = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            btnReturn = new Button();
            lblZipCode = new Label();
            textBox1 = new TextBox();
            lblCountry = new Label();
            txtCountry = new TextBox();
            lblState = new Label();
            txtState = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblCountryCode = new Label();
            txtCountryCode = new TextBox();
            lblDob = new Label();
            dtmDob = new DateTimePicker();
            lblName = new Label();
            txtName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(16, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 37);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Registro de Cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(lblZipCode);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblCountry);
            panel1.Controls.Add(txtCountry);
            panel1.Controls.Add(lblState);
            panel1.Controls.Add(txtState);
            panel1.Controls.Add(lblCity);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblCountryCode);
            panel1.Controls.Add(txtCountryCode);
            panel1.Controls.Add(lblDob);
            panel1.Controls.Add(dtmDob);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(25, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 400);
            panel1.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(570, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 37);
            btnSave.TabIndex = 25;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(3, 360);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(177, 37);
            btnReturn.TabIndex = 24;
            btnReturn.Text = "Regresar";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZipCode.Location = new Point(550, 188);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(103, 20);
            lblZipCode.TabIndex = 23;
            lblZipCode.Text = "Código postal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(550, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 22;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountry.Location = new Point(274, 188);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(36, 20);
            lblCountry.TabIndex = 21;
            lblCountry.Text = "País";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(274, 211);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(240, 23);
            txtCountry.TabIndex = 20;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblState.Location = new Point(3, 188);
            lblState.Name = "lblState";
            lblState.Size = new Size(54, 20);
            lblState.TabIndex = 19;
            lblState.Text = "Estado";
            // 
            // txtState
            // 
            txtState.Location = new Point(3, 211);
            txtState.Name = "txtState";
            txtState.Size = new Size(240, 23);
            txtState.TabIndex = 18;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(457, 139);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(57, 20);
            lblCity.TabIndex = 17;
            lblCity.Text = "Ciudad";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(457, 162);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(290, 23);
            txtCity.TabIndex = 16;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(3, 139);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 20);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Dirección";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(3, 162);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(416, 23);
            txtAddress.TabIndex = 14;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(139, 71);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(148, 20);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Número de teléfono";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(139, 94);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(280, 23);
            txtPhone.TabIndex = 12;
            // 
            // lblCountryCode
            // 
            lblCountryCode.AutoSize = true;
            lblCountryCode.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountryCode.Location = new Point(3, 71);
            lblCountryCode.Name = "lblCountryCode";
            lblCountryCode.Size = new Size(110, 20);
            lblCountryCode.TabIndex = 11;
            lblCountryCode.Text = "Código de país";
            // 
            // txtCountryCode
            // 
            txtCountryCode.Location = new Point(3, 94);
            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.Size = new Size(110, 23);
            txtCountryCode.TabIndex = 10;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDob.Location = new Point(457, 0);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(150, 20);
            lblDob.TabIndex = 9;
            lblDob.Text = "Fecha de nacimiento";
            // 
            // dtmDob
            // 
            dtmDob.Location = new Point(457, 23);
            dtmDob.Name = "dtmDob";
            dtmDob.Size = new Size(290, 23);
            dtmDob.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 20);
            lblName.TabIndex = 7;
            lblName.Text = "Nombre del cliente";
            // 
            // txtName
            // 
            txtName.Location = new Point(3, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(416, 23);
            txtName.TabIndex = 6;
            // 
            // AddClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "AddClientControl";
            Size = new Size(800, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Button btnSave;
        private Button btnReturn;
        private Label lblZipCode;
        private TextBox textBox1;
        private Label lblCountry;
        private TextBox txtCountry;
        private Label lblState;
        private TextBox txtState;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblCountryCode;
        private TextBox txtCountryCode;
        private Label lblDob;
        private DateTimePicker dtmDob;
        private Label lblName;
        private TextBox txtName;
    }
}
