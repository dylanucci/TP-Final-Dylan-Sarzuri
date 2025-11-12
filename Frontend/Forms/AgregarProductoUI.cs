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
    public partial class AgregarProductoUI : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ApiClient _client;
        private IEnumerable<CategoriaDTO> categorias;
        public AgregarProductoUI(IServiceProvider service, ApiClient client)
        {
            _client = client;
            _serviceProvider = service;
            InitializeComponent();
        }

        private async void AgregarProductoUI_Load(object sender, EventArgs e)
        {
            try
            {
                this.categorias = await _client.CategoriasAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            foreach (CategoriaDTO categoria in categorias)
            {
                cbCategorias.Items.Add(categoria.Nombre);
            }



        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            var categoria = this.categorias.FirstOrDefault(c => c.Nombre == cbCategorias.SelectedItem.ToString());

            var productoNew = new ProductoDTO()
            {
                Nombre = txtNombre.Text,
                Precio = Convert.ToInt16(txtPrecio.Text),
                CategoriaId = categoria.IdCategoria
            };

            try
            {
                await _client.ProductosPOSTAsync(productoNew);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            var productosUI = _serviceProvider.GetRequiredService<ProductosTable>();
            productosUI.Show();
            this.Close();
        }
    }
}
