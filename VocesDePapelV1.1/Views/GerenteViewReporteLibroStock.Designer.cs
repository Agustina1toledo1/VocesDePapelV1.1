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
            btn_buscar_poco_stock = new Button();
            label5 = new Label();
            text_cantidad_libro_reporte_gerente = new TextBox();
            dataGridView1 = new DataGridView();
            titulo = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            id_libro = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            btn_modificar_usuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // btn_buscar_poco_stock
            // 
            btn_buscar_poco_stock.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_poco_stock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_poco_stock.Location = new Point(953, 23);
            btn_buscar_poco_stock.Name = "btn_buscar_poco_stock";
            btn_buscar_poco_stock.Size = new Size(125, 43);
            btn_buscar_poco_stock.TabIndex = 77;
            btn_buscar_poco_stock.Text = "Buscar";
            btn_buscar_poco_stock.UseVisualStyleBackColor = false;
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
            // text_cantidad_libro_reporte_gerente
            // 
            text_cantidad_libro_reporte_gerente.Font = new Font("Segoe UI", 12F);
            text_cantidad_libro_reporte_gerente.Location = new Point(656, 32);
            text_cantidad_libro_reporte_gerente.Name = "text_cantidad_libro_reporte_gerente";
            text_cantidad_libro_reporte_gerente.Size = new Size(269, 34);
            text_cantidad_libro_reporte_gerente.TabIndex = 78;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { titulo, editorial, id_libro, precio, stock, estado, categoria });
            dataGridView1.Location = new Point(219, 133);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(903, 564);
            dataGridView1.TabIndex = 79;
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
            // btn_modificar_usuario
            // 
            btn_modificar_usuario.BackColor = Color.FromArgb(255, 192, 128);
            btn_modificar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_usuario.Location = new Point(1128, 133);
            btn_modificar_usuario.Name = "btn_modificar_usuario";
            btn_modificar_usuario.Size = new Size(169, 43);
            btn_modificar_usuario.TabIndex = 91;
            btn_modificar_usuario.Text = "Generar excel";
            btn_modificar_usuario.UseVisualStyleBackColor = false;
            // 
            // GerenteViewReporteLibroStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
            Controls.Add(btn_modificar_usuario);
            Controls.Add(dataGridView1);
            Controls.Add(text_cantidad_libro_reporte_gerente);
            Controls.Add(btn_buscar_poco_stock);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GerenteViewReporteLibroStock";
            Text = "GerenteViewReporteLibro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_buscar_poco_stock;
        private Label label5;
        private TextBox text_cantidad_libro_reporte_gerente;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn editorial;
        private DataGridViewTextBoxColumn id_libro;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn categoria;
        private Button btn_modificar_usuario;
    }
}