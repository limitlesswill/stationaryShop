namespace Stationary_Presentation
{
    partial class SignUp
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
            AddressLabel = new Label();
            EmailLabel = new Label();
            PhoneLabel = new Label();
            PasseordLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            EmailTextBox = new TextBox();
            AddressTextBox = new TextBox();
            SignUpButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpLabel.Location = new Point(356, 45);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(127, 35);
            SignUpLabel.TabIndex = 0;
            SignUpLabel.Text = "Sign Up";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(147, 110);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(117, 24);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "User Name:";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressLabel.Location = new Point(147, 317);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(89, 24);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "Address:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(147, 265);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(67, 24);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "Email:";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.Location = new Point(147, 212);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(77, 24);
            PhoneLabel.TabIndex = 4;
            PhoneLabel.Text = "Phone :";
            // 
            // PasseordLabel
            // 
            PasseordLabel.AutoSize = true;
            PasseordLabel.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasseordLabel.Location = new Point(147, 162);
            PasseordLabel.Name = "PasseordLabel";
            PasseordLabel.Size = new Size(101, 24);
            PasseordLabel.TabIndex = 5;
            PasseordLabel.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(299, 107);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(292, 27);
            UserNameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(299, 159);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(292, 27);
            PasswordTextBox.TabIndex = 7;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(299, 209);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(292, 27);
            PhoneTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(299, 262);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(292, 27);
            EmailTextBox.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(299, 317);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(292, 27);
            AddressTextBox.TabIndex = 10;
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButton.Location = new Point(299, 365);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(292, 33);
            SignUpButton.TabIndex = 11;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 410);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 12;
            label1.Text = "Already have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(483, 410);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 13;
            label2.Text = "Log in";
            label2.Click += label2_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SignUpButton);
            Controls.Add(AddressTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasseordLabel);
            Controls.Add(PhoneLabel);
            Controls.Add(EmailLabel);
            Controls.Add(AddressLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(SignUpLabel);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignUpLabel;
        private Label UserNameLabel;
        private Label AddressLabel;
        private Label EmailLabel;
        private Label PhoneLabel;
        private Label PasseordLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private TextBox PhoneTextBox;
        private TextBox EmailTextBox;
        private TextBox AddressTextBox;
        private Button SignUpButton;
        private Label label1;
        private Label label2;
    }
}