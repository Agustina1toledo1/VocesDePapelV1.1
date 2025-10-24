namespace VocesDePapelV1._1.Views
{
    partial class AdministradorViewCategorias
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
            l_detalle_categoria = new Label();
            btn_eliminar_categoria = new Button();
            btn_modificar_categoria = new Button();
            btn_guardar_categoria = new Button();
            cmb_estado_categoria = new ComboBox();
            text_nombre_categoria_admin = new TextBox();
            l_estado_categoria = new Label();
            l_nombre_categoria = new Label();
            label1 = new Label();
            btn_buscar_categoria = new Button();
            text_buscar_categoria = new TextBox();
            l_buscar_categoria = new Label();
            l_lista_categorias = new Label();
            datgridCategorias = new DataGridView();
            btn_limpiar_categoria = new Button();
            ((System.ComponentModel.ISupportInitialize)datgridCategorias).BeginInit();
            SuspendLayout();
            // 
            // l_detalle_categoria
            // 
            l_detalle_categoria.AutoSize = true;
            l_detalle_categoria.BackColor = Color.White;
            l_detalle_categoria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_detalle_categoria.Location = new Point(62, 40);
            l_detalle_categoria.Name = "l_detalle_categoria";
            l_detalle_categoria.Size = new Size(256, 31);
            l_detalle_categoria.TabIndex = 63;
            l_detalle_categoria.Text = "Detalle de la Categoria";
            // 
            // btn_eliminar_categoria
            // 
            btn_eliminar_categoria.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar_categoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar_categoria.Location = new Point(61, 427);
            btn_eliminar_categoria.Name = "btn_eliminar_categoria";
            btn_eliminar_categoria.Size = new Size(269, 43);
            btn_eliminar_categoria.TabIndex = 62;
            btn_eliminar_categoria.Text = "Eliminar";
            btn_eliminar_categoria.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_categoria
            // 
            btn_modificar_categoria.BackColor = SystemColors.GradientActiveCaption;
            btn_modificar_categoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_categoria.Location = new Point(61, 310);
            btn_modificar_categoria.Name = "btn_modificar_categoria";
            btn_modificar_categoria.Size = new Size(269, 43);
            btn_modificar_categoria.TabIndex = 61;
            btn_modificar_categoria.Text = "Modificar";
            btn_modificar_categoria.UseVisualStyleBackColor = false;
            // 
            // btn_guardar_categoria
            // 
            btn_guardar_categoria.BackColor = Color.LightGreen;
            btn_guardar_categoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar_categoria.Location = new Point(62, 250);
            btn_guardar_categoria.Name = "btn_guardar_categoria";
            btn_guardar_categoria.Size = new Size(269, 43);
            btn_guardar_categoria.TabIndex = 60;
            btn_guardar_categoria.Text = "Guardar";
            btn_guardar_categoria.UseVisualStyleBackColor = false;
            // 
            // cmb_estado_categoria
            // 
            cmb_estado_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_estado_categoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_estado_categoria.FormattingEnabled = true;
            cmb_estado_categoria.Location = new Point(61, 193);
            cmb_estado_categoria.Name = "cmb_estado_categoria";
            cmb_estado_categoria.Size = new Size(269, 36);
            cmb_estado_categoria.TabIndex = 59;
            // 
            // text_nombre_categoria_admin
            // 
            text_nombre_categoria_admin.Font = new Font("Segoe UI", 12F);
            text_nombre_categoria_admin.Location = new Point(61, 124);
            text_nombre_categoria_admin.Name = "text_nombre_categoria_admin";
            text_nombre_categoria_admin.Size = new Size(269, 34);
            text_nombre_categoria_admin.TabIndex = 58;
            // 
            // l_estado_categoria
            // 
            l_estado_categoria.AutoSize = true;
            l_estado_categoria.BackColor = Color.White;
            l_estado_categoria.Font = new Font("Segoe UI", 12F);
            l_estado_categoria.Location = new Point(64, 161);
            l_estado_categoria.Name = "l_estado_categoria";
            l_estado_categoria.Size = new Size(71, 28);
            l_estado_categoria.TabIndex = 57;
            l_estado_categoria.Text = "Estado";
            // 
            // l_nombre_categoria
            // 
            l_nombre_categoria.AutoSize = true;
            l_nombre_categoria.BackColor = Color.White;
            l_nombre_categoria.Font = new Font("Segoe UI", 12F);
            l_nombre_categoria.Location = new Point(65, 93);
            l_nombre_categoria.Name = "l_nombre_categoria";
            l_nombre_categoria.Size = new Size(85, 28);
            l_nombre_categoria.TabIndex = 56;
            l_nombre_categoria.Text = "Nombre";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(399, 483);
            label1.TabIndex = 55;
            // 
            // btn_buscar_categoria
            // 
            btn_buscar_categoria.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_categoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_categoria.Image = Properties.Resources.lupa;
            btn_buscar_categoria.Location = new Point(1240, 35);
            btn_buscar_categoria.Name = "btn_buscar_categoria";
            btn_buscar_categoria.Size = new Size(66, 43);
            btn_buscar_categoria.TabIndex = 68;
            btn_buscar_categoria.UseVisualStyleBackColor = false;
            // 
            // text_buscar_categoria
            // 
            text_buscar_categoria.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_categoria.Location = new Point(887, 40);
            text_buscar_categoria.Name = "text_buscar_categoria";
            text_buscar_categoria.Size = new Size(329, 31);
            text_buscar_categoria.TabIndex = 67;
            // 
            // l_buscar_categoria
            // 
            l_buscar_categoria.AutoSize = true;
            l_buscar_categoria.BackColor = Color.White;
            l_buscar_categoria.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_buscar_categoria.Location = new Point(800, 43);
            l_buscar_categoria.Name = "l_buscar_categoria";
            l_buscar_categoria.Size = new Size(63, 25);
            l_buscar_categoria.TabIndex = 66;
            l_buscar_categoria.Text = "Buscar";
            // 
            // l_lista_categorias
            // 
            l_lista_categorias.BackColor = Color.White;
            l_lista_categorias.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_categorias.Location = new Point(414, 20);
            l_lista_categorias.Name = "l_lista_categorias";
            l_lista_categorias.Size = new Size(903, 66);
            l_lista_categorias.TabIndex = 65;
            l_lista_categorias.Text = "Lista de categorias";
            l_lista_categorias.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // datgridCategorias
            // 
            datgridCategorias.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datgridCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datgridCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datgridCategorias.Location = new Point(414, 116);
            datgridCategorias.MultiSelect = false;
            datgridCategorias.Name = "datgridCategorias";
            datgridCategorias.ReadOnly = true;
            datgridCategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            datgridCategorias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            datgridCategorias.Size = new Size(903, 304);
            datgridCategorias.TabIndex = 64;
            // 
            // btn_limpiar_categoria
            // 
            btn_limpiar_categoria.BackColor = Color.FromArgb(255, 192, 128);
            btn_limpiar_categoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar_categoria.Location = new Point(60, 370);
            btn_limpiar_categoria.Name = "btn_limpiar_categoria";
            btn_limpiar_categoria.Size = new Size(269, 43);
            btn_limpiar_categoria.TabIndex = 73;
            btn_limpiar_categoria.Text = "Limpiar";
            btn_limpiar_categoria.UseVisualStyleBackColor = false;
            // 
            // AdministradorViewCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 483);
            Controls.Add(btn_limpiar_categoria);
            Controls.Add(btn_buscar_categoria);
            Controls.Add(text_buscar_categoria);
            Controls.Add(l_buscar_categoria);
            Controls.Add(l_lista_categorias);
            Controls.Add(datgridCategorias);
            Controls.Add(l_detalle_categoria);
            Controls.Add(btn_eliminar_categoria);
            Controls.Add(btn_modificar_categoria);
            Controls.Add(btn_guardar_categoria);
            Controls.Add(cmb_estado_categoria);
            Controls.Add(text_nombre_categoria_admin);
            Controls.Add(l_estado_categoria);
            Controls.Add(l_nombre_categoria);
            Controls.Add(label1);
            Name = "AdministradorViewCategorias";
            Text = "AdministradorViewCategorias";
            ((System.ComponentModel.ISupportInitialize)datgridCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_detalle_categoria;
        private Button btn_eliminar_categoria;
        private Button btn_modificar_categoria;
        private Button btn_guardar_categoria;
        private ComboBox cmb_estado_categoria;
        private TextBox text_nombre_categoria_admin;
        private Label l_estado_categoria;
        private Label l_nombre_categoria;
        private Label label1;
        private Button btn_buscar_categoria;
        private TextBox text_buscar_categoria;
        private Label l_buscar_categoria;
        private Label l_lista_categorias;
        private DataGridView datgridCategorias;
        private Button btn_limpiar_categoria;
    }
}