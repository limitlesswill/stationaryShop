namespace Stationary_Presentation
{
    partial class CategoryCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeleteCategory = new Button();
            btnUpdateCategory = new Button();
            btnAddCategory = new Button();
            label2 = new Label();
            CategoryName = new TextBox();
            dataGridViewCategories = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(331, 260);
            btnDeleteCategory.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(86, 31);
            btnDeleteCategory.TabIndex = 7;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(182, 260);
            btnUpdateCategory.Margin = new Padding(3, 4, 3, 4);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(86, 31);
            btnUpdateCategory.TabIndex = 6;
            btnUpdateCategory.Text = "Update";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(47, 260);
            btnAddCategory.Margin = new Padding(3, 4, 3, 4);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(86, 31);
            btnAddCategory.TabIndex = 5;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 116);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // CategoryName
            // 
            CategoryName.Location = new Point(99, 112);
            CategoryName.Margin = new Padding(3, 4, 3, 4);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(167, 27);
            CategoryName.TabIndex = 2;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(554, 36);
            dataGridViewCategories.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCategories.MultiSelect = false;
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(336, 311);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.MouseDoubleClick += dataGridViewCategories_SelectionChanged;
            // 
            // CategoryCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 600);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnUpdateCategory);
            Controls.Add(btnAddCategory);
            Controls.Add(label2);
            Controls.Add(CategoryName);
            Controls.Add(dataGridViewCategories);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryCRUD";
            Text = "CategoryCRUD";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnDeleteCategory;
        private Button btnUpdateCategory;
        private Button btnAddCategory;
        private Label label2;
        private TextBox CategoryName;
        private DataGridView dataGridViewCategories;
    }
}