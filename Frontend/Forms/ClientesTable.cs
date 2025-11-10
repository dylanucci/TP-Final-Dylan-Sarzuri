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
    public partial class ClientesTable : Form
    {
        private readonly ApiClient _client;
        private readonly IServiceProvider _serviceProvider;
        public ClientesTable(ApiClient client, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _client = client;
            InitializeComponent();
        }

        private async void ClientesTable_Load(object sender, EventArgs e)
        {
            IEnumerable<ClienteDTO> clientes = new List<ClienteDTO>();
            try
            {
                clientes = await _client.ClientesAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTable clientesTable = new DataTable();

            clientesTable.Columns.Add("Id");
            clientesTable.Columns.Add("Nombre");
            clientesTable.Columns.Add("Apellido");
            clientesTable.Columns.Add("Telefono");
            clientesTable.Columns.Add("Email");

            foreach (ClienteDTO c in clientes)
            {
                DataRow row = clientesTable.NewRow();
                row["Id"] = c.IdCliente;
                row["Nombre"] = c.Nombre;
                row["Apellido"] = c.Apellido;
                row["Telefono"] = c.Telefono;
                row["Email"] = c.Email;

                clientesTable.Rows.Add(row);

            }

            dgClientes.DataSource = clientesTable;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var adminUI = _serviceProvider.GetRequiredService<AdminUI>();
            adminUI.Show();
            this.Close();
        }
    }
}
