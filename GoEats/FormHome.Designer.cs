namespace GoEats
{
    partial class FormHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pictureLogoMini = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblRestaurantes = new System.Windows.Forms.Label();
            this.flowRestaurantes = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gold;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.lblAppName);
            this.panelTop.Controls.Add(this.pictureLogoMini);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(593, 70);
            this.panelTop.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(540, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppName.Location = new System.Drawing.Point(80, 12);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(129, 46);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "GoEats";
            // 
            // pictureLogoMini
            // 
            this.pictureLogoMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogoMini.Location = new System.Drawing.Point(10, 5);
            this.pictureLogoMini.Name = "pictureLogoMini";
            this.pictureLogoMini.Size = new System.Drawing.Size(60, 60);
            this.pictureLogoMini.TabIndex = 0;
            this.pictureLogoMini.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline);
            this.lblBuscar.Location = new System.Drawing.Point(25, 90);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(88, 32);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtBuscar.Location = new System.Drawing.Point(25, 125);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(540, 43);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblRestaurantes
            // 
            this.lblRestaurantes.AutoSize = true;
            this.lblRestaurantes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRestaurantes.Location = new System.Drawing.Point(20, 185);
            this.lblRestaurantes.Name = "lblRestaurantes";
            this.lblRestaurantes.Size = new System.Drawing.Size(199, 41);
            this.lblRestaurantes.TabIndex = 3;
            this.lblRestaurantes.Text = "Restaurantes";
            // 
            // flowRestaurantes
            // 
            this.flowRestaurantes.AutoScroll = true;
            this.flowRestaurantes.Location = new System.Drawing.Point(25, 240);
            this.flowRestaurantes.Name = "flowRestaurantes";
            this.flowRestaurantes.Size = new System.Drawing.Size(540, 510);
            this.flowRestaurantes.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(484, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 765);
            this.Controls.Add(this.flowRestaurantes);
            this.Controls.Add(this.lblRestaurantes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureLogoMini;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblRestaurantes;
        private System.Windows.Forms.FlowLayoutPanel flowRestaurantes;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
