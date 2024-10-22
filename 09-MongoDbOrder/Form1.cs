using _09_MongoDbOrder.Entities;
using _09_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();
        private void btn_create_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txt_city.Text,
                CustomerName = txt_customer.Text,
                District = txt_district.Text,
                TotalPrice = Decimal.Parse(txt_totalPrice.Text)
            };

           orderOperation.AddOrder(order);
            MessageBox.Show("Order added successfully");
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetOrders();
            dataGridView1.DataSource = orders;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string orderId = txt_id.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Order deleted successfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txt_city.Text,
                CustomerName = txt_customer.Text,
                District = txt_district.Text,
                TotalPrice = Decimal.Parse(txt_totalPrice.Text),
                OrderId = txt_id.Text
            };

            orderOperation.UpdateOrder(order);
            MessageBox.Show("Order updated successfully");
        }

        private void btn_getById_Click(object sender, EventArgs e)
        {
            string orderId = txt_id.Text;
            Order order = orderOperation.GetOrderById(orderId);
            txt_city.Text = order.City;
            txt_customer.Text = order.CustomerName;
            txt_district.Text = order.District;
            txt_totalPrice.Text = order.TotalPrice.ToString();
        }
    }
}
