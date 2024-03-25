namespace Stationary_Presentation
{
    partial class FollowMyOrders
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
            ((System.ComponentModel.ISupportInitialize)ProductView).BeginInit();
            SuspendLayout();
            // 
            // ProductView
            // 
            ProductView.AllowUserToAddRows = false;
            ProductView.AllowUserToDeleteRows = false;
            ProductView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProductView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductView.Location = new Point(1, 87);
            ProductView.Margin = new Padding(3, 4, 3, 4);
            ProductView.MultiSelect = false;
            ProductView.Name = "ProductView";
            ProductView.ReadOnly = true;
            ProductView.RowHeadersWidth = 51;
            ProductView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductView.Size = new Size(507, 372);
            ProductView.TabIndex = 0;
            // 
            // BtnNext
            // 
            BtnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnNext.Location = new Point(206, 467);
            BtnNext.Margin = new Padding(3, 4, 3, 4);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(86, 31);
            BtnNext.TabIndex = 1;
            BtnNext.Text = "More";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnPrev
            // 
            BtnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnPrev.Enabled = false;
            BtnPrev.Location = new Point(219, 467);
            BtnPrev.Margin = new Padding(3, 4, 3, 4);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(86, 31);
            BtnPrev.TabIndex = 2;
            BtnPrev.Text = "Previous";
            BtnPrev.UseVisualStyleBackColor = true;
            BtnPrev.Click += BtnPrev_Click;
            // 
            // FollowMyOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 513);
            Controls.Add(BtnPrev);
            Controls.Add(BtnNext);
            Controls.Add(ProductView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FollowMyOrders";
            Text = "Follow up with  your order";
            Load += FollowMyOrders_Load;
            ((System.ComponentModel.ISupportInitialize)ProductView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductView;
        private Button BtnNext;
        private Button BtnPrev;
        //private TextBox TxtNameSearch;
        //private Label LblNameSearch;
        //private ComboBox comboBoxCategory;
        //private Label LblCategorySearch;

    }
}