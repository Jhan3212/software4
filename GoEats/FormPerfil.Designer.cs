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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblEmailTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.flowPedidos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.pnlTop.Size = new System.Drawing.Size(640, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(550, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(640, 60);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Mi Perfil";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombreTitulo.Location = new System.Drawing.Point(25, 80);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblNombreTitulo.TabIndex = 8;
            this.lblNombreTitulo.Text = "Nombre:";
            // 
            // lblEmailTitulo
            // 
            this.lblEmailTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmailTitulo.Location = new System.Drawing.Point(25, 120);
            this.lblEmailTitulo.Name = "lblEmailTitulo";
            this.lblEmailTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblEmailTitulo.TabIndex = 7;
            this.lblEmailTitulo.Text = "Email:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(110, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 28);
            this.lblNombre.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(110, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 28);
            this.lblEmail.TabIndex = 5;
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNuevaPass.Location = new System.Drawing.Point(25, 170);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.Size = new System.Drawing.Size(250, 34);
            this.txtNuevaPass.TabIndex = 4;
            this.txtNuevaPass.UseSystemPasswordChar = true;
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCambiarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCambiarPass.ForeColor = System.Drawing.Color.White;
            this.btnCambiarPass.Location = new System.Drawing.Point(304, 170);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(140, 34);
            this.btnCambiarPass.TabIndex = 3;
            this.btnCambiarPass.Text = "Cambiar";
            this.btnCambiarPass.UseVisualStyleBackColor = false;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHistorial.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHistorial.Location = new System.Drawing.Point(25, 230);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(120, 37);
            this.lblHistorial.TabIndex = 2;
            this.lblHistorial.Text = "Historial de Pedidos";
            // 
            // flowPedidos
            // 
            this.flowPedidos.AutoScroll = true;
            this.flowPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPedidos.Location = new System.Drawing.Point(25, 270);
            this.flowPedidos.Name = "flowPedidos";
            this.flowPedidos.Padding = new System.Windows.Forms.Padding(5);
            this.flowPedidos.Size = new System.Drawing.Size(603, 409);
            this.flowPedidos.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(465, 170);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 34);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormPerfil
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(640, 715);
            this.Controls.Add(this.btnLogout);
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
            this.Name = "FormPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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