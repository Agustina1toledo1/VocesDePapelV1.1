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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            l_detalle_producto = new Label();
            btn_eliminar_autor = new Button();
            btn_modificar_autor = new Button();
            btn_guardar_autor = new Button();
            cmb_estado_autor = new ComboBox();
            text_nombre_autor_admin = new TextBox();
            l_estado_producto = new Label();
            l_nombre_autor = new Label();
            label1 = new Label();
            l_lista_autores = new Label();
            dataGridAutorAdmin = new DataGridView();
            btn_buscar_autor = new Button();
            text_buscar_autor = new TextBox();
            l_buscar_autor = new Label();
            btn_limpiar_autor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAutorAdmin).BeginInit();
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
            btn_eliminar_autor.Location = new Point(69, 415);
            btn_eliminar_autor.Name = "btn_eliminar_autor";
            btn_eliminar_autor.Size = new Size(269, 43);
            btn_eliminar_autor.TabIndex = 53;
            btn_eliminar_autor.Text = "Eliminar";
            btn_eliminar_autor.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_autor
            // 
            btn_modificar_autor.BackColor = SystemColors.GradientActiveCaption;
            btn_modificar_autor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_autor.Location = new Point(69, 305);
            btn_modificar_autor.Name = "btn_modificar_autor";
            btn_modificar_autor.Size = new Size(269, 43);
            btn_modificar_autor.TabIndex = 52;
            btn_modificar_autor.Text = "Modificar";
            btn_modificar_autor.UseVisualStyleBackColor = false;
            // 
            // btn_guardar_autor
            // 
            btn_guardar_autor.BackColor = Color.LightGreen;
            btn_guardar_autor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar_autor.Location = new Point(70, 245);
            btn_guardar_autor.Name = "btn_guardar_autor";
            btn_guardar_autor.Size = new Size(269, 43);
            btn_guardar_autor.TabIndex = 51;
            btn_guardar_autor.Text = "Guardar";
            btn_guardar_autor.UseVisualStyleBackColor = false;
            // 
            // cmb_estado_autor
            // 
            cmb_estado_autor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_estado_autor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_estado_autor.FormattingEnabled = true;
            cmb_estado_autor.Location = new Point(69, 188);
            cmb_estado_autor.Name = "cmb_estado_autor";
            cmb_estado_autor.Size = new Size(269, 36);
            cmb_estado_autor.TabIndex = 49;
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
            // dataGridAutorAdmin
            // 
            dataGridAutorAdmin.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridAutorAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridAutorAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAutorAdmin.Location = new Point(416, 106);
            dataGridAutorAdmin.MultiSelect = false;
            dataGridAutorAdmin.Name = "dataGridAutorAdmin";
            dataGridAutorAdmin.ReadOnly = true;
            dataGridAutorAdmin.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridAutorAdmin.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridAutorAdmin.Size = new Size(903, 304);
            dataGridAutorAdmin.TabIndex = 55;
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
            // btn_limpiar_autor
            // 
            btn_limpiar_autor.BackColor = Color.FromArgb(255, 192, 128);
            btn_limpiar_autor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar_autor.Location = new Point(69, 361);
            btn_limpiar_autor.Name = "btn_limpiar_autor";
            btn_limpiar_autor.Size = new Size(269, 43);
            btn_limpiar_autor.TabIndex = 72;
            btn_limpiar_autor.Text = "Limpiar";
            btn_limpiar_autor.UseVisualStyleBackColor = false;
            // 
            // AdministradorViewAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 464);
            Controls.Add(btn_limpiar_autor);
            Controls.Add(btn_buscar_autor);
            Controls.Add(text_buscar_autor);
            Controls.Add(l_buscar_autor);
            Controls.Add(l_lista_autores);
            Controls.Add(dataGridAutorAdmin);
            Controls.Add(l_detalle_producto);
            Controls.Add(btn_eliminar_autor);
            Controls.Add(btn_modificar_autor);
            Controls.Add(btn_guardar_autor);
            Controls.Add(cmb_estado_autor);
            Controls.Add(text_nombre_autor_admin);
            Controls.Add(l_estado_producto);
            Controls.Add(l_nombre_autor);
            Controls.Add(label1);
            Name = "AdministradorViewAutores";
            Text = "AdministradorViewAutores";
            ((System.ComponentModel.ISupportInitialize)dataGridAutorAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_detalle_producto;
        private Button btn_eliminar_autor;
        private Button btn_modificar_autor;
        private Button btn_guardar_autor;
        private ComboBox cmb_estado_autor;
        private TextBox text_nombre_autor_admin;
        private Label l_estado_producto;
        private Label l_nombre_autor;
        private Label label1;
        private Button btn_buscar_producto;
        private TextBox text_buscar_producto;
        private ComboBox cmb_buscar_por_producto;
        private Label l_buscar_producto;
        private Label l_lista_autores;
        private DataGridView dataGridAutorAdmin;
        private Button btn_buscar_autor;
        private TextBox text_buscar_autor;
        private Label l_buscar_autor;
        private Button btn_limpiar_autor;
    }
}