using Microsoft.EntityFrameworkCore;
using Models.Application.Models;
using Models.Application.ViewModels;
using Stationery.Application.Services;
using Stationery.Application.Services.ServicesContracts;
using Stationery.Context.Context;
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

namespace Stationary_Presentation
{
    public partial class Cart : Form
    {
        public Cart(IOrderItemServices _OrderItemServices, int _userId)
        {
            InitializeComponent();
            OrderItemServices = _OrderItemServices;
            userId = _userId;
            order = _OrderItemServices.orderServices.GetOrCreateUnconfirmedOrder(_userId);
        }
        IOrderItemServices OrderItemServices;
        Order order;
        int userId;
        int pageNumber = 0;
        int maxPageNumbers;
        private void Cart_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            DeterminePViewDataSourse();
        }
        private void DeterminePViewDataSourse()
        {
            order = OrderItemServices.orderServices.GetOrCreateUnconfirmedOrder(userId);
            PaginationResultViewModel<OrderItem> res = OrderItemServices.Pagination(10, pageNumber, order.OrderItems);
            ProductView.DataSource = res.Entities;
            maxPageNumbers = res.TotalPagesCount;
            ProductView.Columns["ProductId"].Visible = false;
            ProductView.Columns["Id"].Visible = false;
            ProductView.Columns["OrderId"].Visible = false;
            ProductView.Columns[2].Width = 200;
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "delete_column";
            uninstallButtonColumn.UseColumnTextForButtonValue = true;
            uninstallButtonColumn.Text = "Delete";
            TxtTotalPrice.Text = $"{order.TotalAmount:C}";
            if (ProductView.Columns["delete_column"] == null)
            {
                ProductView.Columns.Insert(6, uninstallButtonColumn);
            }
            determinePaginationWork();
        }
        void determinePaginationWork()
        {
            if (pageNumber < maxPageNumbers - 1)
            {
                BtnNext.Enabled = true;
            }
            else
            {
                BtnNext.Enabled = false;
            }
            if (pageNumber > 0)
            {
                BtnPrev.Enabled = true;
            }
            else
            {
                BtnPrev.Enabled = false;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (pageNumber < maxPageNumbers - 1)
            {
                pageNumber++;
                DeterminePViewDataSourse();
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (pageNumber > 0)
            {
                pageNumber--;
                DeterminePViewDataSourse();
            }
        }

        private void ProductView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Product product = OrderItemServices.productServices.GetById((int)ProductView.SelectedRows[0].Cells["ProductId"].Value);
            Form productDetails = new ProductDetails(product, OrderItemServices, OrderItemServices.orderServices.GetOrCreateUnconfirmedOrder(userId).OrderId, (object sender, FormClosedEventArgs e) =>
            {
                DeterminePViewDataSourse();
            });
            Hide();
            productDetails.ShowDialog();
            Show();
        }

        private void ProductView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProductView.Columns["delete_column"].Index)
            {
                OrderItemServices.Delete(OrderItemServices.GetById((int)ProductView.SelectedRows[0].Cells["Id"].Value));
                DeterminePViewDataSourse();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderItemServices.orderServices.ConfirmOrder(order.OrderId);
            Close();
        }
    }
}
