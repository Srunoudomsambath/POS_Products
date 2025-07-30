using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Products
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            txtTotalAmount.Text = $"{TotalAmount:c2}";
            comboDiscount.SelectedIndex = 1;
        }
        public double TotalAmount { get => MyData.TotalAmount;  }
        public double Discount {  get; set; }
        public double DiscountPrice { get; set; }
        public double Payment {  get; set; }
        public double CashReceived { get; set; }
        public double CashReturn { get; set; }

        private double[] discount = { 0, 5, 10, 15, 20 };

        private void comboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboDiscount.SelectedIndex;
            Discount = discount[index];
            DiscountPrice = TotalAmount * Discount / 100;
            Payment = TotalAmount - DiscountPrice;

            txtDiscountPrice.Text = $"{DiscountPrice:c2}";
            txtPayment.Text = $"{Payment:c2}";

            if (txtCashReceived.Text.Length > 0)
            {
                txtCashReceived_KeyUp(sender,null);
            }
        }

        private void txtCashReceived_KeyUp(object sender, KeyEventArgs e)
        {
            string text = txtCashReceived.Text;
            if (text.Length > 0)
            {
                CashReceived = double.Parse(text);
                CashReturn = CashReceived - Payment;
                txtCashReturned.Text = $"{CashReturn:$#,##0.00}";
                txtCashReturned.ForeColor = Color.White;

                if(CashReturn > 0)
                {
                    txtCashReturned.BackColor = Color.Green;
                    btnPayment.Enabled = true;

                    if (e != null)
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            btnPayment_Click(sender, e);
                        }
                    }
                }
                else
                {
                    txtCashReturned.BackColor= Color.Red;
                    btnPayment.Enabled = false;
                }
            }
            else
            {
                txtCashReturned.Text = "";
                txtCashReturned.BackColor = SystemColors.Control;
                txtCashReturned.ForeColor = Color.Black;
                CashReceived = 0;
                CashReturn = 0;
                btnPayment.Enabled= false;
               
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        public bool IsPrint { get => cPrint.Checked; }
        public bool IsPrintPreview { get => cPrintPreview.Checked; }
        public bool IsPrintDialog { get => cPrintDialog.Checked; }

        private void cPrint_CheckStateChanged(object sender, EventArgs e)
        {
            if (cPrint.Checked) {
                cPrintPreview.Checked = false;
                cPrintDialog.Checked = false;
            }


        }

        private void cPrintPreview_CheckStateChanged(object sender, EventArgs e)
        {
            if (cPrintPreview.Checked)
            {
                cPrintDialog.Checked = false;
                cPrint.Checked = false;
            }

        }

        private void cPrintDialog_CheckStateChanged(object sender, EventArgs e)
        {
            if (cPrintDialog.Checked)
            {
                cPrint.Checked = false;
                cPrintPreview.Checked = false;
            }
        }
    }
}
