namespace Stationary_Presentation
{
    partial class Login
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
            SignUpLabel = new Label();
            UserNameLabel = new Label();
            PasseordLabel = new Label();
            TextBox2 = new TextBox();
            textBox1 = new TextBox();
            SignUpButton = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpLabel.Location = new Point(200, 23);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(102, 38);
            SignUpLabel.TabIndex = 1;
            SignUpLabel.Text = "Login";
            SignUpLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(12, 76);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(116, 25);
            UserNameLabel.TabIndex = 2;
            UserNameLabel.Text = "User Name:";
            // 
            // PasseordLabel
            // 
            PasseordLabel.AutoSize = true;
            PasseordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasseordLabel.Location = new Point(23, 129);
            PasseordLabel.Name = "PasseordLabel";
            PasseordLabel.Size = new Size(104, 25);
            PasseordLabel.TabIndex = 6;
            PasseordLabel.Text = "Password:";
            // 
            // TextBox2
            // 
            TextBox2.BorderStyle = BorderStyle.FixedSingle;
            TextBox2.Location = new Point(111, 123);
            TextBox2.Margin = new Padding(3, 2, 3, 2);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(256, 38);
            TextBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(111, 70);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 38);
            textBox1.TabIndex = 8;
            // 
            // SignUpButton
            // 
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButton.Location = new Point(111, 202);
            SignUpButton.Margin = new Padding(3, 2, 3, 2);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(256, 36);
            SignUpButton.TabIndex = 12;
            SignUpButton.Text = "Login";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(215, 295);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 15;
            label2.Text = "Signup";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 268);
            label1.Name = "label1";
            label1.Size = new Size(190, 18);
            label1.TabIndex = 14;
            label1.Text = "You don't have an account?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 359);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SignUpButton);
            Controls.Add(textBox1);
            Controls.Add(TextBox2);
            Controls.Add(PasseordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(SignUpLabel);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Login";
            ShowIcon = false;
            Text = "Login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignUpLabel;
        private Label UserNameLabel;
        private Label PasseordLabel;
        private TextBox TextBox2;
        private TextBox textBox1;
        private Button SignUpButton;
        private Label label2;
        private Label label1;
    }
}