using System;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
            this.Load += FormCarrito_Load;
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            CargarCarrito();
        }

        private void CargarCarrito()
        {
            if (Sesion.IdUsuario == 0) return;

            flowCarrito.Controls.Clear();

            var carritoDao = new CarritoDAO();
            var itemDao = new CarritoItemDAO();

            if (Sesion.IdCarrito == 0)
                Sesion.IdCarrito = carritoDao.ObtenerCarritoActivo(Sesion.IdUsuario);

            if (Sesion.IdCarrito == 0)
                Sesion.IdCarrito = carritoDao.CrearCarrito(Sesion.IdUsuario);

            var dt = itemDao.ObtenerItems(Sesion.IdCarrito);

            foreach (System.Data.DataRow row in dt.Rows)
            {
                CardCarrito card = new CardCarrito
                {
                    IdItem = Convert.ToInt32(row["Id"]),
                    IdMenu = Convert.ToInt32(row["IdMenu"])
                };

                card.lblNombrePlato.Text = row["Nombre"].ToString();
                card.lblPrecio.Text = $"${Convert.ToDecimal(row["PrecioUnitario"]):0.00}";
                card.SetCantidad(Convert.ToInt32(row["Cantidad"]));

                string img = row["Imagen"]?.ToString();
                if (!string.IsNullOrEmpty(img))
                {
                    string ruta = System.IO.Path.Combine(Application.StartupPath,
                                    "imagenes", "menus", img);
                    try
                    {
                        card.picPlato.Image = new System.Drawing.Bitmap(ruta);
                        card.picPlato.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch { }
                }

                card.CantidadCambiada += (s, ev) =>
                {
                    itemDao.ActualizarCantidad(card.IdItem, card.ObtenerCantidad());
                    ActualizarTotal();
                };

                card.Eliminado += (s, ev) =>
                {
                    itemDao.EliminarItem(card.IdItem);
                    flowCarrito.Controls.Remove(card);
                    ActualizarTotal();
                };

                flowCarrito.Controls.Add(card);
            }

            ActualizarTotal();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (flowCarrito.Controls.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            decimal total = 0;
            foreach (CardCarrito item in flowCarrito.Controls)
            {
                decimal precio = decimal.Parse(item.lblPrecio.Text.Replace("$", ""));
                total += precio * item.ObtenerCantidad();
            }

            int idCarrito = Sesion.IdCarrito;
            var pDao = new PedidoDAO();
            var dDao = new PedidoDetalleDAO();
            var itemDao = new CarritoItemDAO();
            var carritoDao = new CarritoDAO();

            int idPedido = pDao.CrearPedido(Sesion.IdUsuario, total);

            foreach (CardCarrito item in flowCarrito.Controls)
            {
                dDao.AgregarDetalle(
                    idPedido,
                    item.IdMenu,
                    item.ObtenerCantidad(),
                    decimal.Parse(item.lblPrecio.Text.Replace("$", ""))
                );
            }

            itemDao.EliminarItemsDeCarrito(idCarrito);
            carritoDao.CerrarCarrito(idCarrito);

            Sesion.IdCarrito = carritoDao.CrearCarrito(Sesion.IdUsuario); // 🚀 Nuevo carrito

            flowCarrito.Controls.Clear();
            lblTotal.Text = "Total: $0.00";

            MessageBox.Show($"Gracias por tu compra.\nTotal: ${total:0.00}",
                "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ActualizarTotal()
        {
            decimal total = 0;
            foreach (CardCarrito item in flowCarrito.Controls)
            {
                decimal precio = decimal.Parse(item.lblPrecio.Text.Replace("$", "").Trim());
                total += precio * item.ObtenerCantidad();
            }
            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }
    }
}