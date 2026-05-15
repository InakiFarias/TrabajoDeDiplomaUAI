namespace UI
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTituloTopbar = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblSeccionNav = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();

            this.pnlTopbar.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();

            // ──────────────────────────────────────────────────────
            // pnlTopbar
            // ──────────────────────────────────────────────────────
            this.pnlTopbar.Controls.Add(this.lblUsuario);
            this.pnlTopbar.Controls.Add(this.lblTituloTopbar);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(21, 32, 48);
            this.pnlTopbar.Height = 48;
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.TabIndex = 0;

            // ──────────────────────────────────────────────────────
            // lblTituloTopbar
            // ──────────────────────────────────────────────────────
            this.lblTituloTopbar.AutoSize = true;
            this.lblTituloTopbar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblTituloTopbar.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.lblTituloTopbar.Location = new System.Drawing.Point(16, 14);
            this.lblTituloTopbar.Name = "lblTituloTopbar";
            this.lblTituloTopbar.TabIndex = 0;
            this.lblTituloTopbar.Text = "Sistema de Gestión";

            // ──────────────────────────────────────────────────────
            // lblUsuario
            // ──────────────────────────────────────────────────────
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblUsuario.Location = new System.Drawing.Point(840, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "● Admin";

            // ──────────────────────────────────────────────────────
            // pnlSidebar
            // ──────────────────────────────────────────────────────
            this.pnlSidebar.Controls.Add(this.btnCerrarSesion);
            this.pnlSidebar.Controls.Add(this.btnAyuda);
            this.pnlSidebar.Controls.Add(this.btnClientes);
            this.pnlSidebar.Controls.Add(this.btnInventario);
            this.pnlSidebar.Controls.Add(this.btnReportes);
            this.pnlSidebar.Controls.Add(this.btnVentas);
            this.pnlSidebar.Controls.Add(this.btnUsuarios);
            this.pnlSidebar.Controls.Add(this.lblSeccionNav);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(25, 37, 53);
            this.pnlSidebar.Width = 190;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.TabIndex = 1;

            // ──────────────────────────────────────────────────────
            // lblSeccionNav
            // ──────────────────────────────────────────────────────
            this.lblSeccionNav.AutoSize = true;
            this.lblSeccionNav.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccionNav.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSeccionNav.Location = new System.Drawing.Point(12, 8);
            this.lblSeccionNav.Name = "lblSeccionNav";
            this.lblSeccionNav.TabIndex = 0;
            this.lblSeccionNav.Text = "MÓDULOS";

            // ──────────────────────────────────────────────────────
            // btnUsuarios
            // ──────────────────────────────────────────────────────
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 60, 82);
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(25, 37, 53);
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnUsuarios.Location = new System.Drawing.Point(4, 30);
            this.btnUsuarios.Size = new System.Drawing.Size(174, 38);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "👤  Gestión de Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;

            // ──────────────────────────────────────────────────────
            // btnVentas
            // ──────────────────────────────────────────────────────
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 60, 82);
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(25, 37, 53);
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnVentas.Location = new System.Drawing.Point(4, 72);
            this.btnVentas.Size = new System.Drawing.Size(174, 38);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "🛒  Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;

            // ──────────────────────────────────────────────────────
            // btnReportes
            // ──────────────────────────────────────────────────────
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 60, 82);
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(25, 37, 53);
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnReportes.Location = new System.Drawing.Point(4, 114);
            this.btnReportes.Size = new System.Drawing.Size(174, 38);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "📊  Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;

            // ──────────────────────────────────────────────────────
            // btnInventario
            // ──────────────────────────────────────────────────────
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 60, 82);
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(25, 37, 53);
            this.btnInventario.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnInventario.Location = new System.Drawing.Point(4, 156);
            this.btnInventario.Size = new System.Drawing.Size(174, 38);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "📦  Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;

            // ──────────────────────────────────────────────────────
            // btnClientes
            // ──────────────────────────────────────────────────────
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 60, 82);
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(25, 37, 53);
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClientes.Location = new System.Drawing.Point(4, 198);
            this.btnClientes.Size = new System.Drawing.Size(174, 38);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "🙍  Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;

            // ──────────────────────────────────────────────────────
            // btnAyuda
            // ──────────────────────────────────────────────────────
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 60, 82);
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(25, 37, 53);
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnAyuda.Location = new System.Drawing.Point(4, 240);
            this.btnAyuda.Size = new System.Drawing.Size(174, 38);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "❓  Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;

            // ──────────────────────────────────────────────────────
            // btnCerrarSesion
            // ──────────────────────────────────────────────────────
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 60, 82);
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(25, 37, 53);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.Height = 38;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "⇠  Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;

            // ──────────────────────────────────────────────────────
            // pnlContenido
            // ──────────────────────────────────────────────────────
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(30, 42, 58);
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.TabIndex = 2;

            // ──────────────────────────────────────────────────────
            // FrmMenuPrincipal
            // ──────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 42, 58);
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión";

            // Orden de Dock importa: Top primero, Left después, Fill al final
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTopbar);

            this.pnlTopbar.ResumeLayout(false);
            this.pnlTopbar.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Label lblTituloTopbar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSeccionNav;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlContenido;
    }
}