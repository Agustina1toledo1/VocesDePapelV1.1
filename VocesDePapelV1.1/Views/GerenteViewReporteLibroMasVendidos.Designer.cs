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
            dataGridView1 = new DataGridView();
            cantidad_vendida = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            id_libro = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cantidad_vendida, titulo, editorial, id_libro, precio, stock, estado, categoria });
            dataGridView1.Location = new Point(219, 136);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(929, 564);
            dataGridView1.TabIndex = 39;
            // 
            // cantidad_vendida
            // 
            cantidad_vendida.HeaderText = "Cantidad Vendida";
            cantidad_vendida.MinimumWidth = 6;
            cantidad_vendida.Name = "cantidad_vendida";
            cantidad_vendida.ReadOnly = true;
            cantidad_vendida.Width = 125;
            // 
            // titulo
            // 
            titulo.HeaderText = "Título";
            titulo.MinimumWidth = 6;
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            titulo.Width = 125;
            // 
            // editorial
            // 
            editorial.HeaderText = "Editorial";
            editorial.MinimumWidth = 6;
            editorial.Name = "editorial";
            editorial.ReadOnly = true;
            editorial.Width = 125;
            // 
            // id_libro
            // 
            id_libro.HeaderText = "id_libro";
            id_libro.MinimumWidth = 6;
            id_libro.Name = "id_libro";
            id_libro.ReadOnly = true;
            id_libro.Visible = false;
            id_libro.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 125;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Width = 125;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 125;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 26);
            label2.Name = "label2";
            label2.Size = new Size(429, 38);
            label2.TabIndex = 76;
            label2.Text = "Reporte de libros más vendidos";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1340, 106);
            label1.TabIndex = 75;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(694, 63);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(155, 27);
            dateTimePicker2.TabIndex = 80;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(554, 57);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 79;
            label4.Text = "Fecha fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(554, 26);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 78;
            label3.Text = "Fecha inicio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(694, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 27);
            dateTimePicker1.TabIndex = 77;
            // 
            // GerenteViewReporteLibroMasVendidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "GerenteViewReporteLibroMasVendidos";
            Text = "GerenteViewReporteLibroMasVendidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn cantidad_vendida;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn editorial;
        private DataGridViewTextBoxColumn id_libro;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn categoria;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}