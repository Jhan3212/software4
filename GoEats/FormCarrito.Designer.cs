using System.Windows.Forms;

namespace GoEats
{
    partial class FormCarrito
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.FlowLayoutPanel flowCarrito;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panelInferior;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowCarrito = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowCarrito
            // 
            this.flowCarrito.AutoScroll = true;
            this.flowCarrito.BackColor = System.Drawing.Color.White;
            this.flowCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowCarrito.Location = new System.Drawing.Point(20, 80);
            this.flowCarrito.Name = "flowCarrito";
            this.flowCarrito.Padding = new System.Windows.Forms.Padding(10);
            this.flowCarrito.Size = new System.Drawing.Size(600, 480);
            this.flowCarrito.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carrito de Compras";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTotal.Location = new System.Drawing.Point(10, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(250, 40);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(380, 15);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(200, 50);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Realizar Pago";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.LightGray;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAtras.Location = new System.Drawing.Point(20, 660);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(120, 43);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Volver";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInferior.Controls.Add(this.lblTotal);
            this.panelInferior.Controls.Add(this.btnPagar);
            this.panelInferior.Location = new System.Drawing.Point(20, 570);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(600, 80);
            this.panelInferior.TabIndex = 5;
            // 
            // FormCarrito
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(640, 720);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.flowCarrito);
            this.Controls.Add(this.btnAtras);
            this.Name = "FormCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
