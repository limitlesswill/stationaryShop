using Models.Application.Models;
using Stationery.Application.Services.ServicesContracts;
using System.Windows.Forms;
using Stationery.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stationery.Application.Services;

namespace Stationary_Presentation
{
    public partial class ProductDetails : Form
    {
        public ProductDetails(Product _product, IOrderItemServices _orderItemServcies, int _orderId) : this(_product, _orderItemServcies, _orderId, null)
        { }
        public ProductDetails(Product _product, IOrderItemServices _orderItemServcies, int _orderId, FormClosedEventHandler refresh)
        {
            InitializeComponent();

            product = _product;
            orderItemServcies = _orderItemServcies;
            orderId = _orderId;
            FormClosed += refresh;
        }

        IOrderItemServices orderItemServcies;
        Product product;
        int orderId;
        private void ProductDetails_Load(object sender, EventArgs e)
        {

            TxtCategory.Text = product.Category.ToString();
            TxtProductName.Text = product.Name;
            TxtPrice.Text = product.Price.ToString();
            TxtDescription.Text = product.Description;

            //IOrderItemServices orderServcies = new OrderItemServices(new OrderRepository(new StationeryContext()),);
            //int availableQuantityToYou = product.AvailableQuantity - orderServcies.GetProductQuantityInOrder(product.ProductId, orderId);
            TxtAvailableQuantity.Text = (product.AvailableQuantity).ToString();
            InputRequestedNum.Maximum = product.AvailableQuantity;
        }

        private void InputRequestedNum_ValueChanged(object sender, EventArgs e)
        {
            if (InputRequestedNum.Value > 0)
            {
                BtnAdd.Enabled = true;
            }
            else
            {
                BtnAdd.Enabled = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (InputRequestedNum.Value > 0)
            {
                orderItemServcies.Add(new OrderItem() { OrderId = orderId, ProductId = product.ProductId, Quantity = (int)InputRequestedNum.Value });
                Close();
            }
        }

        private void ProductDetails_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
