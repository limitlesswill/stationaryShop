using Models.Application.Models;
using Stationery.Application.Services;
using Stationery.Application.Services.ServicesContracts;
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
    public partial class OrderForm : Form
    {
        private readonly IOrderServices _orderServices;
        private List<Order> _orders;

        public OrderForm(IOrderServices orderServices)
        {
            InitializeComponent();
            _orderServices = orderServices;
            PopulateOrderGrid();
        }

        private void PopulateOrderGrid()
        {
            try
            {
                // Fetch orders from the database
                _orders = _orderServices.GetAll();

                // Bind orders to DataGridView
                dataGridViewOrders.DataSource = _orders;
                dataGridViewOrders.Columns["OrderId"].Visible = false;
                dataGridViewOrders.Columns["UserId"].Visible = false;
                //dataGridViewOrders.Columns["User"].Visible = false;
                // Add ComboBox column for order status
                if (dataGridViewOrders.Columns.Count<7)
                {
                    DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
                    statusColumn.HeaderText = "Status";
                    statusColumn.Name = "Status";
                    statusColumn.DataSource = Enum.GetValues(typeof(OrderStatus));
                    dataGridViewOrders.Columns.Add(statusColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewOrders.Columns["Status"].Index)
                {
                    DataGridViewComboBoxCell statusCell = dataGridViewOrders.Rows[e.RowIndex].Cells["Status"] as DataGridViewComboBoxCell;
                    Order order = _orders[e.RowIndex];
                    order.Status = statusCell.Value.ToString() == "Unconfirmed" ?OrderStatus.Unconfirmed: statusCell.Value.ToString() == "Shipped" ? OrderStatus.Shipped: statusCell.Value.ToString() == "Processing" ? OrderStatus.Processing: statusCell.Value.ToString() == "Pending" ? OrderStatus.Pending: statusCell.Value.ToString() == "Delivered" ? OrderStatus.Delivered: OrderStatus.Cancelled;

                    // Update order status in database
                    _orderServices.UpdateOrderStatus(order.OrderId, order.Status);
                PopulateOrderGrid();
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error updating order status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

      
    }
}
