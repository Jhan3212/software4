using System.Windows.Forms;

namespace GoEats
{
    partial class CardPlato
    {
        private System.ComponentModel.IContainer components = null;

        public PictureBox picPlato;
        public Label lblNombrePlato;
        public Label lblPrecio;
        public Button btnAgregar;

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
            this.btnAgregar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).BeginInit();
            this.SuspendLayout();

            // 
            // CardPlato
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Size = new System.Drawing.Size(560, 150);
            this.Margin = new Padding(10);
            this.BorderStyle = BorderStyle.FixedSingle;

            // 
            // picPlato
            // 
            this.picPlato.Location = new System.Drawing.Point(15, 15);
            this.picPlato.Size = new System.Drawing.Size(120, 120);
            this.picPlato.SizeMode = PictureBoxSizeMode.Zoom;
            this.picPlato.BorderStyle = BorderStyle.FixedSingle;

            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNombrePlato.ForeColor = System.Drawing.Color.Black;
            this.lblNombrePlato.Location = new System.Drawing.Point(150, 15);
            this.lblNombrePlato.Size = new System.Drawing.Size(380, 35);
            this.lblNombrePlato.Text = "Nombre del plato";

            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPrecio.Location = new System.Drawing.Point(150, 55);
            this.lblPrecio.Size = new System.Drawing.Size(200, 30);
            this.lblPrecio.Text = "$0.00";

            // 
            // btnAgregar
            // 
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(150, 95);
            this.btnAgregar.Size = new System.Drawing.Size(130, 40);

            // 
            // Add controls
            // 
            this.Controls.Add(this.picPlato);
            this.Controls.Add(this.lblNombrePlato);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnAgregar);

            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
