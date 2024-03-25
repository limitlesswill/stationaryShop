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
    public partial class CategoryCRUD : Form
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryCRUD(ICategoryServices categoryServices)
        {
            InitializeComponent();
            _categoryServices = categoryServices;
            RefreshCategoryList();
            // Initially disable the Update and Delete buttons
            //btnUpdateCategory.Enabled = false;
            //btnDeleteCategory.Enabled = false;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                // Populate category properties from UI controls
                Name = CategoryName.Text,
               

            
            };
            _categoryServices.Add(category);

            // Refresh category list after adding
            RefreshCategoryList();
        }



        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                int categoryId = Convert.ToInt32(dataGridViewCategories.SelectedRows[0].Cells["CategoryId"].Value);
                Category category = _categoryServices.GetById(categoryId);
                category.Name = CategoryName.Text;

                _categoryServices.Update(category);
                RefreshCategoryList();
            }
        }

       

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                int categoryId = Convert.ToInt32(dataGridViewCategories.SelectedRows[0].Cells["CategoryId"].Value);
                Category category = _categoryServices.GetById(categoryId);
                _categoryServices.Delete(category);
                RefreshCategoryList();

            }
        }

        private void RefreshCategoryList()
        {
            // Refresh category list from the database and bind to dataGridViewCategories
            dataGridViewCategories.DataSource = _categoryServices.GetAll();
            dataGridViewCategories.Columns["CategoryId"].Visible = false;
            resetButtons();
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            // Enable the Update and Delete buttons if a row is selected
            CategoryName.Text = dataGridViewCategories.SelectedRows[0].Cells["Name"].Value.ToString();
            btnUpdateCategory.Enabled = true;
            btnDeleteCategory.Enabled = true;
            btnAddCategory.Enabled = false;
        }
        private void resetButtons()
        {

            CategoryName.Text = "";
            btnUpdateCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;
            btnAddCategory.Enabled = true;
        }
    }
}
