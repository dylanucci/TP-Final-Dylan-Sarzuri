using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Forms
{
    public partial class LoginOrRegisterUI : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public LoginOrRegisterUI(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }
        private void LoginOrRegisterUI_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var LoginUI = _serviceProvider.GetRequiredService<Login>();
            LoginUI.Show();
            this.Close();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            var RegisterUI = _serviceProvider.GetRequiredService<Register>();
            RegisterUI.Show();
            this.Close();
        }
    }
}
