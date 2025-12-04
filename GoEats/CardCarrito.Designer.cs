using System.Windows.Forms;

namespace GoEats
{
    partial class CardCarrito
    {
        private System.ComponentModel.IContainer components = null;

        public PictureBox picPlato;
        public Label lblNombrePlato;
        public Label lblPrecio;
        public Label lblCantidad;
        public Button btnEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picPlato = new System.Windows.Forms.PictureBox();
            this.lblNombrePlato = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).BeginInit();
            this.SuspendLayout();

            // 
            // CardCarrito
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(500, 120);
            this.Margin = new Padding(10);
            this.BorderStyle = BorderStyle.FixedSingle;

            // 
            // picPlato
            // 
            this.picPlato.Location = new System.Drawing.Point(10, 10);
            this.picPlato.Size = new System.Drawing.Size(100, 100);
            this.picPlato.SizeMode = PictureBoxSizeMode.Zoom;
            this.picPlato.BorderStyle = BorderStyle.FixedSingle;

            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombrePlato.Location = new System.Drawing.Point(120, 10);
            this.lblNombrePlato.Size = new System.Drawing.Size(350, 30);
            this.lblNombrePlato.Text = "Nombre del plato";

            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblPrecio.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPrecio.Location = new System.Drawing.Point(120, 45);
            this.lblPrecio.Size = new System.Drawing.Size(200, 25);
            this.lblPrecio.Text = "$0.00";

            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.lblCantidad.Location = new System.Drawing.Point(120, 75);
            this.lblCantidad.Size = new System.Drawing.Size(150, 25);
            this.lblCantidad.Text = "Cantidad: 1";

            // 
            // btnEliminar
            // 
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(350, 70);
            this.btnEliminar.Size = new System.Drawing.Size(120, 35);

            // 
            // Add controls
            // 
            this.Controls.Add(this.picPlato);
            this.Controls.Add(this.lblNombrePlato);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnEliminar);

            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
