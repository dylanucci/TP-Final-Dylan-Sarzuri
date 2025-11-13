using Frontend.Client;
using Frontend.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Register : Form
    {
        private readonly ApiClient _client;
        private readonly IServiceProvider _serviceProvider;
        public Register(ApiClient client, IServiceProvider serviceProvider)
        {
            _client = client;
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegistrarse_Click(object sender, EventArgs e)
        {
            ClienteUI clienteUI = _serviceProvider.GetRequiredService<ClienteUI>();

            if (int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("El telefono no puede contener letras");
                return;
            };
            var clienteDTO = new ClienteDTO()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = telefono,
                Email = txtEmail.Text,
                Contraseña = txtContraseña.Text
            };

            try
            {
                var clienteCreated = await _client.ClientesPOSTAsync(clienteDTO);

                MessageBox.Show($"Registro Exitoso\nId: {clienteCreated.IdCliente}\nNombre: {clienteCreated.Nombre}");
                clienteUI.SetCliente(clienteDTO);
                clienteUI.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
