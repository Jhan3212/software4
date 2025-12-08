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
            // CardRestaurante
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Margin = new Padding(10);
            this.Name = "CardRestaurante";
            this.Size = new System.Drawing.Size(220, 270);

            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(20, 15);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(180, 120);
            this.picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            this.picImagen.BorderStyle = BorderStyle.FixedSingle;

            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(20, 145);
            this.lblNombre.Size = new System.Drawing.Size(180, 30);
            this.lblNombre.Text = "Nombre";

            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategoria.Location = new System.Drawing.Point(20, 175);
            this.lblCategoria.Size = new System.Drawing.Size(180, 25);
            this.lblCategoria.Text = "CategorÃ­a";

            // 
            // btnVer
            // 
            this.btnVer.Text = "Ver";
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVer.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(20, 210);
            this.btnVer.Size = new System.Drawing.Size(180, 35);

            // 
            // Add controls
            // 
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnVer);

            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
        }
    }
}