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
            Btn_Backup = new Button();
            backup_descripcion = new Label();
            sFD_backup = new SaveFileDialog();
            label1 = new Label();
            SuspendLayout();
            // 
            // LBackup
            // 
            LBackup.AutoSize = true;
            LBackup.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            LBackup.Location = new Point(319, 105);
            LBackup.Name = "LBackup";
            LBackup.Size = new Size(111, 35);
            LBackup.TabIndex = 0;
            LBackup.Text = "Back Up";
            // 
            // Btn_Backup
            // 
            Btn_Backup.BackColor = SystemColors.GradientActiveCaption;
            Btn_Backup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn_Backup.Location = new Point(295, 225);
            Btn_Backup.Name = "Btn_Backup";
            Btn_Backup.Size = new Size(162, 66);
            Btn_Backup.TabIndex = 7;
            Btn_Backup.Text = "Back Up";
            Btn_Backup.UseVisualStyleBackColor = false;
            // 
            // backup_descripcion
            // 
            backup_descripcion.AutoSize = true;
            backup_descripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backup_descripcion.Location = new Point(229, 150);
            backup_descripcion.Name = "backup_descripcion";
            backup_descripcion.Size = new Size(292, 28);
            backup_descripcion.TabIndex = 8;
            backup_descripcion.Text = "Realiza una copia de seguridad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(81, 342);
            label1.Name = "label1";
            label1.Size = new Size(641, 28);
            label1.TabIndex = 9;
            label1.Text = "Usá una carpeta como C:\\BackupSQL para evitar errores de permisos.";
            // 
            // GerenteBackupView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(backup_descripcion);
            Controls.Add(Btn_Backup);
            Controls.Add(LBackup);
            Name = "GerenteBackupView";
            Text = "Back Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBackup;
        private Button Btn_Backup;
        private Label backup_descripcion;
        private SaveFileDialog sFD_backup;
        private Label label1;
    }
}