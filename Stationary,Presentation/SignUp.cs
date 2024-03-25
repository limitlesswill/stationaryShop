using Autofac;
using Autofac.Core;
using Models.Application.Models;
using Stationary_Presentation.Autofac;
using Stationery.Application.Services.ServicesContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Stationary_Presentation
{
    public partial class SignUp : Form
    {
        IUserServices _UserService;

        public SignUp(IUserServices UserService)
        {
            InitializeComponent();
            _UserService = UserService;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserName = UserNameTextBox.Text,
                Password = PasswordTextBox.Text,
                Email = EmailTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
            };

            User addedUser = _UserService.SignUp(user);
                PasswordTextBox.Text="";
            UserNameTextBox.Text    ="";
                EmailTextBox.Text   ="";
                PhoneTextBox.Text   ="";
            AddressTextBox.Text = "";

            if (addedUser != null)
            {
                var container = AutofacConfig.BuildContainer();
                Hide();
                container.Resolve<UserHomePage>(new NamedParameter("userId", addedUser.Id)).ShowDialog();
                Show();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            var container = AutofacConfig.BuildContainer();
            Hide();
            container.Resolve<Login>().ShowDialog();
            Close();
        }
    }
}
