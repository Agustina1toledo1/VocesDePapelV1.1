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
            BBackup = new Button();
            backup_descripcion = new Label();
            sFD_backup = new SaveFileDialog();
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
            // BBackup
            // 
            BBackup.BackColor = SystemColors.GradientActiveCaption;
            BBackup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BBackup.Location = new Point(295, 225);
            BBackup.Name = "BBackup";
            BBackup.Size = new Size(162, 66);
            BBackup.TabIndex = 7;
            BBackup.Text = "Back Up";
            BBackup.UseVisualStyleBackColor = false;
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
            // GerenteBackupView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backup_descripcion);
            Controls.Add(BBackup);
            Controls.Add(LBackup);
            Name = "GerenteBackupView";
            Text = "Back Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBackup;
        private Button BBackup;
        private Label backup_descripcion;
        private SaveFileDialog sFD_backup;
    }
}