namespace VocesDePapelV1._1.Views
{
    partial class GerenteView
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
            usuarioItemMenu = new ToolStripMenuItem();
            backupItemMenu = new ToolStripMenuItem();
            reporteVentaGerenteItemMenu = new ToolStripMenuItem();
            reporteLGerenteItemMenu = new ToolStripMenuItem();
            reporteLSGerenteItemMenu = new ToolStripMenuItem();
            reporteLMVGerenteItemMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.FromArgb(255, 192, 128);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { usuarioItemMenu, backupItemMenu, reporteVentaGerenteItemMenu, reporteLGerenteItemMenu, toolStripMenuItem1 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1382, 90);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // usuarioItemMenu
            // 
            usuarioItemMenu.AutoSize = false;
            usuarioItemMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuarioItemMenu.Image = Properties.Resources.usuario;
            usuarioItemMenu.ImageAlign = ContentAlignment.BottomCenter;
            usuarioItemMenu.ImageScaling = ToolStripItemImageScaling.None;
            usuarioItemMenu.Name = "usuarioItemMenu";
            usuarioItemMenu.Size = new Size(130, 110);
            usuarioItemMenu.Text = "Usuario";
            usuarioItemMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // backupItemMenu
            // 
            backupItemMenu.AutoSize = false;
            backupItemMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backupItemMenu.Image = Properties.Resources.respaldo;
            backupItemMenu.ImageAlign = ContentAlignment.BottomCenter;
            backupItemMenu.ImageScaling = ToolStripItemImageScaling.None;
            backupItemMenu.Name = "backupItemMenu";
            backupItemMenu.Size = new Size(130, 110);
            backupItemMenu.Text = "Backup";
            backupItemMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporteVentaGerenteItemMenu
            // 
            reporteVentaGerenteItemMenu.AutoSize = false;
            reporteVentaGerenteItemMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reporteVentaGerenteItemMenu.Image = Properties.Resources.aumentar;
            reporteVentaGerenteItemMenu.ImageAlign = ContentAlignment.BottomCenter;
            reporteVentaGerenteItemMenu.ImageScaling = ToolStripItemImageScaling.None;
            reporteVentaGerenteItemMenu.Name = "reporteVentaGerenteItemMenu";
            reporteVentaGerenteItemMenu.Size = new Size(150, 110);
            reporteVentaGerenteItemMenu.Text = "Reporte Venta";
            reporteVentaGerenteItemMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporteLGerenteItemMenu
            // 
            reporteLGerenteItemMenu.AutoSize = false;
            reporteLGerenteItemMenu.DropDownItems.AddRange(new ToolStripItem[] { reporteLSGerenteItemMenu, reporteLMVGerenteItemMenu });
            reporteLGerenteItemMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reporteLGerenteItemMenu.Image = Properties.Resources.aumentar;
            reporteLGerenteItemMenu.ImageAlign = ContentAlignment.BottomCenter;
            reporteLGerenteItemMenu.ImageScaling = ToolStripItemImageScaling.None;
            reporteLGerenteItemMenu.Name = "reporteLGerenteItemMenu";
            reporteLGerenteItemMenu.Size = new Size(150, 110);
            reporteLGerenteItemMenu.Text = "Reporte Libro";
            reporteLGerenteItemMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporteLSGerenteItemMenu
            // 
            reporteLSGerenteItemMenu.Name = "reporteLSGerenteItemMenu";
            reporteLSGerenteItemMenu.Size = new Size(244, 36);
            reporteLSGerenteItemMenu.Text = "Stock";
            // 
            // reporteLMVGerenteItemMenu
            // 
            reporteLMVGerenteItemMenu.Name = "reporteLMVGerenteItemMenu";
            reporteLMVGerenteItemMenu.Size = new Size(244, 36);
            reporteLMVGerenteItemMenu.Text = "Más vendidos";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem1.Image = Properties.Resources.salida;
            toolStripMenuItem1.ImageAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.RightToLeft = RightToLeft.No;
            toolStripMenuItem1.Size = new Size(152, 110);
            toolStripMenuItem1.Text = "Cerrar Sesión";
            toolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // GerenteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 875);
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Name = "GerenteView";
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem usuarioItemMenu;
        private ToolStripMenuItem backupItemMenu;
        private ToolStripMenuItem reporteVentaGerenteItemMenu;
        private ToolStripMenuItem reporteLGerenteItemMenu;
        private ToolStripMenuItem reporteLSGerenteItemMenu;
        private ToolStripMenuItem reporteLMVGerenteItemMenu;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}