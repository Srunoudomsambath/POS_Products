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
    public partial class ProduuctControl : UserControl
    {
        public ProduuctControl()
        {
            InitializeComponent();
        }
        public int Id{get;set;}
        public string PName { 
            get => txtPName.Text;
            set => txtPName.Text=value;
        }
        public int Qty { get;set;}
        public double Price { 
            get => _price ;
            set
            {
                _price = value; 
                txtPrice.Text = value.ToString("c2");
            }
        }
        private double _price;
        public Image Photo {
            get => picture.Image;
            set => picture.Image = value;
        }
        public double Amount { get => Price * Qty; }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Qty++;
            btnBuy.Text = "Buy (" + Qty + ")";
            btnCancel.Visible = true;

            MyData.Orders.Add(this);//this one
            MyData.MShowOrderDetail.Enabled = true;
            MyData.MShowPaymentDetai.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Qty--;
            if (Qty == 0)
            {
                btnBuy.Text = "Buy";
                btnCancel.Visible = false;
                MyData.Orders.Remove(this); //this one

                if(MyData.Orders.Count == 0)
                {
                    MyData.MShowPaymentDetai.Enabled=false;
                    MyData.MShowOrderDetail.Enabled = false;
                }
            }
            else
            {
                btnBuy.Text = "Buy (" + Qty + ")";
            }
        }
    }
}
