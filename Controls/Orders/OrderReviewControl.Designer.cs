namespace PuntoDeVenta.Controls.Order
{
    partial class OrderReviewControl
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
            lsbOrderItems = new ListBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            lblClientData = new Label();
            rtxClientData = new RichTextBox();
            rtxComments = new RichTextBox();
            lblComments = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(16, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 37);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Confirmación de Orden";
            // 
            // panel1
            // 
            panel1.Controls.Add(rtxComments);
            panel1.Controls.Add(lblComments);
            panel1.Controls.Add(rtxClientData);
            panel1.Controls.Add(lblClientData);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(lsbOrderItems);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnReturn);
            panel1.Location = new Point(25, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 400);
            panel1.TabIndex = 11;
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
            // lsbOrderItems
            // 
            lsbOrderItems.Enabled = false;
            lsbOrderItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lsbOrderItems.FormattingEnabled = true;
            lsbOrderItems.ItemHeight = 17;
            lsbOrderItems.Location = new Point(3, 3);
            lsbOrderItems.Name = "lsbOrderItems";
            lsbOrderItems.SelectionMode = SelectionMode.None;
            lsbOrderItems.Size = new Size(400, 310);
            lsbOrderItems.TabIndex = 26;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(445, 267);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 20);
            lblTotal.TabIndex = 28;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(445, 290);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(165, 23);
            txtTotal.TabIndex = 27;
            // 
            // lblClientData
            // 
            lblClientData.AutoSize = true;
            lblClientData.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientData.Location = new Point(445, 3);
            lblClientData.Name = "lblClientData";
            lblClientData.Size = new Size(166, 20);
            lblClientData.TabIndex = 30;
            lblClientData.Text = "Información del cliente";
            // 
            // rtxClientData
            // 
            rtxClientData.Location = new Point(445, 26);
            rtxClientData.Name = "rtxClientData";
            rtxClientData.Size = new Size(302, 100);
            rtxClientData.TabIndex = 31;
            rtxClientData.Text = "";
            // 
            // rtxComments
            // 
            rtxComments.Location = new Point(445, 152);
            rtxComments.Name = "rtxComments";
            rtxComments.Size = new Size(302, 100);
            rtxComments.TabIndex = 33;
            rtxComments.Text = "";
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComments.Location = new Point(445, 129);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(95, 20);
            lblComments.TabIndex = 32;
            lblComments.Text = "Comentarios";
            // 
            // OrderReviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "OrderReviewControl";
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
        private ListBox lsbOrderItems;
        private Label lblClientData;
        private Label lblTotal;
        private TextBox txtTotal;
        private RichTextBox rtxClientData;
        private RichTextBox rtxComments;
        private Label lblComments;
    }
}
