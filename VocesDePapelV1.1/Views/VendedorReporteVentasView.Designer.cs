namespace VocesDePapelV1._1.Views
{
    partial class VendedorReporteVentasView
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
            DTFechaFinReporteVentaVendedor = new DateTimePicker();
            LFechaFinRVentaVendedor = new Label();
            LFechaInicioReporteVentaVendedo = new Label();
            DTFechaInicioReporteVentaVendedor = new DateTimePicker();
            LReporteVentaVendedor = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DTFechaFinReporteVentaVendedor
            // 
            DTFechaFinReporteVentaVendedor.Format = DateTimePickerFormat.Short;
            DTFechaFinReporteVentaVendedor.Location = new Point(674, 57);
            DTFechaFinReporteVentaVendedor.Name = "DTFechaFinReporteVentaVendedor";
            DTFechaFinReporteVentaVendedor.Size = new Size(155, 27);
            DTFechaFinReporteVentaVendedor.TabIndex = 86;
            // 
            // LFechaFinRVentaVendedor
            // 
            LFechaFinRVentaVendedor.AutoSize = true;
            LFechaFinRVentaVendedor.BackColor = Color.White;
            LFechaFinRVentaVendedor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFechaFinRVentaVendedor.Location = new Point(534, 51);
            LFechaFinRVentaVendedor.Name = "LFechaFinRVentaVendedor";
            LFechaFinRVentaVendedor.Size = new Size(105, 31);
            LFechaFinRVentaVendedor.TabIndex = 85;
            LFechaFinRVentaVendedor.Text = "Fecha fin";
            // 
            // LFechaInicioReporteVentaVendedo
            // 
            LFechaInicioReporteVentaVendedo.AutoSize = true;
            LFechaInicioReporteVentaVendedo.BackColor = Color.White;
            LFechaInicioReporteVentaVendedo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFechaInicioReporteVentaVendedo.Location = new Point(534, 20);
            LFechaInicioReporteVentaVendedo.Name = "LFechaInicioReporteVentaVendedo";
            LFechaInicioReporteVentaVendedo.Size = new Size(134, 31);
            LFechaInicioReporteVentaVendedo.TabIndex = 84;
            LFechaInicioReporteVentaVendedo.Text = "Fecha inicio";
            // 
            // DTFechaInicioReporteVentaVendedor
            // 
            DTFechaInicioReporteVentaVendedor.Format = DateTimePickerFormat.Short;
            DTFechaInicioReporteVentaVendedor.Location = new Point(674, 24);
            DTFechaInicioReporteVentaVendedor.Name = "DTFechaInicioReporteVentaVendedor";
            DTFechaInicioReporteVentaVendedor.Size = new Size(155, 27);
            DTFechaInicioReporteVentaVendedor.TabIndex = 83;
            // 
            // LReporteVentaVendedor
            // 
            LReporteVentaVendedor.AutoSize = true;
            LReporteVentaVendedor.BackColor = Color.White;
            LReporteVentaVendedor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LReporteVentaVendedor.Location = new Point(12, 20);
            LReporteVentaVendedor.Name = "LReporteVentaVendedor";
            LReporteVentaVendedor.Size = new Size(256, 38);
            LReporteVentaVendedor.TabIndex = 82;
            LReporteVentaVendedor.Text = "Reporte de Ventas";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(978, 106);
            label1.TabIndex = 81;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(779, 377);
            dataGridView1.TabIndex = 87;
            // 
            // VendedorReporteVentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(978, 642);
            Controls.Add(dataGridView1);
            Controls.Add(DTFechaFinReporteVentaVendedor);
            Controls.Add(LFechaFinRVentaVendedor);
            Controls.Add(LFechaInicioReporteVentaVendedo);
            Controls.Add(DTFechaInicioReporteVentaVendedor);
            Controls.Add(LReporteVentaVendedor);
            Controls.Add(label1);
            Name = "VendedorReporteVentasView";
            Text = "VendedorReporteVentasView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DTFechaFinReporteVentaVendedor;
        private Label LFechaFinRVentaVendedor;
        private Label LFechaInicioReporteVentaVendedo;
        private DateTimePicker DTFechaInicioReporteVentaVendedor;
        private Label LReporteVentaVendedor;
        private Label label1;
        private DataGridView dataGridView1;
    }
}