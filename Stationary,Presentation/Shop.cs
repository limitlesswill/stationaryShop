using Models.Application.Models;
using Models.Application.ViewModels;
using Stationery.Application.Services;
using Stationery.Application.Services.ServicesContracts;
using Stationery.Infrastructure.Repositories;
using Stationery.Context.Context;
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
    public partial class Shop : Form
    {
        public Shop(IProductServices _productServices, ICategoryServices _categoryServices,int _userId)
        {
            InitializeComponent();
            productServices = _productServices;
            categoryServices = _categoryServices;
            userId = _userId;
        }
        IProductServices productServices;
        ICategoryServices categoryServices;
        int userId;
        int pageNumber = 0;
        int maxPageNumbers;
        int cat;
        string searchText;
        private void Shop_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            List<Category> categories = new List<Category>();
            categories.Add(new Category() { Name = "All", CategoryId = 0 });
            categories.AddRange(categoryServices.GetAll());
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CategoryId";
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
          if(pageNumber< maxPageNumbers-1) {
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
            StationeryContext context = new StationeryContext();
            Product product = productServices.GetById((int)ProductView.SelectedRows[0].Cells[0].Value);
            OrderServices orderServices = new OrderServices(new OrderRepository(context));
            Form productDetails = new ProductDetails(product,new OrderItemServices(new OrderItemRepository(context), orderServices, productServices), orderServices.GetOrCreateUnconfirmedOrder(userId).OrderId);
            Hide();
            productDetails.ShowDialog();
            Show();
        }

        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            pageNumber = 0;
            cat = ((Category)comboBoxCategory.SelectedItem).CategoryId;
            DeterminePViewDataSourse();
        }
        private void DeterminePViewDataSourse()
        {
            PaginationResultViewModel<Product> res;
            if (cat != 0)
            {
                res = productServices.Pagination(10, pageNumber, productServices.SearchByCategory(cat));
            }
            else if (searchText != null)
            {
                res = productServices.Pagination(10, pageNumber, productServices.SearchByName(searchText));
            }
            else
            {
                res = productServices.Pagination(10, pageNumber, productServices.GetAll());
            }
            ProductView.DataSource = res.Entities;
            maxPageNumbers = res.TotalPagesCount;
            ProductView.Columns["ProductId"].Visible = false;
            ProductView.Columns["CategoryId"].Visible = false;
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

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)
        {
            searchText = TxtNameSearch.Text;
            pageNumber = 0;
            comboBoxCategory.SelectedIndex=0;
            DeterminePViewDataSourse();
        }
    }
}
