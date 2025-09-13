namespace VocesDePapelV1._1.Views
{
    partial class VendedorView
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
            menuVendedor = new MenuStrip();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            menuVendedor.SuspendLayout();
            SuspendLayout();
            // 
            // menuVendedor
            // 
            menuVendedor.AutoSize = false;
            menuVendedor.BackColor = Color.FromArgb(255, 192, 128);
            menuVendedor.ImageScalingSize = new Size(20, 20);
            menuVendedor.Items.AddRange(new ToolStripItem[] { ventaToolStripMenuItem, librosToolStripMenuItem, usuariosToolStripMenuItem, reportesToolStripMenuItem });
            menuVendedor.Location = new Point(0, 0);
            menuVendedor.Name = "menuVendedor";
            menuVendedor.Size = new Size(800, 90);
            menuVendedor.TabIndex = 1;
            menuVendedor.Text = "menuVendedorView";
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ventaToolStripMenuItem.Image = Properties.Resources.verificar;
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(86, 86);
            ventaToolStripMenuItem.Text = "Venta";
            ventaToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            librosToolStripMenuItem.Image = Properties.Resources.libro;
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(90, 86);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuariosToolStripMenuItem.Image = Properties.Resources.usuario;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(116, 86);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportesToolStripMenuItem.Image = Properties.Resources.respaldo;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(113, 86);
            reportesToolStripMenuItem.Text = "reportes";
            reportesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // VendedorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuVendedor);
            MainMenuStrip = menuVendedor;
            Name = "VendedorView";
            Text = "VendedorView";
            menuVendedor.ResumeLayout(false);
            menuVendedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuVendedor;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}