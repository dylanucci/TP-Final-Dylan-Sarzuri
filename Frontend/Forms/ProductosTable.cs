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
    public partial class ProductosTable : Form
    {
        private readonly ApiClient _client;
        private readonly IServiceProvider _serviceProvider;
        public ProductosTable(ApiClient client, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _client = client;
            InitializeComponent();
        }

        private async void ProductosTable_Load(object sender, EventArgs e)
        {
            IEnumerable<ProductoDTO> productos = new List<ProductoDTO>();
            try
            {
                productos = await _client.ProductosAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var productosTable = new DataTable();

            productosTable.Columns.Add("Id");
            productosTable.Columns.Add("Nombre");
            productosTable.Columns.Add("Precio");

            foreach (ProductoDTO c in productos)
            {
                DataRow row = productosTable.NewRow();
                row["Id"] = c.IdProducto;
                row["Nombre"] = c.Nombre;
                row["Precio"] = c.Precio;

                productosTable.Rows.Add(row);
            }

            dgProductos.DataSource = productosTable;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var adminUI = _serviceProvider.GetRequiredService<AdminUI>();
            adminUI.Show();
            this.Close();
        }
    }
}
