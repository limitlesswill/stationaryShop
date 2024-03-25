using Models.Application.Models;
using Models.Application.ViewModels;
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
    public partial class FollowMyOrders : Form
    {
        public FollowMyOrders(IOrderServices _orderServices, int _userId)
        {
            InitializeComponent();
            orderServices = _orderServices;
            userId = _userId;
        }
        IOrderServices orderServices;
        int userId;
        int pageNumber = 0;
        int maxPageNumbers;
        private void FollowMyOrders_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            DeterminePViewDataSourse();
        }
        private void DeterminePViewDataSourse()
        {
            PaginationResultViewModel<Order> res = orderServices.Pagination(10, pageNumber, orderServices.GetByUser(userId));
            ProductView.DataSource = res.Entities;
            maxPageNumbers = res.TotalPagesCount;
            ProductView.Columns["UserId"].Visible = false;
            ProductView.Columns["User"].Visible = false;
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
    }
}
