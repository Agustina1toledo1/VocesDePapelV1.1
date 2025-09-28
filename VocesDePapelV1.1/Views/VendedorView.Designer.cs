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
            ventaVendedorItemMenu = new ToolStripMenuItem();
            clienteVendedorItemMenu = new ToolStripMenuItem();
            reporteVentaVendedorItemMenu = new ToolStripMenuItem();
            cerrarSVendedorItemMenu = new ToolStripMenuItem();
            menuVendedor.SuspendLayout();
            SuspendLayout();
            // 
            // menuVendedor
            // 
            menuVendedor.AutoSize = false;
            menuVendedor.BackColor = Color.FromArgb(255, 192, 128);
            menuVendedor.ImageScalingSize = new Size(20, 20);
            menuVendedor.Items.AddRange(new ToolStripItem[] { ventaToolStripMenuItem, ventaVendedorItemMenu, clienteVendedorItemMenu, reporteVentaVendedorItemMenu, cerrarSVendedorItemMenu });
            menuVendedor.Location = new Point(0, 0);
            menuVendedor.Name = "menuVendedor";
            menuVendedor.Size = new Size(1382, 90);
            menuVendedor.TabIndex = 1;
            menuVendedor.Text = "menuVendedorView";
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(14, 86);
            // 
            // ventaVendedorItemMenu
            // 
            ventaVendedorItemMenu.AutoSize = false;
            ventaVendedorItemMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ventaVendedorItemMenu.Image = Properties.Resources.verificar;
            ventaVendedorItemMenu.ImageAlign = ContentAlignment.BottomCenter;
            ventaVendedorItemMenu.ImageScaling = ToolStripItemImageScaling.None;
            ventaVendedorItemMenu.Name = "ventaVendedorItemMenu";
            ventaVendedorItemMenu.Size = new Size(86, 86);
            ventaVendedorItemMenu.Text = "Venta";
            ventaVendedorItemMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // clienteVendedorItemMenu
            // 
            clienteVendedorItemMenu.AutoSize = false;
            clienteVendedorItemMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clienteVendedorItemMenu.Image = Properties.Resources.usuario;
            clienteVendedorItemMenu.ImageAlign = ContentAlignment.BottomCenter;
            clienteVendedorItemMenu.ImageScaling = ToolStripItemImageScaling.None;
            clienteVendedorItemMenu.Name = "clienteVendedorItemMenu";
            clienteVendedorItemMenu.Size = new Size(109, 86);
            clienteVendedorItemMenu.Text = "Clientes";
            clienteVendedorItemMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporteVentaVendedorItemMenu
            // 
            reporteVentaVendedorItemMenu.AutoSize = false;
            reporteVentaVendedorItemMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reporteVentaVendedorItemMenu.Image = Properties.Resources.aumentar;
            reporteVentaVendedorItemMenu.ImageAlign = ContentAlignment.BottomCenter;
            reporteVentaVendedorItemMenu.ImageScaling = ToolStripItemImageScaling.None;
            reporteVentaVendedorItemMenu.Name = "reporteVentaVendedorItemMenu";
            reporteVentaVendedorItemMenu.Size = new Size(180, 86);
            reporteVentaVendedorItemMenu.Text = "Reporte de Venta";
            reporteVentaVendedorItemMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // cerrarSVendedorItemMenu
            // 
            cerrarSVendedorItemMenu.AutoSize = false;
            cerrarSVendedorItemMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cerrarSVendedorItemMenu.Image = Properties.Resources.salida;
            cerrarSVendedorItemMenu.ImageAlign = ContentAlignment.BottomCenter;
            cerrarSVendedorItemMenu.ImageScaling = ToolStripItemImageScaling.None;
            cerrarSVendedorItemMenu.Name = "cerrarSVendedorItemMenu";
            cerrarSVendedorItemMenu.RightToLeft = RightToLeft.No;
            cerrarSVendedorItemMenu.Size = new Size(152, 110);
            cerrarSVendedorItemMenu.Text = "Cerrar Sesión";
            cerrarSVendedorItemMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // VendedorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 703);
            Controls.Add(menuVendedor);
            IsMdiContainer = true;
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
        private ToolStripMenuItem clienteVendedorItemMenu;
        private ToolStripMenuItem reporteVentaVendedorItemMenu;
        private ToolStripMenuItem ventaVendedorItemMenu;
        private ToolStripMenuItem cerrarSVendedorItemMenu;
    }
}