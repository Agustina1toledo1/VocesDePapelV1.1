namespace VocesDePapelV1._1.Views
{
    partial class AdministradorViewAutores
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
            btn_eliminar_autor = new Button();
            btn_modificar_autor = new Button();
            btn_registrar_autor = new Button();
            cmb_estado_producto = new ComboBox();
            text_nombre_autor_admin = new TextBox();
            l_estado_producto = new Label();
            l_nombre_autor = new Label();
            label1 = new Label();
            l_lista_autores = new Label();
            dataGridView1 = new DataGridView();
            btn_seleccionar = new DataGridViewButtonColumn();
            nombre = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            btn_buscar_autor = new Button();
            text_buscar_autor = new TextBox();
            l_buscar_autor = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // l_detalle_producto
            // 
            l_detalle_producto.AutoSize = true;
            l_detalle_producto.BackColor = Color.White;
            l_detalle_producto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_detalle_producto.Location = new Point(101, 38);
            l_detalle_producto.Name = "l_detalle_producto";
            l_detalle_producto.Size = new Size(197, 31);
            l_detalle_producto.TabIndex = 54;
            l_detalle_producto.Text = "Detalle del Autor";
            // 
            // btn_eliminar_autor
            // 
            btn_eliminar_autor.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar_autor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar_autor.Location = new Point(69, 367);
            btn_eliminar_autor.Name = "btn_eliminar_autor";
            btn_eliminar_autor.Size = new Size(269, 43);
            btn_eliminar_autor.TabIndex = 53;
            btn_eliminar_autor.Text = "Eliminar";
            btn_eliminar_autor.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_autor
            // 
            btn_modificar_autor.BackColor = Color.FromArgb(255, 192, 128);
            btn_modificar_autor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_autor.Location = new Point(69, 305);
            btn_modificar_autor.Name = "btn_modificar_autor";
            btn_modificar_autor.Size = new Size(269, 43);
            btn_modificar_autor.TabIndex = 52;
            btn_modificar_autor.Text = "Modificar";
            btn_modificar_autor.UseVisualStyleBackColor = false;
            // 
            // btn_registrar_autor
            // 
            btn_registrar_autor.BackColor = SystemColors.GradientActiveCaption;
            btn_registrar_autor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar_autor.Location = new Point(70, 245);
            btn_registrar_autor.Name = "btn_registrar_autor";
            btn_registrar_autor.Size = new Size(269, 43);
            btn_registrar_autor.TabIndex = 51;
            btn_registrar_autor.Text = "Registrar";
            btn_registrar_autor.UseVisualStyleBackColor = false;
            // 
            // cmb_estado_producto
            // 
            cmb_estado_producto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_estado_producto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_estado_producto.FormattingEnabled = true;
            cmb_estado_producto.Location = new Point(69, 188);
            cmb_estado_producto.Name = "cmb_estado_producto";
            cmb_estado_producto.Size = new Size(269, 36);
            cmb_estado_producto.TabIndex = 49;
            // 
            // text_nombre_autor_admin
            // 
            text_nombre_autor_admin.Font = new Font("Segoe UI", 12F);
            text_nombre_autor_admin.Location = new Point(69, 119);
            text_nombre_autor_admin.Name = "text_nombre_autor_admin";
            text_nombre_autor_admin.Size = new Size(269, 34);
            text_nombre_autor_admin.TabIndex = 45;
            // 
            // l_estado_producto
            // 
            l_estado_producto.AutoSize = true;
            l_estado_producto.BackColor = Color.White;
            l_estado_producto.Font = new Font("Segoe UI", 12F);
            l_estado_producto.Location = new Point(72, 156);
            l_estado_producto.Name = "l_estado_producto";
            l_estado_producto.Size = new Size(71, 28);
            l_estado_producto.TabIndex = 43;
            l_estado_producto.Text = "Estado";
            // 
            // l_nombre_autor
            // 
            l_nombre_autor.AutoSize = true;
            l_nombre_autor.BackColor = Color.White;
            l_nombre_autor.Font = new Font("Segoe UI", 12F);
            l_nombre_autor.Location = new Point(73, 88);
            l_nombre_autor.Name = "l_nombre_autor";
            l_nombre_autor.Size = new Size(85, 28);
            l_nombre_autor.TabIndex = 39;
            l_nombre_autor.Text = "Nombre";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(399, 464);
            label1.TabIndex = 38;
            // 
            // l_lista_autores
            // 
            l_lista_autores.BackColor = Color.White;
            l_lista_autores.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_autores.Location = new Point(416, 10);
            l_lista_autores.Name = "l_lista_autores";
            l_lista_autores.Size = new Size(903, 66);
            l_lista_autores.TabIndex = 56;
            l_lista_autores.Text = "Lista de autores";
            l_lista_autores.TextAlign = ContentAlignment.MiddleLeft;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, nombre, estado });
            dataGridView1.Location = new Point(416, 106);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(903, 304);
            dataGridView1.TabIndex = 55;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.MinimumWidth = 6;
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Width = 30;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 125;
            // 
            // btn_buscar_autor
            // 
            btn_buscar_autor.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_autor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_autor.Image = Properties.Resources.lupa;
            btn_buscar_autor.Location = new Point(1233, 27);
            btn_buscar_autor.Name = "btn_buscar_autor";
            btn_buscar_autor.Size = new Size(66, 43);
            btn_buscar_autor.TabIndex = 71;
            btn_buscar_autor.UseVisualStyleBackColor = false;
            // 
            // text_buscar_autor
            // 
            text_buscar_autor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_autor.Location = new Point(871, 32);
            text_buscar_autor.Name = "text_buscar_autor";
            text_buscar_autor.Size = new Size(329, 31);
            text_buscar_autor.TabIndex = 70;
            // 
            // l_buscar_autor
            // 
            l_buscar_autor.AutoSize = true;
            l_buscar_autor.BackColor = Color.White;
            l_buscar_autor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_buscar_autor.Location = new Point(784, 35);
            l_buscar_autor.Name = "l_buscar_autor";
            l_buscar_autor.Size = new Size(63, 25);
            l_buscar_autor.TabIndex = 69;
            l_buscar_autor.Text = "Buscar";
            // 
            // AdministradorViewAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 464);
            Controls.Add(btn_buscar_autor);
            Controls.Add(text_buscar_autor);
            Controls.Add(l_buscar_autor);
            Controls.Add(l_lista_autores);
            Controls.Add(dataGridView1);
            Controls.Add(l_detalle_producto);
            Controls.Add(btn_eliminar_autor);
            Controls.Add(btn_modificar_autor);
            Controls.Add(btn_registrar_autor);
            Controls.Add(cmb_estado_producto);
            Controls.Add(text_nombre_autor_admin);
            Controls.Add(l_estado_producto);
            Controls.Add(l_nombre_autor);
            Controls.Add(label1);
            Name = "AdministradorViewAutores";
            Text = "AdministradorViewAutores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_detalle_producto;
        private Button btn_eliminar_autor;
        private Button btn_modificar_autor;
        private Button btn_registrar_autor;
        private ComboBox cmb_estado_producto;
        private TextBox text_nombre_autor_admin;
        private Label l_estado_producto;
        private Label l_nombre_autor;
        private Label label1;
        private Button btn_buscar_producto;
        private TextBox text_buscar_producto;
        private ComboBox cmb_buscar_por_producto;
        private Label l_buscar_producto;
        private Label l_lista_autores;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn estado;
        private Button btn_buscar_autor;
        private TextBox text_buscar_autor;
        private Label l_buscar_autor;
    }
}