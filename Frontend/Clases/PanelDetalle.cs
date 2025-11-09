using Frontend.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Clases
{
    public class PanelDetalle
    {
        public Panel panel = new Panel();
        private Label lblName = new Label();
        private Label lblPrice = new Label();
        private Label lblQuantity = new Label();
        private Label lblX = new Label();
        private Label lblSubTotal = new Label();
        private DetalleDTO _detalle;

        public PanelDetalle(DetalleDTO detalle)
        {
            _detalle = detalle;
            _detalle.SubTotal = _detalle.PrecioUnitario * _detalle.Cantidad;
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(lblQuantity);
            panel.Controls.Add(lblX);
            panel.Controls.Add(lblSubTotal);

            this.ConfigSize();
            this.SetLabels();
            this.ConfigFontStyle();
            this.ConfigLocation();
        }

        private void SetLabels()
        {
            lblX.Text = "X";
            lblName.Text = _detalle.Producto.Nombre;
            lblPrice.Text = _detalle.Producto.Precio.ToString() + "$";
            lblQuantity.Text = _detalle.Cantidad.ToString();
            lblSubTotal.Text = _detalle.SubTotal.ToString() + "$";
        }

        private void ConfigLocation()
        {
            lblQuantity.Location = new Point(3, 7);
            lblX.Location = new Point(30, 7);
            lblPrice.Location = new Point(52,7);
            lblName.Location = new Point(0, 25);
            lblSubTotal.Location = new Point(529, 28);
        }

        private void ConfigFontStyle()
        {
            lblPrice.Font = new Font("Tahoma", 12, FontStyle.Regular);
            lblName.Font = new Font("Sitka Text", 14, FontStyle.Regular);
            lblQuantity.Font = new Font("Tahoma", 12, FontStyle.Regular);
            lblX.Font = new Font("Tahoma", 12, FontStyle.Regular);
            lblSubTotal.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void ConfigSize()
        {
            lblName.AutoSize = true;
            lblPrice.AutoSize = true;
            lblQuantity.AutoSize = true;
            lblX.AutoSize = true;
            lblSubTotal.AutoSize = true;
            panel.Size = new Size(606,54);
        }
    }
}
