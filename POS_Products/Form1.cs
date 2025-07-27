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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyData.MShowOrderDetail = mShowOrderDetail;
            MyData.MShowPaymentDetai = mPayment;

            MyData.LoadProduct(tableLayoutPanel);
        }

        private void mShowOrderDetail_Click(object sender, EventArgs e)
        {
            new ShowOrderDetail().ShowDialog(this);
        }
        private PaymentForm _paymentForm;
        // TODO To Be Continues
        private void mPayment_Click(object sender, EventArgs e)
        {
            _paymentForm = new PaymentForm();
            var result =  _paymentForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                printPreviewDialog.ShowDialog(this);
                MyData.Orders.Clear();
                Application.Restart();
            }

        }

        private void mReload_Click(object sender, EventArgs e)
        {
            if (MyData.Orders.Count > 0)
            {
                var result = MessageBox
                    .Show("Are you sure you want to reload the product ? All Order will be clear, ",
                       "Confirm Reload", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MyData.Orders.Clear();
                    Application.Restart();
                }
            }
            else
            {
                Application.Restart();
            }
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            if(MyData.Orders.Count > 0)
            {
                var result = MessageBox
                    .Show("Are you sure you want to exit the application ? All order will be clear,",
                    "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MyData.Orders.Clear();
                    Application.Exit();
                }

            }
            else
            {
                Application.Exit();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            MyData.PrintDocument(_paymentForm,e);
        }
    }
}
