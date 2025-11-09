using Frontend.Clases;
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
    public partial class ClienteCompraUI : Form
    {
        private IEnumerable<DetalleDTO> Detalles;
        private readonly IServiceProvider _serviceProvider;
        private readonly ApiClient _client;
        private ClienteDTO _clienteDTO;
        private ClienteUI _clienteUI;
        private int Total;
        public ClienteCompraUI(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _client = _serviceProvider.GetRequiredService<ApiClient>();
            Detalles = ClienteUI.Detalles;
            InitializeComponent();
        }

        private void ClienteCompraUI_Load(object sender, EventArgs e)
        {
            int LocationY = 91;
            foreach (var detalle in ClienteUI.Detalles)
            {
                var panelDetalle = new PanelDetalle(detalle);
                this.Controls.Add(panelDetalle.panel);

                panelDetalle.panel.Location = new Point(82, LocationY);
                LocationY = LocationY + 65;
                this.Total += detalle.SubTotal;
            }

            lblTotal.Text = this.Total.ToString() + "$";
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            var detalles = new List<DetalleDTO>();

            foreach(DetalleDTO i in ClienteUI.Detalles)
            {
                detalles.Add(i);
            }
            var dateTime = DateTime.Now;

            var compraDTO = new CompraDTO
            {
                ClienteId = _clienteDTO.IdCliente,
                Detalles = detalles,
                Fecha = dateTime,
                Total = this.Total
            };

            try
            {
                await _client.MakePurchaseAsync(compraDTO);
                MessageBox.Show("Compra Exitosa");
                _clienteUI.Reset();
                _clienteUI.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetCliente(ClienteDTO cliente, ClienteUI clienteUI)
        {
            _clienteDTO = cliente;
            _clienteUI = clienteUI;

        }
    }
}
