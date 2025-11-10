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
    public partial class AdminUI : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public AdminUI(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var clientesUI = _serviceProvider.GetRequiredService<ClientesTable>();
            clientesUI.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var productosUI = _serviceProvider.GetRequiredService<ProductosTable>();
            productosUI.Show();
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            var comprasUI = _serviceProvider.GetRequiredService<AdminComprasUI>();
            comprasUI.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var principalUI = _serviceProvider.GetRequiredService<Principal>();
            principalUI.Show();
            this.Close();
        }
    }
}
