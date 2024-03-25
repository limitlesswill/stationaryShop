using Microsoft.EntityFrameworkCore;
using Stationery.Application.Services;
using Stationery.Application.Services.ServicesContracts;
using Stationery.Context.Context;
using Stationery.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stationary_Presentation
{
    public partial class UserHomePage : Form
    {
        public UserHomePage(IProductServices _productServices, StationeryContext _context, int _userId = 1)
        {
            InitializeComponent();
            context = _context;
            userId = _userId;
            productServices = _productServices;
        }
        StationeryContext context;
        int userId;
        IProductServices productServices;
        private void BtnShop_Click(object sender, EventArgs e)
        {
            Form shop = new Shop(productServices, new CategoryServices(new CategoryRepository(context)), userId);
            Hide();
            shop.ShowDialog();
            Show();
        }

        private void BtnCart_Click(object sender, EventArgs e)
        {
            Form cart = new Cart(new OrderItemServices(new OrderItemRepository(context), new OrderServices(new OrderRepository(context)), productServices), userId/*, orderServices.GetOrCreateUnconfirmedOrder(userId).OrderId*/);
            Hide();
            cart.ShowDialog();
            Show();
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
        }

        private void BtnFollowUp_Click(object sender, EventArgs e)
        {
            Form followUp = new FollowMyOrders(new OrderServices(new OrderRepository(context)), userId/*, orderServices.GetOrCreateUnconfirmedOrder(userId).OrderId*/);
            Hide();
            followUp.ShowDialog();
            Show();
        }
    }
}
