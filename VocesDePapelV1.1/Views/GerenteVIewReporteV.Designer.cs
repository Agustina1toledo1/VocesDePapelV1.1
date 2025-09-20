namespace VocesDePapelV1._1.Views
{
    partial class GerenteVIewReporteV
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
            btn_buscar_vendedor_gerente = new Button();
            cmb_vendedor = new ComboBox();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            nro_venta = new DataGridViewTextBoxColumn();
            fecha_hora = new DataGridViewTextBoxColumn();
            vendedor = new DataGridViewTextBoxColumn();
            nombre_cliente = new DataGridViewTextBoxColumn();
            codigo_libro = new DataGridViewTextBoxColumn();
            libros = new DataGridViewTextBoxColumn();
            cantidad_libro = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_buscar_vendedor_gerente
            // 
            btn_buscar_vendedor_gerente.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_vendedor_gerente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_vendedor_gerente.Location = new Point(1098, 41);
            btn_buscar_vendedor_gerente.Name = "btn_buscar_vendedor_gerente";
            btn_buscar_vendedor_gerente.Size = new Size(125, 43);
            btn_buscar_vendedor_gerente.TabIndex = 69;
            btn_buscar_vendedor_gerente.Text = "Buscar";
            btn_buscar_vendedor_gerente.UseVisualStyleBackColor = false;
            // 
            // cmb_vendedor
            // 
            cmb_vendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_vendedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_vendedor.FormattingEnabled = true;
            cmb_vendedor.Location = new Point(807, 45);
            cmb_vendedor.Name = "cmb_vendedor";
            cmb_vendedor.Size = new Size(269, 36);
            cmb_vendedor.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(688, 46);
            label5.Name = "label5";
            label5.Size = new Size(113, 31);
            label5.TabIndex = 67;
            label5.Text = "Vendedor";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(459, 63);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(155, 27);
            dateTimePicker2.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(319, 57);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 65;
            label4.Text = "Fecha fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 26);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 64;
            label3.Text = "Fecha inicio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(459, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 27);
            dateTimePicker1.TabIndex = 63;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1340, 106);
            label1.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 26);
            label2.Name = "label2";
            label2.Size = new Size(256, 38);
            label2.TabIndex = 70;
            label2.Text = "Reporte de Ventas";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nro_venta, fecha_hora, vendedor, nombre_cliente, codigo_libro, libros, cantidad_libro, total });
            dataGridView1.Location = new Point(184, 148);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(1009, 564);
            dataGridView1.TabIndex = 71;
            // 
            // nro_venta
            // 
            nro_venta.HeaderText = "Nro de venta";
            nro_venta.MinimumWidth = 6;
            nro_venta.Name = "nro_venta";
            nro_venta.ReadOnly = true;
            nro_venta.Width = 125;
            // 
            // fecha_hora
            // 
            fecha_hora.HeaderText = "Fecha y Hora";
            fecha_hora.MinimumWidth = 6;
            fecha_hora.Name = "fecha_hora";
            fecha_hora.ReadOnly = true;
            fecha_hora.Width = 125;
            // 
            // vendedor
            // 
            vendedor.HeaderText = "Vendedor";
            vendedor.MinimumWidth = 6;
            vendedor.Name = "vendedor";
            vendedor.ReadOnly = true;
            vendedor.Width = 125;
            // 
            // nombre_cliente
            // 
            nombre_cliente.HeaderText = "Nombre CLiente";
            nombre_cliente.MinimumWidth = 6;
            nombre_cliente.Name = "nombre_cliente";
            nombre_cliente.ReadOnly = true;
            nombre_cliente.Width = 125;
            // 
            // codigo_libro
            // 
            codigo_libro.HeaderText = "Codigo Libro";
            codigo_libro.MinimumWidth = 6;
            codigo_libro.Name = "codigo_libro";
            codigo_libro.ReadOnly = true;
            codigo_libro.Width = 125;
            // 
            // libros
            // 
            libros.HeaderText = "Libros";
            libros.MinimumWidth = 6;
            libros.Name = "libros";
            libros.ReadOnly = true;
            libros.Width = 125;
            // 
            // cantidad_libro
            // 
            cantidad_libro.HeaderText = "Cantidad de Libros";
            cantidad_libro.MinimumWidth = 6;
            cantidad_libro.Name = "cantidad_libro";
            cantidad_libro.ReadOnly = true;
            cantidad_libro.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 125;
            // 
            // GerenteVIewReporteV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(btn_buscar_vendedor_gerente);
            Controls.Add(cmb_vendedor);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "GerenteVIewReporteV";
            Text = "GerenteVIewReporteV";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscar_vendedor_gerente;
        private ComboBox cmb_vendedor;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nro_venta;
        private DataGridViewTextBoxColumn fecha_hora;
        private DataGridViewTextBoxColumn vendedor;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn codigo_libro;
        private DataGridViewTextBoxColumn libros;
        private DataGridViewTextBoxColumn cantidad_libro;
        private DataGridViewTextBoxColumn total;
    }
}