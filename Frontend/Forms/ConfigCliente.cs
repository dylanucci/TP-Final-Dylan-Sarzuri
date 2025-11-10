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
    public partial class ConfigCliente : Form
    {
        private ClienteDTO _cliente;
        private readonly ApiClient _client;
        private readonly IServiceProvider _serviceProvider;
        public ConfigCliente(ApiClient client, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _client = client;
            InitializeComponent();

        }

        private void ConfigCliente_Load(object sender, EventArgs e)
        {
            txtNombre.TextChanged += HasChanged;
            txtApellido.TextChanged += HasChanged;
            txtTelefono.TextChanged += HasChanged;

            txtId.Text = _cliente.IdCliente.ToString();
            txtNombre.Text = _cliente.Nombre;
            txtApellido.Text = _cliente.Apellido;
            txtTelefono.Text = _cliente.Telefono;
        }

        public void SetCliente(ClienteDTO cliente)
        {
            _cliente = cliente;
        }


        private void HasChanged(object sender, EventArgs e)
        {
            btnActualizar.Enabled = true;
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            _cliente.Nombre = txtNombre.Text;
            _cliente.Apellido = txtApellido.Text;
            _cliente.Telefono = txtTelefono.Text;
            try
            {
                var clienteUpdated = await _client.ClientesPUTAsync(_cliente);
                MessageBox.Show("Cliente Actualizado con exito");
                this.Close();
                var clienteUI = _serviceProvider.GetRequiredService<ClienteUI>();
                clienteUI.SetCliente(clienteUpdated);
                clienteUI.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var clienteUI = _serviceProvider.GetRequiredService<ClienteUI>();
            clienteUI.SetCliente(this._cliente);
            clienteUI.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var principalUI = _serviceProvider.GetRequiredService<Principal>();
            this.Close();
            principalUI.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var comprasUI = _serviceProvider.GetRequiredService<ComprasUI>();
            comprasUI.SetCliente(_cliente);
            comprasUI.Show();
            this.Close();
        }
    }
}
