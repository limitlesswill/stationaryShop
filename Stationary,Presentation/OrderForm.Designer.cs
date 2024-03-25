namespace Stationary_Presentation
{
    partial class OrderForm
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
            dataGridViewOrders = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(117, 66);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(523, 241);
            dataGridViewOrders.TabIndex = 0;
            dataGridViewOrders.CellValueChanged += dataGridViewOrders_CellValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 24);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 1;
            label1.Text = "View Orders and Change Status";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewOrders);
            Name = "OrderForm";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOrders;
        private Label label1;
    }
}