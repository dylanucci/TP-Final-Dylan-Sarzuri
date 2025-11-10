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
    public partial class AdminComprasUI : Form
    {
        private readonly ApiClient _client;
        private readonly IServiceProvider _serviceProvider;
        public AdminComprasUI(ApiClient client, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _client = client;
            _serviceProvider = serviceProvider;
        }

        private async void AdminComprasUI_Load(object sender, EventArgs e)
        {
            IEnumerable<CompraDTO> compras = new List<CompraDTO>();
            try
            {
                compras = await _client.ComprasAllAsync();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var adminUI = _serviceProvider.GetRequiredService<AdminUI>();
            adminUI.Show();
            this.Close();
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            var date1 = txtFecha1.Text;
            var date2 = txtFecha2.Text;

            var DateTime1 = Convert.ToDateTime(date1);
            var DateTime2 = Convert.ToDateTime(date2);


            IEnumerable<CompraDTO> comprasFiltro = new List<CompraDTO>();
            try
            {
                comprasFiltro = await _client.FiltroAsync(DateTime1, DateTime2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DataTable comprasTable = new DataTable();

            comprasTable.Columns.Add("Id");
            comprasTable.Columns.Add("ClienteID");
            comprasTable.Columns.Add("Fecha");
            comprasTable.Columns.Add("Hora");
            comprasTable.Columns.Add("Total");

            foreach (CompraDTO c in comprasFiltro)
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

        private void txtFecha1_TextChanged(object sender, EventArgs e)
        {
            Verify();
        }

        private void txtFecha2_TextChanged(object sender, EventArgs e)
        {
            Verify();
        }

        private void Verify()
        {
            if (txtFecha1.Text == "" && txtFecha2.Text == "")
            {
                btnFiltrar.Enabled = false;
            }
        }
    }
}
