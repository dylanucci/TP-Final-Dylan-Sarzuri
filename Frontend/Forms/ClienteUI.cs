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
using System.Security.Cryptography.X509Certificates;
using Frontend.Clases;

namespace Frontend.Forms
{
    public partial class ClienteUI : Form
    {

        private ClienteDTO _clienteDTO = new ClienteDTO();
        private readonly IServiceProvider _serviceProvider;
        private readonly ApiClient _client;
        private List<PanelProducto> paneles = new List<PanelProducto>();
        public static List<DetalleDTO> Detalles = new List<DetalleDTO>();

        public ClienteUI(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
            this._client = serviceProvider.GetRequiredService<ApiClient>();
            InitializeComponent();
        }

        private async void ClienteUI_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _clienteDTO.Nombre;


            btnRealizar.Enabled = false;
            Label lblLoading = new Label();
            lblLoading.Visible = true;
            lblLoading.Text = "Loading...";
            lblLoading.Font = new Font("Sitka Text", 20, FontStyle.Regular);
            lblLoading.Location = new Point(326, 159);
            lblLoading.AutoSize = true;
            this.Controls.Add(lblLoading);

            IEnumerable<ProductoDTO> productosDTO = new List<ProductoDTO>();
            try
            {
                await Task.Delay(3000);
                productosDTO = await _client.ProductosAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lblLoading.Visible = false;
            var LocationY = 57;

            foreach (var i in productosDTO)
            {
                var panelProducto = new PanelProducto(i);
                paneles.Add(panelProducto);

                this.Controls.Add(panelProducto.panel);

                panelProducto.panel.Location = new Point(100, LocationY);

                LocationY = LocationY + 62;

                panelProducto.lblCounter.TextChanged += CheckDetails;
            }

        }

        public void SetCliente(ClienteDTO clienteDTO)
        {
            this._clienteDTO = clienteDTO;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            var configUI = _serviceProvider.GetRequiredService<ConfigCliente>();
            configUI.SetCliente(this._clienteDTO);
            configUI.Show();
            this.Hide();

        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            var compraUI = _serviceProvider.GetRequiredService<ClienteCompraUI>();
            compraUI.SetCliente(this._clienteDTO, this);
            this.Hide();
            compraUI.Show();
        }

        private void CheckDetails(object sender, EventArgs e)
        {
            if (Detalles.Count != 0)
            {
                btnRealizar.Enabled = true;
            }
            else if (Detalles.Count == 0)
            {
                btnRealizar.Enabled = false;
            }
        }

        public void Reset()
        {
            foreach(var i in paneles)
            {
                i.counter = 0;
                i.Verify();
            }
            btnRealizar.Enabled = false;
        }
    }
}
