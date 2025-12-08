namespace GoEats
{
    partial class FormPerfil
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblEmailTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.flowPedidos = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlTop.Controls.Add(this.btnCerrar);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(600, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 60);
            this.lblTitulo.Text = "Mi Perfil";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(550, 10);
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // btnLogout
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(440, 170);
            this.btnLogout.Size = new System.Drawing.Size(125, 34);
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.Controls.Add(this.btnLogout);
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombreTitulo.Location = new System.Drawing.Point(25, 80);
            this.lblNombreTitulo.Text = "Nombre:";
            // 
            // lblEmailTitulo
            // 
            this.lblEmailTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmailTitulo.Location = new System.Drawing.Point(25, 120);
            this.lblEmailTitulo.Text = "Email:";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(110, 80);
            this.lblNombre.AutoSize = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(110, 120);
            this.lblEmail.AutoSize = true;
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNuevaPass.Location = new System.Drawing.Point(25, 170);
            this.txtNuevaPass.Size = new System.Drawing.Size(250, 34);
            this.txtNuevaPass.UseSystemPasswordChar = true;
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCambiarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCambiarPass.ForeColor = System.Drawing.Color.White;
            this.btnCambiarPass.Location = new System.Drawing.Point(290, 170);
            this.btnCambiarPass.Size = new System.Drawing.Size(140, 34);
            this.btnCambiarPass.Text = "Cambiar";
            this.btnCambiarPass.UseVisualStyleBackColor = false;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHistorial.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHistorial.Location = new System.Drawing.Point(25, 230);
            this.lblHistorial.Text = "Historial de Pedidos";
            // 
            // flowPedidos
            // 
            this.flowPedidos.AutoScroll = true;
            this.flowPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPedidos.Location = new System.Drawing.Point(25, 270);
            this.flowPedidos.Size = new System.Drawing.Size(540, 330);
            this.flowPedidos.Padding = new System.Windows.Forms.Padding(5);
            // 
            // FormPerfil
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 620);
            this.Controls.Add(this.flowPedidos);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.btnCambiarPass);
            this.Controls.Add(this.txtNuevaPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEmailTitulo);
            this.Controls.Add(this.lblNombreTitulo);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormPerfil";
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.Label lblEmailTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.FlowLayoutPanel flowPedidos;
    }
}