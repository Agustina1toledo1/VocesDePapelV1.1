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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            l_detalle_producto = new Label();
            btn_eliminar_producto = new Button();
            btn_modificar_producto = new Button();
            btn_guardar_producto = new Button();
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
            dataGridProducto = new DataGridView();
            btn_limpiar_producto = new Button();
            cmb_autor = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProducto).BeginInit();
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
            // btn_eliminar_producto
            // 
            btn_eliminar_producto.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar_producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar_producto.Location = new Point(63, 788);
            btn_eliminar_producto.Name = "btn_eliminar_producto";
            btn_eliminar_producto.Size = new Size(269, 43);
            btn_eliminar_producto.TabIndex = 36;
            btn_eliminar_producto.Text = "Eliminar";
            btn_eliminar_producto.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_producto
            // 
            btn_modificar_producto.BackColor = SystemColors.GradientActiveCaption;
            btn_modificar_producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_producto.Location = new Point(63, 673);
            btn_modificar_producto.Name = "btn_modificar_producto";
            btn_modificar_producto.Size = new Size(269, 43);
            btn_modificar_producto.TabIndex = 35;
            btn_modificar_producto.Text = "Modificar";
            btn_modificar_producto.UseVisualStyleBackColor = false;
            // 
            // btn_guardar_producto
            // 
            btn_guardar_producto.BackColor = Color.LightGreen;
            btn_guardar_producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar_producto.Location = new Point(63, 616);
            btn_guardar_producto.Name = "btn_guardar_producto";
            btn_guardar_producto.Size = new Size(269, 43);
            btn_guardar_producto.TabIndex = 34;
            btn_guardar_producto.Text = "Guardar";
            btn_guardar_producto.UseVisualStyleBackColor = false;
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
            label1.Size = new Size(399, 900);
            label1.TabIndex = 19;
            // 
            // btn_buscar_producto
            // 
            btn_buscar_producto.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_producto.Image = Properties.Resources.lupa;
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
            l_buscar_producto.Location = new Point(705, 67);
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
            // dataGridProducto
            // 
            dataGridProducto.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducto.Location = new Point(415, 134);
            dataGridProducto.MultiSelect = false;
            dataGridProducto.Name = "dataGridProducto";
            dataGridProducto.ReadOnly = true;
            dataGridProducto.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridProducto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridProducto.Size = new Size(1072, 564);
            dataGridProducto.TabIndex = 38;
            // 
            // btn_limpiar_producto
            // 
            btn_limpiar_producto.BackColor = Color.FromArgb(255, 192, 128);
            btn_limpiar_producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar_producto.Location = new Point(63, 728);
            btn_limpiar_producto.Name = "btn_limpiar_producto";
            btn_limpiar_producto.Size = new Size(269, 43);
            btn_limpiar_producto.TabIndex = 44;
            btn_limpiar_producto.Text = "Limpiar";
            btn_limpiar_producto.UseVisualStyleBackColor = false;
            // 
            // cmb_autor
            // 
            cmb_autor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_autor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_autor.FormattingEnabled = true;
            cmb_autor.Location = new Point(61, 557);
            cmb_autor.Name = "cmb_autor";
            cmb_autor.Size = new Size(269, 36);
            cmb_autor.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(63, 523);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 45;
            label2.Text = "Autor";
            // 
            // AdministradorViewProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1736, 900);
            Controls.Add(cmb_autor);
            Controls.Add(label2);
            Controls.Add(btn_limpiar_producto);
            Controls.Add(btn_buscar_producto);
            Controls.Add(text_buscar_producto);
            Controls.Add(cmb_buscar_por_producto);
            Controls.Add(l_buscar_producto);
            Controls.Add(l_lista_productos);
            Controls.Add(dataGridProducto);
            Controls.Add(l_detalle_producto);
            Controls.Add(btn_eliminar_producto);
            Controls.Add(btn_modificar_producto);
            Controls.Add(btn_guardar_producto);
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
            ((System.ComponentModel.ISupportInitialize)dataGridProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_detalle_producto;
        private Button btn_eliminar_producto;
        private Button btn_modificar_producto;
        private Button btn_guardar_producto;
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
        private DataGridView dataGridProducto;
        private Button btn_limpiar_producto;
        private ComboBox cmb_autor;
        private Label label2;
    }
}