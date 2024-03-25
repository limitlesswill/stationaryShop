namespace Stationary_Presentation
{
    partial class ProductDetails
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
            TxtProductName = new Label();
            LblDescription = new Label();
            LblCategory = new Label();
            TxtCategory = new Label();
            LblPrice = new Label();
            TxtPrice = new Label();
            LblAvailableQuantity = new Label();
            TxtAvailableQuantity = new Label();
            InputRequestedNum = new NumericUpDown();
            LblRequstedQuantity = new Label();
            BtnAdd = new Button();
            TxtDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)InputRequestedNum).BeginInit();
            SuspendLayout();
            // 
            // TxtProductName
            // 
            TxtProductName.Anchor = AnchorStyles.Top;
            TxtProductName.AutoSize = true;
            TxtProductName.Font = new Font("Segoe UI", 14F);
            TxtProductName.Location = new Point(99, 81);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(128, 25);
            TxtProductName.TabIndex = 0;
            TxtProductName.Text = "ProductName";
            // 
            // LblDescription
            // 
            LblDescription.Anchor = AnchorStyles.None;
            LblDescription.AutoSize = true;
            LblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblDescription.Location = new Point(45, 141);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(71, 15);
            LblDescription.TabIndex = 2;
            LblDescription.Text = "Description";
            // 
            // LblCategory
            // 
            LblCategory.Anchor = AnchorStyles.None;
            LblCategory.AutoSize = true;
            LblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblCategory.Location = new Point(45, 277);
            LblCategory.Name = "LblCategory";
            LblCategory.Size = new Size(57, 15);
            LblCategory.TabIndex = 4;
            LblCategory.Text = "Category";
            // 
            // TxtCategory
            // 
            TxtCategory.Anchor = AnchorStyles.None;
            TxtCategory.AutoSize = true;
            TxtCategory.Location = new Point(206, 277);
            TxtCategory.Name = "TxtCategory";
            TxtCategory.Size = new Size(55, 15);
            TxtCategory.TabIndex = 5;
            TxtCategory.Text = "Category";
            // 
            // LblPrice
            // 
            LblPrice.Anchor = AnchorStyles.None;
            LblPrice.AutoSize = true;
            LblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblPrice.Location = new Point(45, 328);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(35, 15);
            LblPrice.TabIndex = 6;
            LblPrice.Text = "Price";
            // 
            // TxtPrice
            // 
            TxtPrice.Anchor = AnchorStyles.None;
            TxtPrice.AutoSize = true;
            TxtPrice.Location = new Point(206, 328);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(33, 15);
            TxtPrice.TabIndex = 7;
            TxtPrice.Text = "Price";
            // 
            // LblAvailableQuantity
            // 
            LblAvailableQuantity.Anchor = AnchorStyles.None;
            LblAvailableQuantity.AutoSize = true;
            LblAvailableQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblAvailableQuantity.Location = new Point(45, 379);
            LblAvailableQuantity.Name = "LblAvailableQuantity";
            LblAvailableQuantity.Size = new Size(108, 15);
            LblAvailableQuantity.TabIndex = 8;
            LblAvailableQuantity.Text = "Available Quantity";
            // 
            // TxtAvailableQuantity
            // 
            TxtAvailableQuantity.Anchor = AnchorStyles.None;
            TxtAvailableQuantity.AutoSize = true;
            TxtAvailableQuantity.Location = new Point(206, 379);
            TxtAvailableQuantity.Name = "TxtAvailableQuantity";
            TxtAvailableQuantity.Size = new Size(101, 15);
            TxtAvailableQuantity.TabIndex = 9;
            TxtAvailableQuantity.Text = "AvailableQuantity";
            // 
            // InputRequestedNum
            // 
            InputRequestedNum.Anchor = AnchorStyles.None;
            InputRequestedNum.Location = new Point(206, 430);
            InputRequestedNum.Name = "InputRequestedNum";
            InputRequestedNum.ReadOnly = true;
            InputRequestedNum.Size = new Size(120, 23);
            InputRequestedNum.TabIndex = 10;
            InputRequestedNum.TextAlign = HorizontalAlignment.Center;
            InputRequestedNum.ValueChanged += InputRequestedNum_ValueChanged;
            // 
            // LblRequstedQuantity
            // 
            LblRequstedQuantity.Anchor = AnchorStyles.None;
            LblRequstedQuantity.AutoSize = true;
            LblRequstedQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblRequstedQuantity.Location = new Point(45, 430);
            LblRequstedQuantity.Name = "LblRequstedQuantity";
            LblRequstedQuantity.Size = new Size(114, 15);
            LblRequstedQuantity.TabIndex = 11;
            LblRequstedQuantity.Text = "Requsted Quantity ";
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.None;
            BtnAdd.Enabled = false;
            BtnAdd.Location = new Point(126, 483);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 13;
            BtnAdd.Text = "Add To Cart";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TxtDescription
            // 
            TxtDescription.Anchor = AnchorStyles.None;
            TxtDescription.BorderStyle = BorderStyle.None;
            TxtDescription.Location = new Point(206, 141);
            TxtDescription.Name = "TxtDescription";
            TxtDescription.ReadOnly = true;
            TxtDescription.Size = new Size(162, 117);
            TxtDescription.TabIndex = 14;
            TxtDescription.Text = "fsdfdsfdsqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq\n";
            // 
            // ProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 550);
            Controls.Add(TxtDescription);
            Controls.Add(BtnAdd);
            Controls.Add(LblRequstedQuantity);
            Controls.Add(InputRequestedNum);
            Controls.Add(TxtAvailableQuantity);
            Controls.Add(LblAvailableQuantity);
            Controls.Add(TxtPrice);
            Controls.Add(LblPrice);
            Controls.Add(TxtCategory);
            Controls.Add(LblCategory);
            Controls.Add(LblDescription);
            Controls.Add(TxtProductName);
            Name = "ProductDetails";
            Text = "ProductDetails";
            Load += ProductDetails_Load;
            ((System.ComponentModel.ISupportInitialize)InputRequestedNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtProductName;
        private Label LblDescription;
        private Label LblCategory;
        private Label TxtCategory;
        private Label LblPrice;
        private Label TxtPrice;
        private Label LblAvailableQuantity;
        private Label TxtAvailableQuantity;
        private NumericUpDown InputRequestedNum;
        private Label LblRequstedQuantity;
        private Button BtnAdd;
        private RichTextBox TxtDescription;
    }
}