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
    public partial class ComprasUI : Form
    {
        private ClienteDTO _clienteDTO;
        private readonly ApiClient _client;
        private readonly IServiceProvider _serviceProvider;
        public ComprasUI(ApiClient client, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _client = client;
            _serviceProvider = serviceProvider;
        }

        private async void ComprasUI_Load(object sender, EventArgs e)
        {
            IEnumerable<CompraDTO> compras = new List<CompraDTO>();
            try
            {
                compras = await _client.ClientesAll2Async(_clienteDTO.IdCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTable comprasTable = new DataTable();

            comprasTable.Columns.Add("Id");
            comprasTable.Columns.Add("ClienteID");
            comprasTable.Columns.Add("Fecha");
            comprasTable.Columns.Add("Hora");
            comprasTable.Columns.Add("Total");

            foreach (CompraDTO c in compras)
            {
                DataRow row = comprasTable.NewRow();

                var dateOnly = c.Fecha.ToString("dd/MM/yyyy");
                var hora = c.Fecha.ToString("HH:mm:ss");

                row["Id"] = c.IdCompra;
                row["ClienteId"] = c.ClienteId;
                row["Fecha"] = dateOnly;
                row["Hora"] = hora;
                row["Total"] = c.Total;

                comprasTable.Rows.Add(row);

            }

            dgClientes.DataSource = comprasTable;
        }

        public void SetCliente(ClienteDTO cliente)
        {
            _clienteDTO = cliente;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var clienteUI = _serviceProvider.GetRequiredService<ClienteUI>();
            clienteUI.SetCliente(this._clienteDTO);
            clienteUI.Show();
            this.Close();
        }
    }
}
