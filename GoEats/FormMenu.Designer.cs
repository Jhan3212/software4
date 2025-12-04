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
            this.picRestaurante = new System.Windows.Forms.PictureBox();
            this.lblNombreRestaurante = new System.Windows.Forms.Label();
            this.lblCategoriaRestaurante = new System.Windows.Forms.Label();
            this.lblMenuTitulo = new System.Windows.Forms.Label();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gold;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.btnAtras);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(593, 55);
            this.panelTop.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Gold;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAtras.Location = new System.Drawing.Point(5, 8);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(45, 38);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "◄";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // picRestaurante
            // 
            this.picRestaurante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRestaurante.Location = new System.Drawing.Point(20, 70);
            this.picRestaurante.Name = "picRestaurante";
            this.picRestaurante.Size = new System.Drawing.Size(550, 220);
            this.picRestaurante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRestaurante.TabIndex = 1;
            this.picRestaurante.TabStop = false;
            // 
            // lblNombreRestaurante
            // 
            this.lblNombreRestaurante.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNombreRestaurante.Location = new System.Drawing.Point(20, 300);
            this.lblNombreRestaurante.Name = "lblNombreRestaurante";
            this.lblNombreRestaurante.Size = new System.Drawing.Size(550, 45);
            this.lblNombreRestaurante.TabIndex = 2;
            this.lblNombreRestaurante.Text = "Nombre del Restaurante";
            // 
            // lblCategoriaRestaurante
            // 
            this.lblCategoriaRestaurante.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCategoriaRestaurante.ForeColor = System.Drawing.Color.Gray;
            this.lblCategoriaRestaurante.Location = new System.Drawing.Point(22, 345);
            this.lblCategoriaRestaurante.Name = "lblCategoriaRestaurante";
            this.lblCategoriaRestaurante.Size = new System.Drawing.Size(500, 25);
            this.lblCategoriaRestaurante.TabIndex = 3;
            this.lblCategoriaRestaurante.Text = "Categoría";
            // 
            // lblMenuTitulo
            // 
            this.lblMenuTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitulo.Location = new System.Drawing.Point(20, 380);
            this.lblMenuTitulo.Name = "lblMenuTitulo";
            this.lblMenuTitulo.Size = new System.Drawing.Size(200, 40);
            this.lblMenuTitulo.TabIndex = 4;
            this.lblMenuTitulo.Text = "Menú";
            // 
            // flowMenu
            // 
            this.flowMenu.AutoScroll = true;
            this.flowMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowMenu.Location = new System.Drawing.Point(20, 430);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Size = new System.Drawing.Size(550, 315);
            this.flowMenu.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(531, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMenu
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 765);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.picRestaurante);
            this.Controls.Add(this.lblNombreRestaurante);
            this.Controls.Add(this.lblCategoriaRestaurante);
            this.Controls.Add(this.lblMenuTitulo);
            this.Controls.Add(this.flowMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
