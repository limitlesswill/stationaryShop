using Stationary_Presentation.Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Stationery.Application.Services.ServicesContracts;
using Models.Application.Models;
using Models.Application.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stationary_Presentation
{
    public partial class Login : Form
    {
        private readonly IUserServices _UserService;

        public Login(IUserServices UserService)
        {
            InitializeComponent();
            _UserService = UserService;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var container = AutofacConfig.BuildContainer();
            Hide();
            container.Resolve<SignUp>().ShowDialog();
            Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = TextBox2.Text;
            User? loginUser = _UserService.Login(UserName, Password);

            if (loginUser != null)
            {
                textBox1.Text = "";
                TextBox2.Text = "";
                var container = AutofacConfig.BuildContainer();
                Hide();
                
                if (loginUser.Role == Role.admin)
                {
                    container.Resolve<AdminHomePage>().ShowDialog();

                }
                else
                {
                    container.Resolve<UserHomePage>(new NamedParameter("userId", loginUser.Id)).ShowDialog();
                }
            }
            Show();
        }
    }
}
