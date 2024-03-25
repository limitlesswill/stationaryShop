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
using System.Xml.Linq;

namespace Stationary_Presentation
{
    public partial class ProductCRUD : Form
    {
        private readonly IProductServices _productServices;
        private readonly ICategoryServices _categoryServices;
        public ProductCRUD(ICategoryServices categoryServices, IProductServices productServices)
        {
            InitializeComponent();
            _categoryServices = categoryServices;
            _productServices = productServices;
            PopulateCategoryComboBox();
            RefreshProductList();
           
        }
        private void PopulateCategoryComboBox()
        {
            List<Category> categories = _categoryServices.GetAll();
            ProductCategory.DataSource = categories;
            ProductCategory.DisplayMember = "Name";
            ProductCategory.ValueMember = "CategoryId";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = ProductName.Text,
                Description = ProductDescription.Text,
            
                Price = Convert.ToDecimal(ProductPrice.Text),
                AvailableQuantity = Convert.ToInt32(ProductAvailableQuantity.Text)
            };

            _productServices.Add(product);
            RefreshProductList();
            
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ProductId"].Value);
                Product product = _productServices.GetById(productId);
                product.Name = ProductName.Text;
                product.Description = ProductDescription.Text;
                product.CategoryId = Convert.ToInt32(ProductCategory.SelectedValue);
                product.Price = Convert.ToDecimal(ProductPrice.Text);
                product.AvailableQuantity = Convert.ToInt32(ProductAvailableQuantity.Text);
                _productServices.Update(product);
                RefreshProductList();
               
            }

        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {

                int productId = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ProductId"].Value);
                Product product = _productServices.GetById(productId);
                _productServices.Delete(product);
                RefreshProductList();
               
            }

        }
        private void RefreshProductList()
        {
            dataGridViewProducts.DataSource = _productServices.GetAll();
            dataGridViewProducts.Columns["ProductId"].Visible = false;
            dataGridViewProducts.Columns["CategoryId"].Visible = false;
            resetButtons();
           
        }

        private void resetButtons()
        {

            ClearForm();
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnAddProduct.Enabled = true;
        }
        private void ClearForm()
        {
            ProductName.Clear();
            ProductDescription.Clear();
            ProductPrice.Clear();
            ProductAvailableQuantity.Clear();
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            // Enable the Update and Delete buttons if a row is selected
            ProductName.Text = dataGridViewProducts.SelectedRows[0].Cells["Name"].Value.ToString();
            ProductDescription.Text = dataGridViewProducts.SelectedRows[0].Cells["Description"].Value.ToString();
            ProductPrice.Text = dataGridViewProducts.SelectedRows[0].Cells["Price"].Value.ToString();
            ProductAvailableQuantity.Text = dataGridViewProducts.SelectedRows[0].Cells["AvailableQuantity"].Value.ToString();
            btnUpdateProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnAddProduct.Enabled = false;
        }

        private void ProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character (like backspace or delete)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If the pressed key is not a digit and not a control character, ignore it
                e.Handled = true;
            }
        }

        private void ProductAvailableQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character (like backspace or delete)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If the pressed key is not a digit and not a control character, ignore it
                e.Handled = true;
            }
        }

       
    }
}
