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
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.lblCant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlato
            // 
            this.picPlato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlato.Location = new System.Drawing.Point(10, 10);
            this.picPlato.Name = "picPlato";
            this.picPlato.Size = new System.Drawing.Size(100, 100);
            this.picPlato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlato.TabIndex = 0;
            this.picPlato.TabStop = false;
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombrePlato.Location = new System.Drawing.Point(120, 10);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(350, 30);
            this.lblNombrePlato.TabIndex = 1;
            this.lblNombrePlato.Text = "Nombre del plato";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPrecio.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPrecio.Location = new System.Drawing.Point(120, 45);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(200, 25);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "$0.00";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.lblCantidad.Location = new System.Drawing.Point(218, 75);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(38, 25);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "1";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(364, 74);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 35);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMas.Location = new System.Drawing.Point(323, 75);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(35, 35);
            this.btnMas.TabIndex = 5;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.IndianRed;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenos.Location = new System.Drawing.Point(280, 74);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(37, 36);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            // 
            // lblCant
            // 
            this.lblCant.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCant.ForeColor = System.Drawing.Color.DimGray;
            this.lblCant.Location = new System.Drawing.Point(120, 75);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(92, 25);
            this.lblCant.TabIndex = 7;
            this.lblCant.Text = "Cantidad:";
            // 
            // CardCarrito
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.picPlato);
            this.Controls.Add(this.lblNombrePlato);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnMenos);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "CardCarrito";
            this.Size = new System.Drawing.Size(498, 118);
            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).EndInit();
            this.ResumeLayout(false);

        }
        private Button btnMas;
        private Button btnMenos;
        public Label lblCant;
    }
}
