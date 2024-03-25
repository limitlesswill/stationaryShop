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
using Stationery.Application.Services;
using Stationery.Application.Services.ServicesContracts;

namespace Stationary_Presentation
{
    public partial class AdminHomePage : Form
    {
        ICategoryServices _CategoryServices;
        IProductServices _ProductServices;
        IOrderServices _OrderServices;
        public AdminHomePage( ICategoryServices categoryServices,
            IProductServices productServices, 
            IOrderServices orderServices)
        {
            InitializeComponent();
            _CategoryServices = categoryServices;
            _ProductServices = productServices;
            _OrderServices = orderServices;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var container = AutofacConfig.BuildContainer();
            Hide();
            new ProductCRUD(_CategoryServices,_ProductServices).ShowDialog();
            //container.Resolve<ProductCRUD>().ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var container = AutofacConfig.BuildContainer();
            Hide();
            new CategoryCRUD(_CategoryServices).ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var container = AutofacConfig.BuildContainer();
            Hide();
            new OrderForm(_OrderServices).ShowDialog();
            Show();
        }
    }
}
