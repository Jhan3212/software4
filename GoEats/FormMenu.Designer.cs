namespace GoEats
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;

        public System.Windows.Forms.PictureBox picRestaurante;
        public System.Windows.Forms.Label lblNombreRestaurante;
        public System.Windows.Forms.Label lblCategoriaRestaurante;
        public System.Windows.Forms.FlowLayoutPanel flowMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblMenuTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picRestaurante = new System.Windows.Forms.PictureBox();
            this.lblNombreRestaurante = new System.Windows.Forms.Label();
            this.lblCategoriaRestaurante = new System.Windows.Forms.Label();
            this.lblMenuTitulo = new System.Windows.Forms.Label();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurante)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SeaGreen;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.btnAtras);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(640, 60);
            this.panelTop.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.LightGray;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAtras.Location = new System.Drawing.Point(10, 10);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 40);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "◄";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(580, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picRestaurante
            // 
            this.picRestaurante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRestaurante.Location = new System.Drawing.Point(20, 80);
            this.picRestaurante.Name = "picRestaurante";
            this.picRestaurante.Size = new System.Drawing.Size(600, 220);
            this.picRestaurante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRestaurante.TabIndex = 2;
            this.picRestaurante.TabStop = false;
            // 
            // lblNombreRestaurante
            // 
            this.lblNombreRestaurante.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNombreRestaurante.Location = new System.Drawing.Point(20, 310);
            this.lblNombreRestaurante.Name = "lblNombreRestaurante";
            this.lblNombreRestaurante.Size = new System.Drawing.Size(600, 45);
            this.lblNombreRestaurante.TabIndex = 3;
            this.lblNombreRestaurante.Text = "Nombre del Restaurante";
            this.lblNombreRestaurante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoriaRestaurante
            // 
            this.lblCategoriaRestaurante.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCategoriaRestaurante.ForeColor = System.Drawing.Color.Gray;
            this.lblCategoriaRestaurante.Location = new System.Drawing.Point(22, 355);
            this.lblCategoriaRestaurante.Name = "lblCategoriaRestaurante";
            this.lblCategoriaRestaurante.Size = new System.Drawing.Size(600, 25);
            this.lblCategoriaRestaurante.TabIndex = 4;
            this.lblCategoriaRestaurante.Text = "Categoría";
            // 
            // lblMenuTitulo
            // 
            this.lblMenuTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitulo.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMenuTitulo.Location = new System.Drawing.Point(20, 390);
            this.lblMenuTitulo.Name = "lblMenuTitulo";
            this.lblMenuTitulo.Size = new System.Drawing.Size(200, 40);
            this.lblMenuTitulo.TabIndex = 5;
            this.lblMenuTitulo.Text = "Menú";
            // 
            // flowMenu
            // 
            this.flowMenu.AutoScroll = true;
            this.flowMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowMenu.Location = new System.Drawing.Point(20, 440);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Padding = new System.Windows.Forms.Padding(10);
            this.flowMenu.Size = new System.Drawing.Size(600, 250);
            this.flowMenu.TabIndex = 6;
            // 
            // FormMenu
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(640, 720);
            this.Controls.Add(this.flowMenu);
            this.Controls.Add(this.lblMenuTitulo);
            this.Controls.Add(this.lblCategoriaRestaurante);
            this.Controls.Add(this.lblNombreRestaurante);
            this.Controls.Add(this.picRestaurante);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurante)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
