namespace VocesDePapelV1._1.Views
{
    partial class GerenteBackupView
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
            LBackup = new Label();
            LBaseDatos = new Label();
            LRutaGuardar = new Label();
            TBBaseDatos = new TextBox();
            TBRutaGuardar = new TextBox();
            BConectar = new Button();
            BRuta = new Button();
            BBackup = new Button();
            SuspendLayout();
            // 
            // LBackup
            // 
            LBackup.AutoSize = true;
            LBackup.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            LBackup.Location = new Point(319, 63);
            LBackup.Name = "LBackup";
            LBackup.Size = new Size(111, 35);
            LBackup.TabIndex = 0;
            LBackup.Text = "Back Up";
            // 
            // LBaseDatos
            // 
            LBaseDatos.AutoSize = true;
            LBaseDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LBaseDatos.Location = new Point(135, 143);
            LBaseDatos.Name = "LBaseDatos";
            LBaseDatos.Size = new Size(148, 28);
            LBaseDatos.TabIndex = 1;
            LBaseDatos.Text = "Base de datos:";
            // 
            // LRutaGuardar
            // 
            LRutaGuardar.AutoSize = true;
            LRutaGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LRutaGuardar.Location = new Point(135, 214);
            LRutaGuardar.Name = "LRutaGuardar";
            LRutaGuardar.Size = new Size(144, 28);
            LRutaGuardar.TabIndex = 2;
            LRutaGuardar.Text = "Ruta Guardar:";
            // 
            // TBBaseDatos
            // 
            TBBaseDatos.Location = new Point(298, 139);
            TBBaseDatos.Name = "TBBaseDatos";
            TBBaseDatos.Size = new Size(246, 27);
            TBBaseDatos.TabIndex = 3;
            // 
            // TBRutaGuardar
            // 
            TBRutaGuardar.Location = new Point(294, 209);
            TBRutaGuardar.Name = "TBRutaGuardar";
            TBRutaGuardar.Size = new Size(250, 27);
            TBRutaGuardar.TabIndex = 4;
            // 
            // BConectar
            // 
            BConectar.BackColor = SystemColors.GradientActiveCaption;
            BConectar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BConectar.Location = new Point(597, 127);
            BConectar.Name = "BConectar";
            BConectar.Size = new Size(114, 39);
            BConectar.TabIndex = 5;
            BConectar.Text = "Conectar";
            BConectar.UseVisualStyleBackColor = false;
            // 
            // BRuta
            // 
            BRuta.BackColor = SystemColors.GradientActiveCaption;
            BRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BRuta.Location = new Point(597, 205);
            BRuta.Name = "BRuta";
            BRuta.Size = new Size(118, 36);
            BRuta.TabIndex = 6;
            BRuta.Text = "Ruta";
            BRuta.UseVisualStyleBackColor = false;
            // 
            // BBackup
            // 
            BBackup.BackColor = SystemColors.GradientActiveCaption;
            BBackup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BBackup.Location = new Point(370, 294);
            BBackup.Name = "BBackup";
            BBackup.Size = new Size(162, 66);
            BBackup.TabIndex = 7;
            BBackup.Text = "Back Up";
            BBackup.UseVisualStyleBackColor = false;
            // 
            // GerenteBackupView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BBackup);
            Controls.Add(BRuta);
            Controls.Add(BConectar);
            Controls.Add(TBRutaGuardar);
            Controls.Add(TBBaseDatos);
            Controls.Add(LRutaGuardar);
            Controls.Add(LBaseDatos);
            Controls.Add(LBackup);
            Name = "GerenteBackupView";
            Text = "Back Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBackup;
        private Label LBaseDatos;
        private Label LRutaGuardar;
        private TextBox TBBaseDatos;
        private TextBox TBRutaGuardar;
        private Button BConectar;
        private Button BRuta;
        private Button BBackup;
    }
}