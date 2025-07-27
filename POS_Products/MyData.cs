using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Products
{
    internal class MyData
    {
        public static HashSet<ProduuctControl> Orders { get; set; } = new HashSet<ProduuctControl>();
        public static double TotalAmount { 
            get => Orders.Sum(p=> p.Amount);
        }
        public static ToolStripMenuItem MShowOrderDetail { get; internal set; }
        public static ToolStripMenuItem MShowPaymentDetai { get; internal set; }

        internal static void LoadProduct(TableLayoutPanel tableLayoutPanel)
        {
            string[] files = Directory.GetFiles("D:\\SV45\\C#\\POS_Products\\Icons");//change to Image 
            int r = 0, c = 1;
            int id = 1;
            Random rnd = new Random();
            foreach (string file in files)
            {
                if (Path.GetExtension(file).ToLower() == ".jpg" || Path.GetExtension(file).ToLower() == ".png")
                {
                    Image photo = Image.FromFile(file);
                    String pname = Path.GetFileNameWithoutExtension(file);
                    double price = rnd.Next(30) + 1;

                    ProduuctControl p = new ProduuctControl()
                    {
                        Id = id++,
                        Photo = photo,
                        PName = pname,
                        Price = price,
                    };
                    tableLayoutPanel.Controls.Add(p, c, r);
                    c++;
                    if (c > 5)
                    {
                        c = 1;
                        r++;
                    }
                }
            }
        }

        internal static void PrintDocument(PaymentForm paymentForm, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.shopify_black_logo_icon_147085, 0, 0, 64, 64);
            e.Graphics.DrawImage(Properties.Resources.description, 64, 0, 128, 64);

            string address = "# 464 A, Preah Monivorng Blvd,\n Phnom Penh Tel: 092129834";
            Font font = new Font("", 10 , FontStyle.Regular);
            e.Graphics.DrawString(address, font, Brushes.Black, 80, 33);

            Pen pen = new Pen(Color.Black,1);
            e.Graphics.DrawLine(pen, 0, 91, e.PageBounds.Width, 91);

            font = new Font("",8, FontStyle.Regular);
            string seller = $"Seller : Srun Oudomsambath  {DateTime.Now:dd-MM-yy:mm:ss tt}";
            e.Graphics.DrawString(seller, font, Brushes.Black, 0, 70);

            font = new Font("", 7, FontStyle.Bold);
            string header = "No.".PadRight(5) +
                            "Product Name".PadRight(22) +
                            "Price".PadRight(10) +
                            "Qty".PadRight(4) +
                            "Amount";
            e.Graphics.DrawString(header, font, Brushes.Black, 0, 85);

            font = new Font("Consolas", 7, FontStyle.Regular);
            int y = 100;

            foreach(ProduuctControl p in Orders)
            {
                string pname = p.Name;
                if(pname.Length > 18)
                {
                    pname = pname.Substring(0, 18);
                    pname += "...";
                }
                string line = $"{p.Id:00}".PadRight(4) +
                                p.PName.PadRight(22) +
                                $"{p.Price:c2}".PadRight(10) +
                                $"{p.Qty}".PadRight(4) +
                                $"{p.Amount}";
                e.Graphics.DrawString(line, font, Brushes.Black, 0, y);
                y += 15;
            }
            pen = new Pen(Color.Black, 1);
            e.Graphics.DrawLine(pen, 0, y, e.PageBounds.Width, y);
            string totalAmountText = "Total Amount: ".PadLeft(40) + $"{TotalAmount:c2}";
            y += 5;
            e.Graphics.DrawString(totalAmountText,font,Brushes.Black, 0, y);

            y += 15;
            string discountText = $"Discount : ".PadLeft(40) + $"{paymentForm.Discount}%";
            e.Graphics.DrawString(discountText,font,Brushes.Black,0, y);    



        }

        internal static void ShowOrderDetail(DataGridView dataGridView, TextBox txtTotalAmount)
        {
            foreach(ProduuctControl p in Orders)
            {
                dataGridView.Rows.Add(
                    p.Id.ToString("000"),
                    p.PName,
                    p.Price.ToString("c2"),
                    p.Qty,
                    p.Amount.ToString("c2")
                    
                    );
            }
            double totalAmount = TotalAmount;
            txtTotalAmount.Text = totalAmount.ToString("c2");
        }
    }
}
