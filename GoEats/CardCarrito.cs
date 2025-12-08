using System;
using System.Windows.Forms;

namespace GoEats
{
    public partial class CardCarrito : UserControl
    {
        public event EventHandler CantidadCambiada;
        public event EventHandler Eliminado;

        public int IdItem { get; set; }
        public int IdMenu { get; set; }

        public CardCarrito()
        {
            InitializeComponent();

            btnMas.Click += (s, e) => CambiarCantidad(1);
            btnMenos.Click += (s, e) => CambiarCantidad(-1);
            btnEliminar.Click += (s, e) => OnEliminar();
        }

        private void CambiarCantidad(int valor)
        {
            int cantidad = ObtenerCantidad();
            cantidad += valor;

            if (cantidad < 1)
                cantidad = 1;

            lblCantidad.Text = cantidad.ToString();

            CantidadCambiada?.Invoke(this, EventArgs.Empty);
        }

        public void SetCantidad(int cantidad)
        {
            if (cantidad < 1)
                cantidad = 1;

            lblCantidad.Text = cantidad.ToString();
        }

        public int ObtenerCantidad()
        {
            int cantidad;
            if (!int.TryParse(lblCantidad.Text.Trim(), out cantidad))
                cantidad = 1;

            return cantidad;
        }

        private void OnEliminar()
        {
            Eliminado?.Invoke(this, EventArgs.Empty);
        }
    }
}