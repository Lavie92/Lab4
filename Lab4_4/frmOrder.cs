using Lab4_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_4
{
    public partial class Form1 : Form
    {
        ProductOrderContext producOrderContext = new ProductOrderContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var group = producOrderContext.Orders.GroupBy(x => new
            {
                x.InvoiceNo, x.Invoice.OrderDate, x.Invoice.DeliveryDate
            })
                .Select(x => new
                {
                    InvoiceNo = x.Key.InvoiceNo,
                    OrderDate = x.Key.OrderDate,
                    DeliveryDate = x.Key.DeliveryDate,
                    Total = x.Sum(y => y.Quantity * y.Price)
                });

          
            dgvProductOrder.DataSource = group.ToList();
        }
        private void Search()
        {
            List<Order> result = producOrderContext.Orders.Where(x => x.Invoice.DeliveryDate >= dtpDelivery1.Value && x.Invoice.DeliveryDate <= dtpDelivery2.Value).ToList();
            dgvProductOrder.DataSource = result.Select(x => new
            {
                InvoiceNo = x.InvoiceNo,
                OrderDate = x.Invoice.OrderDate,
                DeliveryDate = x.Invoice.DeliveryDate,
                Total = x.Quantity * x.Price
            }).ToList();
        }
      

        private void ckbDisplayAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDisplayAll.Checked)
            {
                dtpDelivery1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpDelivery2.Value = new DateTime(DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            }
            else
            {
                dtpDelivery1.Value = DateTime.Now;
                dtpDelivery2.Value = DateTime.Now;
            }
        }

        private void dtpDelivery1_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dtpDelivery2_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
