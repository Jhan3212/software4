namespace GoEats
{
    partial class DashboardAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblRestaurantes = new System.Windows.Forms.Label();
            this.lblNumRest = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblNumUsers = new System.Windows.Forms.Label();
            this.btnGestionRest = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(640, 70);
            this.pnlTop.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(640, 70);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Panel de Administración";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStats.Controls.Add(this.lblRestaurantes);
            this.pnlStats.Controls.Add(this.lblNumRest);
            this.pnlStats.Location = new System.Drawing.Point(30, 100);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(250, 120);
            this.pnlStats.TabIndex = 5;
            // 
            // lblRestaurantes
            // 
            this.lblRestaurantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRestaurantes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRestaurantes.Location = new System.Drawing.Point(0, 0);
            this.lblRestaurantes.Name = "lblRestaurantes";
            this.lblRestaurantes.Size = new System.Drawing.Size(248, 32);
            this.lblRestaurantes.TabIndex = 0;
            this.lblRestaurantes.Text = "Restaurantes";
            this.lblRestaurantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumRest
            // 
            this.lblNumRest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumRest.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblNumRest.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNumRest.Location = new System.Drawing.Point(0, 0);
            this.lblNumRest.Name = "lblNumRest";
            this.lblNumRest.Size = new System.Drawing.Size(248, 118);
            this.lblNumRest.TabIndex = 1;
            this.lblNumRest.Text = "0";
            this.lblNumRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsers.Controls.Add(this.lblUsuarios);
            this.pnlUsers.Controls.Add(this.lblNumUsers);
            this.pnlUsers.Location = new System.Drawing.Point(340, 100);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(250, 120);
            this.pnlUsers.TabIndex = 4;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuarios.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(248, 32);
            this.lblUsuarios.TabIndex = 0;
            this.lblUsuarios.Text = "Usuarios";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumUsers
            // 
            this.lblNumUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumUsers.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblNumUsers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNumUsers.Location = new System.Drawing.Point(0, 0);
            this.lblNumUsers.Name = "lblNumUsers";
            this.lblNumUsers.Size = new System.Drawing.Size(248, 118);
            this.lblNumUsers.TabIndex = 1;
            this.lblNumUsers.Text = "0";
            this.lblNumUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGestionRest
            // 
            this.btnGestionRest.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGestionRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionRest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGestionRest.ForeColor = System.Drawing.Color.White;
            this.btnGestionRest.Location = new System.Drawing.Point(30, 250);
            this.btnGestionRest.Name = "btnGestionRest";
            this.btnGestionRest.Size = new System.Drawing.Size(261, 50);
            this.btnGestionRest.TabIndex = 3;
            this.btnGestionRest.Text = "Gestión de Restaurantes";
            this.btnGestionRest.UseVisualStyleBackColor = false;
            this.btnGestionRest.Click += new System.EventHandler(this.btnGestionRest_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(340, 250);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(250, 50);
            this.btnGestionUsuarios.TabIndex = 2;
            this.btnGestionUsuarios.Text = "Gestión de Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.BackColor = System.Drawing.Color.Goldenrod;
            this.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPedidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerPedidos.ForeColor = System.Drawing.Color.White;
            this.btnVerPedidos.Location = new System.Drawing.Point(185, 320);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(250, 50);
            this.btnVerPedidos.TabIndex = 1;
            this.btnVerPedidos.Text = "Pedidos Recientes";
            this.btnVerPedidos.UseVisualStyleBackColor = false;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(435, 406);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(155, 40);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // DashboardAdmin
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnVerPedidos);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Controls.Add(this.btnGestionRest);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DashboardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Admin";
            this.pnlTop.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblRestaurantes;
        private System.Windows.Forms.Label lblNumRest;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblNumUsers;
        private System.Windows.Forms.Button btnGestionRest;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
