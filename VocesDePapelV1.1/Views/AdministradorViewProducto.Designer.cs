namespace VocesDePapelV1._1.Views
{
    partial class AdministradorViewProducto
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
            l_detalle_producto = new Label();
            btn_eliminar_usuario = new Button();
            btn_modificar_usuario = new Button();
            btn_guardar_usuario = new Button();
            cmb_categoria_producto = new ComboBox();
            cmb_estado_producto = new ComboBox();
            text_editorial_admin = new TextBox();
            text_precio_admin = new TextBox();
            text_stock_admin = new TextBox();
            text_titulo_admin = new TextBox();
            l_categoria = new Label();
            l_estado_producto = new Label();
            l_stock = new Label();
            l_precio = new Label();
            l_editorial = new Label();
            l_titulo = new Label();
            label1 = new Label();
            btn_buscar_producto = new Button();
            text_buscar_producto = new TextBox();
            cmb_buscar_por_producto = new ComboBox();
            l_buscar_producto = new Label();
            l_lista_productos = new Label();
            dataGridView1 = new DataGridView();
            btn_agregar_autor = new Button();
            btn_seleccionar = new DataGridViewButtonColumn();
            titulo = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            id_libro = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // l_detalle_producto
            // 
            l_detalle_producto.AutoSize = true;
            l_detalle_producto.BackColor = Color.White;
            l_detalle_producto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_detalle_producto.Location = new Point(95, 34);
            l_detalle_producto.Name = "l_detalle_producto";
            l_detalle_producto.Size = new Size(234, 31);
            l_detalle_producto.TabIndex = 37;
            l_detalle_producto.Text = "Detalle del Producto";
            // 
            // btn_eliminar_usuario
            // 
            btn_eliminar_usuario.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar_usuario.Location = new Point(63, 706);
            btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            btn_eliminar_usuario.Size = new Size(269, 43);
            btn_eliminar_usuario.TabIndex = 36;
            btn_eliminar_usuario.Text = "Eliminar";
            btn_eliminar_usuario.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_usuario
            // 
            btn_modificar_usuario.BackColor = Color.FromArgb(255, 192, 128);
            btn_modificar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_usuario.Location = new Point(63, 651);
            btn_modificar_usuario.Name = "btn_modificar_usuario";
            btn_modificar_usuario.Size = new Size(269, 43);
            btn_modificar_usuario.TabIndex = 35;
            btn_modificar_usuario.Text = "Modificar";
            btn_modificar_usuario.UseVisualStyleBackColor = false;
            // 
            // btn_guardar_usuario
            // 
            btn_guardar_usuario.BackColor = SystemColors.GradientActiveCaption;
            btn_guardar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar_usuario.Location = new Point(63, 548);
            btn_guardar_usuario.Name = "btn_guardar_usuario";
            btn_guardar_usuario.Size = new Size(269, 43);
            btn_guardar_usuario.TabIndex = 34;
            btn_guardar_usuario.Text = "Guardar";
            btn_guardar_usuario.UseVisualStyleBackColor = false;
            // 
            // cmb_categoria_producto
            // 
            cmb_categoria_producto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_categoria_producto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_categoria_producto.FormattingEnabled = true;
            cmb_categoria_producto.Location = new Point(63, 484);
            cmb_categoria_producto.Name = "cmb_categoria_producto";
            cmb_categoria_producto.Size = new Size(269, 36);
            cmb_categoria_producto.TabIndex = 33;
            // 
            // cmb_estado_producto
            // 
            cmb_estado_producto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_estado_producto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_estado_producto.FormattingEnabled = true;
            cmb_estado_producto.Location = new Point(63, 408);
            cmb_estado_producto.Name = "cmb_estado_producto";
            cmb_estado_producto.Size = new Size(269, 36);
            cmb_estado_producto.TabIndex = 32;
            // 
            // text_editorial_admin
            // 
            text_editorial_admin.Font = new Font("Segoe UI", 12F);
            text_editorial_admin.Location = new Point(63, 188);
            text_editorial_admin.Name = "text_editorial_admin";
            text_editorial_admin.Size = new Size(269, 34);
            text_editorial_admin.TabIndex = 31;
            // 
            // text_precio_admin
            // 
            text_precio_admin.Font = new Font("Segoe UI", 12F);
            text_precio_admin.Location = new Point(63, 260);
            text_precio_admin.Name = "text_precio_admin";
            text_precio_admin.Size = new Size(269, 34);
            text_precio_admin.TabIndex = 30;
            // 
            // text_stock_admin
            // 
            text_stock_admin.Font = new Font("Segoe UI", 12F);
            text_stock_admin.Location = new Point(63, 336);
            text_stock_admin.Name = "text_stock_admin";
            text_stock_admin.Size = new Size(269, 34);
            text_stock_admin.TabIndex = 29;
            // 
            // text_titulo_admin
            // 
            text_titulo_admin.Font = new Font("Segoe UI", 12F);
            text_titulo_admin.Location = new Point(63, 115);
            text_titulo_admin.Name = "text_titulo_admin";
            text_titulo_admin.Size = new Size(269, 34);
            text_titulo_admin.TabIndex = 27;
            // 
            // l_categoria
            // 
            l_categoria.AutoSize = true;
            l_categoria.BackColor = Color.White;
            l_categoria.Font = new Font("Segoe UI", 12F);
            l_categoria.Location = new Point(65, 450);
            l_categoria.Name = "l_categoria";
            l_categoria.Size = new Size(97, 28);
            l_categoria.TabIndex = 26;
            l_categoria.Text = "Categoria";
            // 
            // l_estado_producto
            // 
            l_estado_producto.AutoSize = true;
            l_estado_producto.BackColor = Color.White;
            l_estado_producto.Font = new Font("Segoe UI", 12F);
            l_estado_producto.Location = new Point(66, 376);
            l_estado_producto.Name = "l_estado_producto";
            l_estado_producto.Size = new Size(71, 28);
            l_estado_producto.TabIndex = 25;
            l_estado_producto.Text = "Estado";
            // 
            // l_stock
            // 
            l_stock.AutoSize = true;
            l_stock.BackColor = Color.White;
            l_stock.Font = new Font("Segoe UI", 12F);
            l_stock.Location = new Point(64, 304);
            l_stock.Name = "l_stock";
            l_stock.Size = new Size(60, 28);
            l_stock.TabIndex = 23;
            l_stock.Text = "Stock";
            // 
            // l_precio
            // 
            l_precio.AutoSize = true;
            l_precio.BackColor = Color.White;
            l_precio.Font = new Font("Segoe UI", 12F);
            l_precio.Location = new Point(66, 230);
            l_precio.Name = "l_precio";
            l_precio.Size = new Size(66, 28);
            l_precio.TabIndex = 22;
            l_precio.Text = "Precio";
            // 
            // l_editorial
            // 
            l_editorial.AutoSize = true;
            l_editorial.BackColor = Color.White;
            l_editorial.Font = new Font("Segoe UI", 12F);
            l_editorial.Location = new Point(67, 155);
            l_editorial.Name = "l_editorial";
            l_editorial.Size = new Size(85, 28);
            l_editorial.TabIndex = 21;
            l_editorial.Text = "Editorial";
            // 
            // l_titulo
            // 
            l_titulo.AutoSize = true;
            l_titulo.BackColor = Color.White;
            l_titulo.Font = new Font("Segoe UI", 12F);
            l_titulo.Location = new Point(67, 84);
            l_titulo.Name = "l_titulo";
            l_titulo.Size = new Size(62, 28);
            l_titulo.TabIndex = 20;
            l_titulo.Text = "Titulo";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(399, 781);
            label1.TabIndex = 19;
            // 
            // btn_buscar_producto
            // 
            btn_buscar_producto.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_producto.Location = new Point(1250, 61);
            btn_buscar_producto.Name = "btn_buscar_producto";
            btn_buscar_producto.Size = new Size(66, 43);
            btn_buscar_producto.TabIndex = 43;
            btn_buscar_producto.UseVisualStyleBackColor = false;
            // 
            // text_buscar_producto
            // 
            text_buscar_producto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_producto.Location = new Point(979, 65);
            text_buscar_producto.Name = "text_buscar_producto";
            text_buscar_producto.Size = new Size(269, 31);
            text_buscar_producto.TabIndex = 42;
            // 
            // cmb_buscar_por_producto
            // 
            cmb_buscar_por_producto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_buscar_por_producto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_buscar_por_producto.FormattingEnabled = true;
            cmb_buscar_por_producto.Location = new Point(815, 63);
            cmb_buscar_por_producto.Name = "cmb_buscar_por_producto";
            cmb_buscar_por_producto.Size = new Size(158, 33);
            cmb_buscar_por_producto.TabIndex = 41;
            // 
            // l_buscar_producto
            // 
            l_buscar_producto.AutoSize = true;
            l_buscar_producto.BackColor = Color.White;
            l_buscar_producto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_buscar_producto.Location = new Point(705, 69);
            l_buscar_producto.Name = "l_buscar_producto";
            l_buscar_producto.Size = new Size(96, 25);
            l_buscar_producto.TabIndex = 40;
            l_buscar_producto.Text = "Buscar por";
            // 
            // l_lista_productos
            // 
            l_lista_productos.BackColor = Color.White;
            l_lista_productos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_productos.Location = new Point(415, 46);
            l_lista_productos.Name = "l_lista_productos";
            l_lista_productos.Size = new Size(903, 66);
            l_lista_productos.TabIndex = 39;
            l_lista_productos.Text = "Lista de productos";
            l_lista_productos.TextAlign = ContentAlignment.MiddleLeft;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, titulo, editorial, id_libro, precio, stock, estado, categoria });
            dataGridView1.Location = new Point(415, 142);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(903, 564);
            dataGridView1.TabIndex = 38;
            // 
            // btn_agregar_autor
            // 
            btn_agregar_autor.BackColor = Color.FromArgb(128, 255, 128);
            btn_agregar_autor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_autor.Location = new Point(64, 602);
            btn_agregar_autor.Name = "btn_agregar_autor";
            btn_agregar_autor.Size = new Size(269, 43);
            btn_agregar_autor.TabIndex = 44;
            btn_agregar_autor.Text = "Agregar autor";
            btn_agregar_autor.UseVisualStyleBackColor = false;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.MinimumWidth = 6;
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Width = 30;
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
            // AdministradorViewProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
            Controls.Add(btn_agregar_autor);
            Controls.Add(btn_buscar_producto);
            Controls.Add(text_buscar_producto);
            Controls.Add(cmb_buscar_por_producto);
            Controls.Add(l_buscar_producto);
            Controls.Add(l_lista_productos);
            Controls.Add(dataGridView1);
            Controls.Add(l_detalle_producto);
            Controls.Add(btn_eliminar_usuario);
            Controls.Add(btn_modificar_usuario);
            Controls.Add(btn_guardar_usuario);
            Controls.Add(cmb_categoria_producto);
            Controls.Add(cmb_estado_producto);
            Controls.Add(text_editorial_admin);
            Controls.Add(text_precio_admin);
            Controls.Add(text_stock_admin);
            Controls.Add(text_titulo_admin);
            Controls.Add(l_categoria);
            Controls.Add(l_estado_producto);
            Controls.Add(l_stock);
            Controls.Add(l_precio);
            Controls.Add(l_editorial);
            Controls.Add(l_titulo);
            Controls.Add(label1);
            Name = "AdministradorViewProducto";
            Text = "AdministradorViewProducto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_detalle_producto;
        private Button btn_eliminar_usuario;
        private Button btn_modificar_usuario;
        private Button btn_guardar_usuario;
        private ComboBox cmb_categoria_producto;
        private ComboBox cmb_estado_producto;
        private TextBox text_editorial_admin;
        private TextBox text_precio_admin;
        private TextBox text_stock_admin;
        private TextBox text_cuit_usuario;
        private TextBox text_titulo_admin;
        private Label l_categoria;
        private Label l_estado_producto;
        private Label l_cuit;
        private Label l_stock;
        private Label l_precio;
        private Label l_editorial;
        private Label l_titulo;
        private Label label1;
        private Button btn_buscar_producto;
        private TextBox text_buscar_producto;
        private ComboBox cmb_buscar_por_producto;
        private Label l_buscar_producto;
        private Label l_lista_productos;
        private DataGridView dataGridView1;
        private Button btn_agregar_autor;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn editorial;
        private DataGridViewTextBoxColumn id_libro;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn categoria;
    }
}