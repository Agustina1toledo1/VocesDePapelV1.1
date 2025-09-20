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
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            pocoStockToolStripMenuItem = new ToolStripMenuItem();
            másVendidosToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.FromArgb(255, 192, 128);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { usuarioItemMenu, backupItemMenu, toolStripMenuItem3, toolStripMenuItem4 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1549, 90);
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
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.AutoSize = false;
            toolStripMenuItem3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem3.Image = Properties.Resources.aumentar;
            toolStripMenuItem3.ImageAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(150, 110);
            toolStripMenuItem3.Text = "Reporte Venta";
            toolStripMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.AutoSize = false;
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { pocoStockToolStripMenuItem, másVendidosToolStripMenuItem });
            toolStripMenuItem4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem4.Image = Properties.Resources.aumentar;
            toolStripMenuItem4.ImageAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(150, 110);
            toolStripMenuItem4.Text = "Reporte Libro";
            toolStripMenuItem4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // pocoStockToolStripMenuItem
            // 
            pocoStockToolStripMenuItem.Name = "pocoStockToolStripMenuItem";
            pocoStockToolStripMenuItem.Size = new Size(244, 36);
            pocoStockToolStripMenuItem.Text = "Stock";
            // 
            // másVendidosToolStripMenuItem
            // 
            másVendidosToolStripMenuItem.Name = "másVendidosToolStripMenuItem";
            másVendidosToolStripMenuItem.Size = new Size(244, 36);
            másVendidosToolStripMenuItem.Text = "Más vendidos";
            // 
            // GerenteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 875);
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
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem pocoStockToolStripMenuItem;
        private ToolStripMenuItem másVendidosToolStripMenuItem;
    }
}