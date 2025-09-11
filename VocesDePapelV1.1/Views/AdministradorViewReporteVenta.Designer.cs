namespace VocesDePapelV1._1.Views
{
    partial class AdministradorViewReporteVenta
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 175);
            label1.Name = "label1";
            label1.Size = new Size(323, 20);
            label1.TabIndex = 0;
            label1.Text = "Hola, soy el form de reporte de venta en admin";
            // 
            // AdministradorViewReporteVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "AdministradorViewReporteVenta";
            Text = "AdministradorViewReporteVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}