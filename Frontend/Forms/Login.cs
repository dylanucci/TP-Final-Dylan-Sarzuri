using Frontend.Client;
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
    public partial class Login : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ApiClient _client;
        public Login(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _client = serviceProvider.GetRequiredService<ApiClient>();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                var loginRequest = new LoginRequest();

                loginRequest.Email = txtEmail.Text;
                loginRequest.Password = txtContraseña.Text;

                var clienteLogeado = await _client.LoginAsync(loginRequest);
                var clienteUI = this._serviceProvider.GetRequiredService<ClienteUI>();
                clienteUI.SetCliente(clienteLogeado);
                clienteUI.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
