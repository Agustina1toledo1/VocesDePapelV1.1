namespace VocesDePapelV1._1.Views
{
    partial class GerenteViewReporteLibroMasVendidos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dGVReporteLibroMV = new DataGridView();
            label2 = new Label();
            lReporteLibroMV = new Label();
            dTPFechaFinReporteLibroMV = new DateTimePicker();
            lFechaFinRLMV = new Label();
            lFechaInicioRLMV = new Label();
            dTPFechaInicioReporteLibroMV = new DateTimePicker();
            btn_generar_pdf_reporteLibroMV = new Button();
            btnBuscarReporteLibroMV = new Button();
            txtBCatidadReporteLibroMV = new TextBox();
            grpEstadisticas = new GroupBox();
            lCategoriaMVTxt = new Label();
            lCategoriaMV = new Label();
            lblTotal = new Label();
            lTotalVentasMV = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVReporteLibroMV).BeginInit();
            grpEstadisticas.SuspendLayout();
            SuspendLayout();
            // 
            // dGVReporteLibroMV
            // 
            dGVReporteLibroMV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGVReporteLibroMV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGVReporteLibroMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVReporteLibroMV.Location = new Point(219, 214);
            dGVReporteLibroMV.MultiSelect = false;
            dGVReporteLibroMV.Name = "dGVReporteLibroMV";
            dGVReporteLibroMV.ReadOnly = true;
            dGVReporteLibroMV.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dGVReporteLibroMV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dGVReporteLibroMV.Size = new Size(929, 329);
            dGVReporteLibroMV.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 26);
            label2.Name = "label2";
            label2.Size = new Size(514, 38);
            label2.TabIndex = 76;
            label2.Text = "Reporte de los 10 libros más vendidos";
            // 
            // lReporteLibroMV
            // 
            lReporteLibroMV.BackColor = Color.White;
            lReporteLibroMV.Dock = DockStyle.Top;
            lReporteLibroMV.Location = new Point(0, 0);
            lReporteLibroMV.Name = "lReporteLibroMV";
            lReporteLibroMV.Size = new Size(1340, 106);
            lReporteLibroMV.TabIndex = 75;
            // 
            // dTPFechaFinReporteLibroMV
            // 
            dTPFechaFinReporteLibroMV.Format = DateTimePickerFormat.Short;
            dTPFechaFinReporteLibroMV.Location = new Point(922, 61);
            dTPFechaFinReporteLibroMV.Name = "dTPFechaFinReporteLibroMV";
            dTPFechaFinReporteLibroMV.Size = new Size(155, 27);
            dTPFechaFinReporteLibroMV.TabIndex = 80;
            // 
            // lFechaFinRLMV
            // 
            lFechaFinRLMV.AutoSize = true;
            lFechaFinRLMV.BackColor = Color.White;
            lFechaFinRLMV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lFechaFinRLMV.Location = new Point(782, 55);
            lFechaFinRLMV.Name = "lFechaFinRLMV";
            lFechaFinRLMV.Size = new Size(105, 31);
            lFechaFinRLMV.TabIndex = 79;
            lFechaFinRLMV.Text = "Fecha fin";
            // 
            // lFechaInicioRLMV
            // 
            lFechaInicioRLMV.AutoSize = true;
            lFechaInicioRLMV.BackColor = Color.White;
            lFechaInicioRLMV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lFechaInicioRLMV.Location = new Point(782, 24);
            lFechaInicioRLMV.Name = "lFechaInicioRLMV";
            lFechaInicioRLMV.Size = new Size(134, 31);
            lFechaInicioRLMV.TabIndex = 78;
            lFechaInicioRLMV.Text = "Fecha inicio";
            // 
            // dTPFechaInicioReporteLibroMV
            // 
            dTPFechaInicioReporteLibroMV.Format = DateTimePickerFormat.Short;
            dTPFechaInicioReporteLibroMV.Location = new Point(922, 28);
            dTPFechaInicioReporteLibroMV.Name = "dTPFechaInicioReporteLibroMV";
            dTPFechaInicioReporteLibroMV.Size = new Size(155, 27);
            dTPFechaInicioReporteLibroMV.TabIndex = 77;
            // 
            // btn_generar_pdf_reporteLibroMV
            // 
            btn_generar_pdf_reporteLibroMV.BackColor = Color.FromArgb(255, 192, 128);
            btn_generar_pdf_reporteLibroMV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_generar_pdf_reporteLibroMV.Location = new Point(1154, 213);
            btn_generar_pdf_reporteLibroMV.Name = "btn_generar_pdf_reporteLibroMV";
            btn_generar_pdf_reporteLibroMV.Size = new Size(169, 43);
            btn_generar_pdf_reporteLibroMV.TabIndex = 91;
            btn_generar_pdf_reporteLibroMV.Text = "Generar PDF";
            btn_generar_pdf_reporteLibroMV.UseVisualStyleBackColor = false;
            // 
            // btnBuscarReporteLibroMV
            // 
            btnBuscarReporteLibroMV.BackColor = SystemColors.GradientActiveCaption;
            btnBuscarReporteLibroMV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarReporteLibroMV.Location = new Point(1154, 30);
            btnBuscarReporteLibroMV.Name = "btnBuscarReporteLibroMV";
            btnBuscarReporteLibroMV.Size = new Size(110, 40);
            btnBuscarReporteLibroMV.TabIndex = 92;
            btnBuscarReporteLibroMV.Text = "Buscar";
            btnBuscarReporteLibroMV.UseVisualStyleBackColor = false;
            // 
            // txtBCatidadReporteLibroMV
            // 
            txtBCatidadReporteLibroMV.BorderStyle = BorderStyle.None;
            txtBCatidadReporteLibroMV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBCatidadReporteLibroMV.ForeColor = SystemColors.Window;
            txtBCatidadReporteLibroMV.Location = new Point(32, 72);
            txtBCatidadReporteLibroMV.Name = "txtBCatidadReporteLibroMV";
            txtBCatidadReporteLibroMV.Size = new Size(125, 27);
            txtBCatidadReporteLibroMV.TabIndex = 94;
            txtBCatidadReporteLibroMV.Text = "10";
            // 
            // grpEstadisticas
            // 
            grpEstadisticas.Controls.Add(lCategoriaMVTxt);
            grpEstadisticas.Controls.Add(lCategoriaMV);
            grpEstadisticas.Controls.Add(lblTotal);
            grpEstadisticas.Controls.Add(lTotalVentasMV);
            grpEstadisticas.Dock = DockStyle.Top;
            grpEstadisticas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEstadisticas.Location = new Point(0, 106);
            grpEstadisticas.Name = "grpEstadisticas";
            grpEstadisticas.Size = new Size(1340, 80);
            grpEstadisticas.TabIndex = 95;
            grpEstadisticas.TabStop = false;
            grpEstadisticas.Text = "Estadísticas del Período";
            // 
            // lCategoriaMVTxt
            // 
            lCategoriaMVTxt.AutoSize = true;
            lCategoriaMVTxt.BackColor = SystemColors.ActiveCaption;
            lCategoriaMVTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lCategoriaMVTxt.ForeColor = Color.Red;
            lCategoriaMVTxt.Location = new Point(725, 35);
            lCategoriaMVTxt.Name = "lCategoriaMVTxt";
            lCategoriaMVTxt.Size = new Size(235, 28);
            lCategoriaMVTxt.TabIndex = 5;
            lCategoriaMVTxt.Text = "Categoria Más Vendida:";
            // 
            // lCategoriaMV
            // 
            lCategoriaMV.BorderStyle = BorderStyle.Fixed3D;
            lCategoriaMV.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lCategoriaMV.ForeColor = Color.Blue;
            lCategoriaMV.Location = new Point(980, 35);
            lCategoriaMV.Name = "lCategoriaMV";
            lCategoriaMV.Size = new Size(343, 31);
            lCategoriaMV.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(218, 35);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(133, 28);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total Ventas:";
            // 
            // lTotalVentasMV
            // 
            lTotalVentasMV.BorderStyle = BorderStyle.Fixed3D;
            lTotalVentasMV.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTotalVentasMV.ForeColor = Color.Red;
            lTotalVentasMV.Location = new Point(364, 35);
            lTotalVentasMV.Name = "lTotalVentasMV";
            lTotalVentasMV.Size = new Size(194, 31);
            lTotalVentasMV.TabIndex = 0;
            // 
            // GerenteViewReporteLibroMasVendidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
            Controls.Add(grpEstadisticas);
            Controls.Add(txtBCatidadReporteLibroMV);
            Controls.Add(btnBuscarReporteLibroMV);
            Controls.Add(btn_generar_pdf_reporteLibroMV);
            Controls.Add(dTPFechaFinReporteLibroMV);
            Controls.Add(lFechaFinRLMV);
            Controls.Add(lFechaInicioRLMV);
            Controls.Add(dTPFechaInicioReporteLibroMV);
            Controls.Add(label2);
            Controls.Add(lReporteLibroMV);
            Controls.Add(dGVReporteLibroMV);
            Name = "GerenteViewReporteLibroMasVendidos";
            Text = "GerenteViewReporteLibroMasVendidos";
            ((System.ComponentModel.ISupportInitialize)dGVReporteLibroMV).EndInit();
            grpEstadisticas.ResumeLayout(false);
            grpEstadisticas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVReporteLibroMV;
        private Label label2;
        private Label lReporteLibroMV;
        private DateTimePicker dTPFechaFinReporteLibroMV;
        private Label lFechaFinRLMV;
        private Label lFechaInicioRLMV;
        private DateTimePicker dTPFechaInicioReporteLibroMV;
        private Button btn_generar_pdf_reporteLibroMV;
        private Button btnBuscarReporteLibroMV;
        private TextBox txtBCatidadReporteLibroMV;
        private GroupBox grpEstadisticas;
        private Label lCategoriaMVTxt;
        private Label lCategoriaMV;
        private Label lblTotal;
        private Label lTotalVentasMV;
    }
}