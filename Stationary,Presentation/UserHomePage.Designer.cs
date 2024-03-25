namespace Stationary_Presentation
{
    partial class UserHomePage
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
            BtnShop = new Button();
            BtnCart = new Button();
            BtnFollowUp = new Button();
            SuspendLayout();
            // 
            // BtnShop
            // 
            BtnShop.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnShop.Location = new Point(97, 87);
            BtnShop.Name = "BtnShop";
            BtnShop.Size = new Size(84, 23);
            BtnShop.TabIndex = 0;
            BtnShop.Text = "Shop";
            BtnShop.UseVisualStyleBackColor = true;
            BtnShop.Click += BtnShop_Click;
            // 
            // BtnCart
            // 
            BtnCart.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnCart.Location = new Point(97, 173);
            BtnCart.Name = "BtnCart";
            BtnCart.Size = new Size(84, 23);
            BtnCart.TabIndex = 1;
            BtnCart.Text = "My Cart";
            BtnCart.UseVisualStyleBackColor = true;
            BtnCart.Click += BtnCart_Click;
            // 
            // BtnFollowUp
            // 
            BtnFollowUp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnFollowUp.Location = new Point(97, 259);
            BtnFollowUp.Name = "BtnFollowUp";
            BtnFollowUp.Size = new Size(84, 23);
            BtnFollowUp.TabIndex = 2;
            BtnFollowUp.Text = "Follow Up";
            BtnFollowUp.UseVisualStyleBackColor = true;
            BtnFollowUp.Click += BtnFollowUp_Click;
            // 
            // UserHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 346);
            Controls.Add(BtnFollowUp);
            Controls.Add(BtnCart);
            Controls.Add(BtnShop);
            Name = "UserHomePage";
            Text = "UserHomePage";
            Load += UserHomePage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnShop;
        private Button BtnCart;
        private Button BtnFollowUp;
    }
}