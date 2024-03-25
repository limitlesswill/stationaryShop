using System.Windows.Forms;

namespace Stationary_Presentation
{
    partial class Cart
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
            BtnConfirm = new Button();
            LblTotalPrice = new Label();
            TxtTotalPrice = new Label();
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
            ProductView.Location = new Point(2, 33);
            ProductView.MultiSelect = false;
            ProductView.Name = "ProductView";
            ProductView.ReadOnly = true;
            ProductView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductView.Size = new Size(625, 201);
            ProductView.TabIndex = 0;
            ProductView.CellClick += ProductView_CellClick;
            ProductView.MouseDoubleClick += ProductView_MouseDoubleClick;
            // 
            // BtnNext
            // 
            BtnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnNext.Location = new Point(489, 284);
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
            BtnPrev.Location = new Point(54, 284);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(75, 23);
            BtnPrev.TabIndex = 2;
            BtnPrev.Text = "Previous";
            BtnPrev.UseVisualStyleBackColor = true;
            BtnPrev.Click += BtnPrev_Click;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.None;
            BtnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnConfirm.Location = new Point(277, 350);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(75, 23);
            BtnConfirm.TabIndex = 3;
            BtnConfirm.Text = "Confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += button1_Click;
            // 
            // LblTotalPrice
            // 
            LblTotalPrice.Anchor = AnchorStyles.None;
            LblTotalPrice.AutoSize = true;
            LblTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblTotalPrice.Location = new Point(223, 292);
            LblTotalPrice.Name = "LblTotalPrice";
            LblTotalPrice.Size = new Size(65, 15);
            LblTotalPrice.TabIndex = 4;
            LblTotalPrice.Text = "Total Price";
            // 
            // TxtTotalPrice
            // 
            TxtTotalPrice.Anchor = AnchorStyles.None;
            TxtTotalPrice.AutoSize = true;
            TxtTotalPrice.Location = new Point(348, 292);
            TxtTotalPrice.Name = "TxtTotalPrice";
            TxtTotalPrice.Size = new Size(33, 15);
            TxtTotalPrice.TabIndex = 5;
            TxtTotalPrice.Text = "Ptice";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(123, 18);
            label1.Name = "label1";
            label1.Size = new Size(371, 12);
            label1.TabIndex = 6;
            label1.Text = "to know more details about your products or increase its quantity double click on it";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 385);
            Controls.Add(label1);
            Controls.Add(TxtTotalPrice);
            Controls.Add(LblTotalPrice);
            Controls.Add(BtnConfirm);
            Controls.Add(BtnPrev);
            Controls.Add(BtnNext);
            Controls.Add(ProductView);
            Name = "Cart";
            Text = "My Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)ProductView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductView;
        private Button BtnNext;
        private Button BtnPrev;
        private Button BtnConfirm;
        private Label LblTotalPrice;
        private Label TxtTotalPrice;
        private Label label1;
        //private TextBox TxtNameSearch;
        //private Label LblNameSearch;
        //private ComboBox comboBoxCategory;
        //private Label LblCategorySearch;

    }
}