namespace VocesDePapelV1._1.Views
{
    partial class AdministradorView
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
            menu = new MenuStrip();
            producto_item_menu_admin = new ToolStripMenuItem();
            reporte_venta_item_menu_admin = new ToolStripMenuItem();
            reporte_libro_item_menu_admin = new ToolStripMenuItem();
            reporteLibroSAdminItemMenu = new ToolStripMenuItem();
            másVendidosToolStripMenuItem = new ToolStripMenuItem();
            autor_item_menu_admin = new ToolStripMenuItem();
            categorias_menu_item_admin = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.FromArgb(255, 192, 128);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { producto_item_menu_admin, reporte_venta_item_menu_admin, reporte_libro_item_menu_admin, autor_item_menu_admin, categorias_menu_item_admin, toolStripMenuItem1 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1382, 90);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // producto_item_menu_admin
            // 
            producto_item_menu_admin.AutoSize = false;
            producto_item_menu_admin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            producto_item_menu_admin.Image = Properties.Resources.libro;
            producto_item_menu_admin.ImageAlign = ContentAlignment.BottomCenter;
            producto_item_menu_admin.ImageScaling = ToolStripItemImageScaling.None;
            producto_item_menu_admin.Name = "producto_item_menu_admin";
            producto_item_menu_admin.Size = new Size(130, 110);
            producto_item_menu_admin.Text = "Productos";
            producto_item_menu_admin.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporte_venta_item_menu_admin
            // 
            reporte_venta_item_menu_admin.AutoSize = false;
            reporte_venta_item_menu_admin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reporte_venta_item_menu_admin.Image = Properties.Resources.aumentar;
            reporte_venta_item_menu_admin.ImageAlign = ContentAlignment.BottomCenter;
            reporte_venta_item_menu_admin.ImageScaling = ToolStripItemImageScaling.None;
            reporte_venta_item_menu_admin.Name = "reporte_venta_item_menu_admin";
            reporte_venta_item_menu_admin.Size = new Size(150, 110);
            reporte_venta_item_menu_admin.Text = "Reporte Venta";
            reporte_venta_item_menu_admin.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporte_libro_item_menu_admin
            // 
            reporte_libro_item_menu_admin.AutoSize = false;
            reporte_libro_item_menu_admin.DropDownItems.AddRange(new ToolStripItem[] { reporteLibroSAdminItemMenu, másVendidosToolStripMenuItem });
            reporte_libro_item_menu_admin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reporte_libro_item_menu_admin.Image = Properties.Resources.aumentar;
            reporte_libro_item_menu_admin.ImageAlign = ContentAlignment.BottomCenter;
            reporte_libro_item_menu_admin.ImageScaling = ToolStripItemImageScaling.None;
            reporte_libro_item_menu_admin.Name = "reporte_libro_item_menu_admin";
            reporte_libro_item_menu_admin.Size = new Size(152, 110);
            reporte_libro_item_menu_admin.Text = "Reporte Libro";
            reporte_libro_item_menu_admin.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporteLibroSAdminItemMenu
            // 
            reporteLibroSAdminItemMenu.Name = "reporteLibroSAdminItemMenu";
            reporteLibroSAdminItemMenu.Size = new Size(244, 36);
            reporteLibroSAdminItemMenu.Text = "Stock";
            // 
            // másVendidosToolStripMenuItem
            // 
            másVendidosToolStripMenuItem.Name = "másVendidosToolStripMenuItem";
            másVendidosToolStripMenuItem.Size = new Size(244, 36);
            másVendidosToolStripMenuItem.Text = "Más vendidos";
            // 
            // autor_item_menu_admin
            // 
            autor_item_menu_admin.AutoSize = false;
            autor_item_menu_admin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autor_item_menu_admin.Image = Properties.Resources.usuario;
            autor_item_menu_admin.ImageAlign = ContentAlignment.BottomCenter;
            autor_item_menu_admin.ImageScaling = ToolStripItemImageScaling.None;
            autor_item_menu_admin.Name = "autor_item_menu_admin";
            autor_item_menu_admin.Size = new Size(130, 110);
            autor_item_menu_admin.Text = "Autores";
            autor_item_menu_admin.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // categorias_menu_item_admin
            // 
            categorias_menu_item_admin.AutoSize = false;
            categorias_menu_item_admin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categorias_menu_item_admin.Image = Properties.Resources.categoria;
            categorias_menu_item_admin.ImageAlign = ContentAlignment.BottomCenter;
            categorias_menu_item_admin.ImageScaling = ToolStripItemImageScaling.None;
            categorias_menu_item_admin.Name = "categorias_menu_item_admin";
            categorias_menu_item_admin.Size = new Size(130, 110);
            categorias_menu_item_admin.Text = "Categorias";
            categorias_menu_item_admin.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem1.Image = Properties.Resources.salida;
            toolStripMenuItem1.ImageAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(150, 110);
            toolStripMenuItem1.Text = "Cerrar Sesión";
            toolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // AdministradorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 875);
            Controls.Add(menu);
            IsMdiContainer = true;
            Name = "AdministradorView";
            Text = "AdministradorView";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem producto_item_menu_admin;
        private ToolStripMenuItem reporte_venta_item_menu_admin;
        private ToolStripMenuItem reporte_libro_item_menu_admin;
        private ToolStripMenuItem autor_item_menu_admin;
        private ToolStripMenuItem categorias_menu_item_admin;
        private ToolStripMenuItem reporteLibroSAdminItemMenu;
        private ToolStripMenuItem másVendidosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}