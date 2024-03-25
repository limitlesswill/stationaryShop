namespace Stationary_Presentation
{
    partial class Shop
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
            ProductView = new DataGridView();
            BtnNext = new Button();
            BtnPrev = new Button();
            TxtNameSearch = new TextBox();
            LblNameSearch = new Label();
            comboBoxCategory = new ComboBox();
            LblCategorySearch = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductView).BeginInit();
            SuspendLayout();
            // 
            // ProductView
            // 
            ProductView.AllowUserToAddRows = false;
            ProductView.AllowUserToDeleteRows = false;
            ProductView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProductView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductView.Location = new Point(1, 65);
            ProductView.MultiSelect = false;
            ProductView.Name = "ProductView";
            ProductView.ReadOnly = true;
            ProductView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductView.Size = new Size(543, 279);
            ProductView.TabIndex = 0;
            ProductView.MouseDoubleClick += ProductView_MouseDoubleClick;
            // 
            // BtnNext
            // 
            BtnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnNext.Location = new Point(279, 350);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(75, 23);
            BtnNext.TabIndex = 1;
            BtnNext.Text = "More";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnPrev
            // 
            BtnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnPrev.Enabled = false;
            BtnPrev.Location = new Point(192, 350);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(75, 23);
            BtnPrev.TabIndex = 2;
            BtnPrev.Text = "Previous";
            BtnPrev.UseVisualStyleBackColor = true;
            BtnPrev.Click += BtnPrev_Click;
            // 
            // TxtNameSearch
            // 
            TxtNameSearch.Location = new Point(129, 12);
            TxtNameSearch.Name = "TxtNameSearch";
            TxtNameSearch.Size = new Size(100, 23);
            TxtNameSearch.TabIndex = 4;
            TxtNameSearch.TextChanged += TxtNameSearch_TextChanged;
            // 
            // LblNameSearch
            // 
            LblNameSearch.AutoSize = true;
            LblNameSearch.Location = new Point(23, 15);
            LblNameSearch.Name = "LblNameSearch";
            LblNameSearch.Size = new Size(90, 15);
            LblNameSearch.TabIndex = 5;
            LblNameSearch.Text = "search by name";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(375, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 6;
            comboBoxCategory.SelectedValueChanged += comboBoxCategory_SelectedValueChanged;
            // 
            // LblCategorySearch
            // 
            LblCategorySearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LblCategorySearch.AutoSize = true;
            LblCategorySearch.Location = new Point(279, 15);
            LblCategorySearch.Name = "LblCategorySearch";
            LblCategorySearch.Size = new Size(74, 15);
            LblCategorySearch.TabIndex = 7;
            LblCategorySearch.Text = "filter by item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(85, 50);
            label1.Name = "label1";
            label1.Size = new Size(343, 12);
            label1.TabIndex = 8;
            label1.Text = "to see more details about a product and add it to your cart double click on it";
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 385);
            Controls.Add(label1);
            Controls.Add(LblCategorySearch);
            Controls.Add(comboBoxCategory);
            Controls.Add(LblNameSearch);
            Controls.Add(TxtNameSearch);
            Controls.Add(BtnPrev);
            Controls.Add(BtnNext);
            Controls.Add(ProductView);
            Name = "Shop";
            Text = "Shop";
            Load += Shop_Load;
            ((System.ComponentModel.ISupportInitialize)ProductView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductView;
        private Button BtnNext;
        private Button BtnPrev;
        private TextBox TxtNameSearch;
        private Label LblNameSearch;
        private ComboBox comboBoxCategory;
        private Label LblCategorySearch;
        private Label label1;
    }
}