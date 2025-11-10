using Frontend.Client;
using Frontend.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Clases
{
    public class PanelProducto
    {
        public ProductoDTO producto;       
        public Button btnAgg = new Button();
        public Button btnSum = new Button();
        public Button btnRes = new Button();
        public Label lblCounter = new Label();
        public Label lblName = new Label();
        public Label lblPrice = new Label();
        public int counter = 0;
        public DetalleDTO detalle = new DetalleDTO();
        public Panel panel = new Panel();

        public PanelProducto(ProductoDTO productoDTO)
        {
            producto = productoDTO;
            detalle.ProductoId = producto.IdProducto;
            detalle.PrecioUnitario = producto.Precio;
            detalle.Producto = producto;

            panel.Controls.Add(btnAgg);
            panel.Controls.Add(btnSum);
            panel.Controls.Add(btnRes);
            panel.Controls.Add(lblCounter);
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblPrice);

            lblName.AutoSize = true;
            lblPrice.AutoSize = true;
            lblCounter.AutoSize = true;

            ConfigLabels();
            AddFunctions();
            ConfigFirstVisual();
            ConfigSize();
            ConfigLocation();
            ConfigFontStyle();
        }
        private void ConfigFirstVisual()
        {
            btnAgg.Visible = true;
            btnSum.Visible = false;
            btnRes.Visible = false;
            lblCounter.Visible = false;
        }

        private void AddFunctions()
        {
            btnSum.Click += SumUnitFunc;
            btnRes.Click += RestUnitFunc;
            btnAgg.Click += FirstAddFunc;
        }

        public void SumUnitFunc(object sender, EventArgs e)
        {
            counter = counter + 1;
            lblCounter.Text = counter.ToString();
            detalle.Cantidad = counter;
        }

        public void RestUnitFunc(object sender, EventArgs e)
        {
            counter = counter - 1;
            lblCounter.Text = counter.ToString();
            detalle.Cantidad = counter;
            Verify();
        }

        public void FirstAddFunc(object sender, EventArgs e)
        {
            btnAgg.Visible = false;
            btnSum.Visible = true;
            btnRes.Visible = true;
            lblCounter.Visible = true;


            ClienteUI.Detalles.Add(detalle);
            counter = counter + 1;
            detalle.Cantidad = counter;
            lblCounter.Text = counter.ToString(); 
        }

        public void Verify()
        {
            if (counter == 0)
            {
                btnAgg.Visible = true;
                btnSum.Visible = false;
                btnRes.Visible = false;
                lblCounter.Visible = false;
                ClienteUI.Detalles.Remove(detalle);
            }
        }


        public void ConfigLocation()
        {
            lblName.Location = new Point(16,0);
            lblPrice.Location = new Point(312,4);
            btnAgg.Location = new Point(495,0);
            btnSum.Location = new Point(495, 0);
            lblCounter.Location = new Point(539,0);
            btnRes.Location = new Point(575,0);
        }

        public void ConfigSize()
        {
            panel.Size = new Size(698, 34);
            btnAgg.Size = new Size(118, 30);
            btnSum.Size = new Size(27, 27);
            btnRes.Size = new Size(27, 27);
        }

        public void ConfigFontStyle()
        {
            lblName.Font = new Font("Sitka Text", 14, FontStyle.Regular);
            lblPrice.Font = new Font("Tahoma", 14, FontStyle.Regular);
            btnAgg.Font = new Font("Sitka Text", 12, FontStyle.Regular);
            btnSum.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnRes.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblCounter.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        public void ConfigLabels()
        {
            lblName.Text = producto.Nombre;
            lblPrice.Text = producto.Precio.ToString() + "$";
            btnAgg.Text = "Agregar";
            btnSum.Text = "+";
            btnRes.Text = "-";
        }
        
    }
}
