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
    public partial class ShowOrderDetail : Form
    {
        public ShowOrderDetail()
        {
            InitializeComponent();
        }

        private void ShowOrderDetail_Load(object sender, EventArgs e)
        {
            MyData.ShowOrderDetail(dataGridView, txtTotalAmount);
        }
    }
}
