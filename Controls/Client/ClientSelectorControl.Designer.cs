namespace PuntoDeVenta.Controls.ClientSelector
{
    partial class ClientSelectorControl
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
            cmbClient = new ComboBox();
            lblClient = new Label();
            txtName = new TextBox();
            lblName = new Label();
            dtmDob = new DateTimePicker();
            panel1 = new Panel();
            btnCreate = new Button();
            btnNext = new Button();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(16, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(267, 37);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Selección de Cliente";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(3, 23);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(416, 23);
            cmbClient.TabIndex = 4;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClient.Location = new Point(3, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(56, 20);
            lblClient.TabIndex = 5;
            lblClient.Text = "Cliente";
            // 
            // txtName
            // 
            txtName.Location = new Point(3, 101);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(416, 23);
            txtName.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 78);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 20);
            lblName.TabIndex = 7;
            lblName.Text = "Nombre del cliente";
            // 
            // dtmDob
            // 
            dtmDob.Enabled = false;
            dtmDob.Location = new Point(457, 101);
            dtmDob.Name = "dtmDob";
            dtmDob.Size = new Size(290, 23);
            dtmDob.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(btnNext);
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
            panel1.Controls.Add(cmbClient);
            panel1.Controls.Add(dtmDob);
            panel1.Controls.Add(lblClient);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(25, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 400);
            panel1.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(274, 360);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(177, 37);
            btnCreate.TabIndex = 26;
            btnCreate.Text = "Agregar Cliente";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(570, 360);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(177, 37);
            btnNext.TabIndex = 25;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = true;
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
            lblZipCode.Location = new Point(550, 266);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(103, 20);
            lblZipCode.TabIndex = 23;
            lblZipCode.Text = "Código postal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(550, 289);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 22;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountry.Location = new Point(274, 266);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(36, 20);
            lblCountry.TabIndex = 21;
            lblCountry.Text = "País";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(274, 289);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(240, 23);
            txtCountry.TabIndex = 20;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblState.Location = new Point(3, 266);
            lblState.Name = "lblState";
            lblState.Size = new Size(54, 20);
            lblState.TabIndex = 19;
            lblState.Text = "Estado";
            // 
            // txtState
            // 
            txtState.Location = new Point(3, 289);
            txtState.Name = "txtState";
            txtState.ReadOnly = true;
            txtState.Size = new Size(240, 23);
            txtState.TabIndex = 18;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(457, 217);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(57, 20);
            lblCity.TabIndex = 17;
            lblCity.Text = "Ciudad";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(457, 240);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(290, 23);
            txtCity.TabIndex = 16;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(3, 217);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 20);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Dirección";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(3, 240);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(416, 23);
            txtAddress.TabIndex = 14;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(139, 149);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(148, 20);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Número de teléfono";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(139, 172);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(280, 23);
            txtPhone.TabIndex = 12;
            // 
            // lblCountryCode
            // 
            lblCountryCode.AutoSize = true;
            lblCountryCode.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountryCode.Location = new Point(3, 149);
            lblCountryCode.Name = "lblCountryCode";
            lblCountryCode.Size = new Size(110, 20);
            lblCountryCode.TabIndex = 11;
            lblCountryCode.Text = "Código de país";
            // 
            // txtCountryCode
            // 
            txtCountryCode.Location = new Point(3, 172);
            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.ReadOnly = true;
            txtCountryCode.Size = new Size(110, 23);
            txtCountryCode.TabIndex = 10;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDob.Location = new Point(457, 78);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(150, 20);
            lblDob.TabIndex = 9;
            lblDob.Text = "Fecha de nacimiento";
            // 
            // ClientSelectorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "ClientSelectorControl";
            Size = new Size(800, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbClient;
        private Label lblClient;
        private TextBox txtName;
        private Label lblName;
        private DateTimePicker dtmDob;
        private Panel panel1;
        private Label lblDob;
        private TextBox txtPhone;
        private Label lblCountryCode;
        private TextBox txtCountryCode;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPhone;
        private Label lblState;
        private TextBox txtState;
        private TextBox txtCountry;
        private Label lblCountry;
        private Label lblZipCode;
        private TextBox textBox1;
        private Button btnCreate;
        private Button btnNext;
        private Button btnReturn;
    }
}
