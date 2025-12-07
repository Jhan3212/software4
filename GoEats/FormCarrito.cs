using System;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            // No carga items directamente; se agregan desde FormMenu
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (flowCarrito.Controls.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal total = 0;
            foreach (CardCarrito item in flowCarrito.Controls)
            {
                decimal precio = decimal.Parse(item.lblPrecio.Text.Replace("$", "").Trim());
                int cantidad = int.Parse(item.lblCantidad.Text.Replace("Cantidad:", "").Trim());
                total += precio * cantidad;
            }

            MessageBox.Show($"Gracias por tu compra.\nTotal pagado: ${total:0.00}", "Compra realizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            flowCarrito.Controls.Clear();
            lblTotal.Text = "Total: $0.00";
        }

        public void ActualizarTotal()
        {
            decimal total = 0;
            foreach (CardCarrito item in flowCarrito.Controls)
            {
                decimal precio = decimal.Parse(item.lblPrecio.Text.Replace("$", "").Trim());
                int cantidad = int.Parse(item.lblCantidad.Text.Replace("Cantidad:", "").Trim());
                total += precio * cantidad;
            }

            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }
    }
}
