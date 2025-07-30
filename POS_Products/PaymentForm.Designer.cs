namespace POS_Products
{
    partial class PaymentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new CustomizeTextBox.FloatingBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayment = new CustomizeTextBox.FloatingBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountPrice = new CustomizeTextBox.FloatingBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCashReceived = new CustomizeTextBox.FloatingBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCashReturned = new CustomizeTextBox.FloatingBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.comboDiscount = new System.Windows.Forms.ComboBox();
            this.cPrint = new System.Windows.Forms.CheckBox();
            this.cPrintPreview = new System.Windows.Forms.CheckBox();
            this.cPrintDialog = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(205, 27);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(336, 31);
            this.txtTotalAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount:";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(205, 180);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(336, 31);
            this.txtPayment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment:";
            // 
            // txtDiscountPrice
            // 
            this.txtDiscountPrice.Location = new System.Drawing.Point(205, 130);
            this.txtDiscountPrice.Name = "txtDiscountPrice";
            this.txtDiscountPrice.ReadOnly = true;
            this.txtDiscountPrice.Size = new System.Drawing.Size(336, 31);
            this.txtDiscountPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discount Price:";
            // 
            // txtCashReceived
            // 
            this.txtCashReceived.Location = new System.Drawing.Point(205, 231);
            this.txtCashReceived.Name = "txtCashReceived";
            this.txtCashReceived.Size = new System.Drawing.Size(336, 31);
            this.txtCashReceived.TabIndex = 9;
            this.txtCashReceived.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCashReceived_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cash Received:";
            // 
            // txtCashReturned
            // 
            this.txtCashReturned.Location = new System.Drawing.Point(205, 292);
            this.txtCashReturned.Name = "txtCashReturned";
            this.txtCashReturned.ReadOnly = true;
            this.txtCashReturned.Size = new System.Drawing.Size(336, 31);
            this.txtCashReturned.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cash Returned:";
            // 
            // btnPayment
            // 
            this.btnPayment.Enabled = false;
            this.btnPayment.Location = new System.Drawing.Point(289, 342);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(154, 33);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // comboDiscount
            // 
            this.comboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDiscount.FormattingEnabled = true;
            this.comboDiscount.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%"});
            this.comboDiscount.Location = new System.Drawing.Point(205, 83);
            this.comboDiscount.Name = "comboDiscount";
            this.comboDiscount.Size = new System.Drawing.Size(336, 33);
            this.comboDiscount.TabIndex = 13;
            this.comboDiscount.SelectedIndexChanged += new System.EventHandler(this.comboDiscount_SelectedIndexChanged);
            // 
            // cPrint
            // 
            this.cPrint.AutoSize = true;
            this.cPrint.Checked = true;
            this.cPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cPrint.Location = new System.Drawing.Point(42, 413);
            this.cPrint.Name = "cPrint";
            this.cPrint.Size = new System.Drawing.Size(75, 29);
            this.cPrint.TabIndex = 14;
            this.cPrint.Text = "Print";
            this.cPrint.UseVisualStyleBackColor = true;
            this.cPrint.CheckStateChanged += new System.EventHandler(this.cPrint_CheckStateChanged);
            // 
            // cPrintPreview
            // 
            this.cPrintPreview.AutoSize = true;
            this.cPrintPreview.Location = new System.Drawing.Point(253, 413);
            this.cPrintPreview.Name = "cPrintPreview";
            this.cPrintPreview.Size = new System.Drawing.Size(157, 29);
            this.cPrintPreview.TabIndex = 15;
            this.cPrintPreview.Text = "Print Preview";
            this.cPrintPreview.UseVisualStyleBackColor = true;
            this.cPrintPreview.CheckStateChanged += new System.EventHandler(this.cPrintPreview_CheckStateChanged);
            // 
            // cPrintDialog
            // 
            this.cPrintDialog.AutoSize = true;
            this.cPrintDialog.Location = new System.Drawing.Point(486, 413);
            this.cPrintDialog.Name = "cPrintDialog";
            this.cPrintDialog.Size = new System.Drawing.Size(142, 29);
            this.cPrintDialog.TabIndex = 16;
            this.cPrintDialog.Text = "Print Dialog";
            this.cPrintDialog.UseVisualStyleBackColor = true;
            this.cPrintDialog.CheckStateChanged += new System.EventHandler(this.cPrintDialog_CheckStateChanged);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 472);
            this.Controls.Add(this.cPrintDialog);
            this.Controls.Add(this.cPrintPreview);
            this.Controls.Add(this.cPrint);
            this.Controls.Add(this.comboDiscount);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtCashReturned);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCashReceived);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiscountPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomizeTextBox.FloatingBox txtTotalAmount;
        private System.Windows.Forms.Label label2;
        private CustomizeTextBox.FloatingBox txtPayment;
        private System.Windows.Forms.Label label3;
        private CustomizeTextBox.FloatingBox txtDiscountPrice;
        private System.Windows.Forms.Label label4;
        private CustomizeTextBox.FloatingBox txtCashReceived;
        private System.Windows.Forms.Label label5;
        private CustomizeTextBox.FloatingBox txtCashReturned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ComboBox comboDiscount;
        private System.Windows.Forms.CheckBox cPrint;
        private System.Windows.Forms.CheckBox cPrintPreview;
        private System.Windows.Forms.CheckBox cPrintDialog;
    }
}