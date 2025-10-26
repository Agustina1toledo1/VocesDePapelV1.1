namespace VocesDePapelV1._1.Views
{
    partial class GerenteViewReporteLibroStock
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
            label2 = new Label();
            label1 = new Label();
            btn_buscar_stock = new Button();
            label5 = new Label();
            dataGridViewReporteStock = new DataGridView();
            btn_generar_reporte_stockpdf = new Button();
            txt_buscar_stock_reporte_producto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReporteStock).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 25);
            label2.Name = "label2";
            label2.Size = new Size(319, 38);
            label2.TabIndex = 74;
            label2.Text = "Reporte stock de libros";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1340, 106);
            label1.TabIndex = 71;
            // 
            // btn_buscar_stock
            // 
            btn_buscar_stock.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_stock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_stock.Location = new Point(953, 29);
            btn_buscar_stock.Name = "btn_buscar_stock";
            btn_buscar_stock.Size = new Size(125, 43);
            btn_buscar_stock.TabIndex = 77;
            btn_buscar_stock.Text = "Buscar";
            btn_buscar_stock.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(466, 33);
            label5.Name = "label5";
            label5.Size = new Size(175, 31);
            label5.TabIndex = 76;
            label5.Text = "Menor o igual a";
            // 
            // dataGridViewReporteStock
            // 
            dataGridViewReporteStock.AllowUserToAddRows = false;
            dataGridViewReporteStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewReporteStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReporteStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReporteStock.Location = new Point(219, 133);
            dataGridViewReporteStock.MultiSelect = false;
            dataGridViewReporteStock.Name = "dataGridViewReporteStock";
            dataGridViewReporteStock.ReadOnly = true;
            dataGridViewReporteStock.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewReporteStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewReporteStock.Size = new Size(903, 564);
            dataGridViewReporteStock.TabIndex = 79;
            // 
            // btn_generar_reporte_stockpdf
            // 
            btn_generar_reporte_stockpdf.BackColor = Color.LightGreen;
            btn_generar_reporte_stockpdf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_generar_reporte_stockpdf.Location = new Point(1128, 133);
            btn_generar_reporte_stockpdf.Name = "btn_generar_reporte_stockpdf";
            btn_generar_reporte_stockpdf.Size = new Size(169, 43);
            btn_generar_reporte_stockpdf.TabIndex = 91;
            btn_generar_reporte_stockpdf.Text = "Generar pdf";
            btn_generar_reporte_stockpdf.UseVisualStyleBackColor = false;
            // 
            // txt_buscar_stock_reporte_producto
            // 
            txt_buscar_stock_reporte_producto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_buscar_stock_reporte_producto.Location = new Point(676, 40);
            txt_buscar_stock_reporte_producto.Name = "txt_buscar_stock_reporte_producto";
            txt_buscar_stock_reporte_producto.Size = new Size(202, 34);
            txt_buscar_stock_reporte_producto.TabIndex = 93;
            // 
            // GerenteViewReporteLibroStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
            Controls.Add(txt_buscar_stock_reporte_producto);
            Controls.Add(btn_generar_reporte_stockpdf);
            Controls.Add(dataGridViewReporteStock);
            Controls.Add(btn_buscar_stock);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GerenteViewReporteLibroStock";
            Text = "GerenteViewReporteLibro";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReporteStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_buscar_stock;
        private Label label5;
        private DataGridView dataGridViewReporteStock;
        private Button btn_generar_reporte_stockpdf;
        private TextBox txt_buscar_stock_reporte_producto;
    }
}