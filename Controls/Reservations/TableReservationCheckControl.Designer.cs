namespace PuntoDeVenta.Controls.Reservations
{
    partial class TableReservationCheckControl
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
            lblReservationEndDate = new Label();
            dtmReservationEndDate = new DateTimePicker();
            lblSeats = new Label();
            txtSeats = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            cmbReservations = new ComboBox();
            lblReservations = new Label();
            btnNext = new Button();
            btnReturn = new Button();
            lblReservationStartDate = new Label();
            cmbClient = new ComboBox();
            dtmReservationStartDate = new DateTimePicker();
            lblClient = new Label();
            btnEnd = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(16, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(392, 37);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Consulta de Reserva de Mesas";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblReservationEndDate);
            panel1.Controls.Add(dtmReservationEndDate);
            panel1.Controls.Add(lblSeats);
            panel1.Controls.Add(txtSeats);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(cmbReservations);
            panel1.Controls.Add(lblReservations);
            panel1.Controls.Add(btnEnd);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(lblReservationStartDate);
            panel1.Controls.Add(cmbClient);
            panel1.Controls.Add(dtmReservationStartDate);
            panel1.Controls.Add(lblClient);
            panel1.Location = new Point(25, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 400);
            panel1.TabIndex = 11;
            // 
            // lblReservationEndDate
            // 
            lblReservationEndDate.AutoSize = true;
            lblReservationEndDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationEndDate.Location = new Point(457, 204);
            lblReservationEndDate.Name = "lblReservationEndDate";
            lblReservationEndDate.Size = new Size(250, 20);
            lblReservationEndDate.TabIndex = 34;
            lblReservationEndDate.Text = "Fecha de vencimiento de la reserva";
            // 
            // dtmReservationEndDate
            // 
            dtmReservationEndDate.Enabled = false;
            dtmReservationEndDate.Location = new Point(457, 227);
            dtmReservationEndDate.Name = "dtmReservationEndDate";
            dtmReservationEndDate.Size = new Size(290, 23);
            dtmReservationEndDate.TabIndex = 33;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeats.Location = new Point(457, 137);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(66, 20);
            lblSeats.TabIndex = 32;
            lblSeats.Text = "Asientos";
            // 
            // txtSeats
            // 
            txtSeats.Location = new Point(457, 160);
            txtSeats.Name = "txtSeats";
            txtSeats.ReadOnly = true;
            txtSeats.Size = new Size(290, 23);
            txtSeats.TabIndex = 31;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(3, 137);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 20);
            lblDescription.TabIndex = 30;
            lblDescription.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(3, 160);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(416, 23);
            txtDescription.TabIndex = 29;
            // 
            // cmbReservations
            // 
            cmbReservations.FormattingEnabled = true;
            cmbReservations.Location = new Point(3, 99);
            cmbReservations.Name = "cmbReservations";
            cmbReservations.Size = new Size(416, 23);
            cmbReservations.TabIndex = 27;
            // 
            // lblReservations
            // 
            lblReservations.AutoSize = true;
            lblReservations.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservations.Location = new Point(3, 76);
            lblReservations.Name = "lblReservations";
            lblReservations.Size = new Size(106, 20);
            lblReservations.TabIndex = 28;
            lblReservations.Text = "Reservaciones";
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
            // lblReservationStartDate
            // 
            lblReservationStartDate.AutoSize = true;
            lblReservationStartDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationStartDate.Location = new Point(3, 204);
            lblReservationStartDate.Name = "lblReservationStartDate";
            lblReservationStartDate.Size = new Size(203, 20);
            lblReservationStartDate.TabIndex = 9;
            lblReservationStartDate.Text = "Fecha de inicio de la reserva";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(3, 23);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(416, 23);
            cmbClient.TabIndex = 4;
            // 
            // dtmReservationStartDate
            // 
            dtmReservationStartDate.Enabled = false;
            dtmReservationStartDate.Location = new Point(3, 227);
            dtmReservationStartDate.Name = "dtmReservationStartDate";
            dtmReservationStartDate.Size = new Size(290, 23);
            dtmReservationStartDate.TabIndex = 8;
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
            // btnEnd
            // 
            btnEnd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnd.Location = new Point(274, 360);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(177, 37);
            btnEnd.TabIndex = 26;
            btnEnd.Text = "Marcar Finalizada";
            btnEnd.UseVisualStyleBackColor = true;
            // 
            // TableReservationCheckControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "TableReservationCheckControl";
            Size = new Size(800, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblReservationEndDate;
        private DateTimePicker dtmReservationEndDate;
        private Label lblSeats;
        private TextBox txtSeats;
        private Label lblDescription;
        private TextBox txtDescription;
        private ComboBox cmbReservations;
        private Label lblReservations;
        private Button btnNext;
        private Button btnReturn;
        private Label lblReservationStartDate;
        private ComboBox cmbClient;
        private DateTimePicker dtmReservationStartDate;
        private Label lblClient;
        private Button btnEnd;
    }
}
