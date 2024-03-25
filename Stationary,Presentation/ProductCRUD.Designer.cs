namespace Stationary_Presentation
{
    partial class ProductCRUD
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
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            label2 = new Label();
            label1 = new Label();
            ProductName = new TextBox();
            ProductDescription = new TextBox();
            dataGridViewProducts = new DataGridView();
            ProductPrice = new TextBox();
            label3 = new Label();
            ProductAvailableQuantity = new TextBox();
            label4 = new Label();
            ProductCategory = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(302, 267);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 15;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(161, 267);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(75, 23);
            btnUpdateProduct.TabIndex = 14;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(28, 267);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 13;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 45);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 11;
            label1.Text = "Description";
            // 
            // ProductName
            // 
            ProductName.Location = new Point(116, 45);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(147, 23);
            ProductName.TabIndex = 10;
            // 
            // ProductDescription
            // 
            ProductDescription.Location = new Point(116, 83);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(147, 23);
            ProductDescription.TabIndex = 9;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(494, 22);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(294, 233);
            dataGridViewProducts.TabIndex = 8;
            dataGridViewProducts.MouseDoubleClick += dataGridViewProducts_SelectionChanged;
            // 
            // ProductPrice
            // 
            ProductPrice.Location = new Point(116, 124);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(147, 23);
            ProductPrice.TabIndex = 16;
            ProductPrice.KeyPress += ProductPrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 127);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 17;
            label3.Text = "Price";
            // 
            // ProductAvailableQuantity
            // 
            ProductAvailableQuantity.Location = new Point(116, 164);
            ProductAvailableQuantity.Name = "ProductAvailableQuantity";
            ProductAvailableQuantity.Size = new Size(147, 23);
            ProductAvailableQuantity.TabIndex = 18;
            ProductAvailableQuantity.KeyPress += ProductAvailableQuantity_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 167);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 19;
            label4.Text = "Available Quantity";
            // 
            // ProductCategory
            // 
            ProductCategory.FormattingEnabled = true;
            ProductCategory.Location = new Point(116, 209);
            ProductCategory.Name = "ProductCategory";
            ProductCategory.Size = new Size(147, 23);
            ProductCategory.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 217);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 21;
            label5.Text = "Category";
            // 
            // ProductCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(ProductCategory);
            Controls.Add(label4);
            Controls.Add(ProductAvailableQuantity);
            Controls.Add(label3);
            Controls.Add(ProductPrice);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProductName);
            Controls.Add(ProductDescription);
            Controls.Add(dataGridViewProducts);
            Name = "ProductCRUD";
            Text = "ProductCRUD";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private Label label2;
        private Label label1;
        private TextBox ProductName;
        private TextBox ProductDescription;
        private DataGridView dataGridViewProducts;
        private TextBox ProductPrice;
        private Label label3;
        private TextBox ProductAvailableQuantity;
        private Label label4;
        private ComboBox ProductCategory;
        private Label label5;
    }
}