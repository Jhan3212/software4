using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoEats
{
    public partial class CardCarrito : UserControl
    {
        public event EventHandler CantidadCambiada;
        public event EventHandler Eliminado;

        public CardCarrito()
        {
            InitializeComponent();

            btnMas.Click += (s, e) => CambiarCantidad(1);
            btnMenos.Click += (s, e) => CambiarCantidad(-1);
            btnEliminar.Click += (s, e) => this.OnEliminar();
        }

        private void CambiarCantidad(int valor)
        {
            int cantidad;
            if (!int.TryParse(lblCantidad.Text, out cantidad))
            {
                cantidad = 1;
            }
            cantidad += valor;

            if (cantidad < 1)
                cantidad = 1;

            lblCantidad.Text = cantidad.ToString();

            CantidadCambiada?.Invoke(this, EventArgs.Empty);
        }

        private void OnEliminar()
        {
            Eliminado?.Invoke(this, EventArgs.Empty);
        }
    }
}