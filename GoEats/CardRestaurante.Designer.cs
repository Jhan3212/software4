using System.Windows.Forms;

namespace GoEats
{
    partial class CardRestaurante
    {
        public PictureBox picImagen;
        public Label lblNombre;
        public Label lblCategoria;
        public Button btnVer;

        private void InitializeComponent()
        {
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();

            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(10, 10);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(180, 120);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(10, 140);
            this.lblNombre.Size = new System.Drawing.Size(180, 25);
            this.lblNombre.Text = "Nombre";

            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategoria.Location = new System.Drawing.Point(10, 170);
            this.lblCategoria.Size = new System.Drawing.Size(180, 20);
            this.lblCategoria.Text = "Categoría";

            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(10, 200);
            this.btnVer.Size = new System.Drawing.Size(180, 30);
            this.btnVer.Text = "Ver";

            // 
            // CardRestaurante
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnVer);
            this.Name = "CardRestaurante";
            this.Size = new System.Drawing.Size(200, 250);

            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
