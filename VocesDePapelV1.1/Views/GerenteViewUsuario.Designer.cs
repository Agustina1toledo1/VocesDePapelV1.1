namespace VocesDePapelV1._1.Views
{
    partial class GerenteViewUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            l_nombre = new Label();
            l_apellido = new Label();
            l_clave = new Label();
            l_verificar_clave = new Label();
            l_cuit = new Label();
            l_estado = new Label();
            l_rol = new Label();
            text_nombre_usuario = new TextBox();
            text_cuit_usuario = new TextBox();
            text_clave_usuario = new TextBox();
            text_apellido_usuario = new TextBox();
            cmb_estado_usuario = new ComboBox();
            cmb_rol_usuario = new ComboBox();
            btn_guardar_usuario = new Button();
            btn_modificar_usuario = new Button();
            btn_eliminar_usuario = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            l_lista_usuarios = new Label();
            text_buscar_usuario = new TextBox();
            btn_buscar_usuario = new Button();
            btn_limpiar_usuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // l_nombre
            // 
            l_nombre.AutoSize = true;
            l_nombre.BackColor = Color.White;
            l_nombre.Font = new Font("Segoe UI", 12F);
            l_nombre.Location = new Point(63, 78);
            l_nombre.Name = "l_nombre";
            l_nombre.Size = new Size(85, 28);
            l_nombre.TabIndex = 1;
            l_nombre.Text = "Nombre";
            // 
            // l_apellido
            // 
            l_apellido.AutoSize = true;
            l_apellido.BackColor = Color.White;
            l_apellido.Font = new Font("Segoe UI", 12F);
            l_apellido.Location = new Point(63, 149);
            l_apellido.Name = "l_apellido";
            l_apellido.Size = new Size(86, 28);
            l_apellido.TabIndex = 2;
            l_apellido.Text = "Apellido";
            // 
            // l_clave
            // 
            l_clave.AutoSize = true;
            l_clave.BackColor = Color.White;
            l_clave.Font = new Font("Segoe UI", 12F);
            l_clave.Location = new Point(62, 224);
            l_clave.Name = "l_clave";
            l_clave.Size = new Size(59, 28);
            l_clave.TabIndex = 3;
            l_clave.Text = "Clave";
            // 
            // l_verificar_clave
            // 
            l_verificar_clave.Location = new Point(0, 0);
            l_verificar_clave.Name = "l_verificar_clave";
            l_verificar_clave.Size = new Size(100, 23);
            l_verificar_clave.TabIndex = 26;
            // 
            // l_cuit
            // 
            l_cuit.AutoSize = true;
            l_cuit.BackColor = Color.White;
            l_cuit.Font = new Font("Segoe UI", 12F);
            l_cuit.Location = new Point(59, 302);
            l_cuit.Name = "l_cuit";
            l_cuit.Size = new Size(53, 28);
            l_cuit.TabIndex = 5;
            l_cuit.Text = "CUIT";
            // 
            // l_estado
            // 
            l_estado.AutoSize = true;
            l_estado.BackColor = Color.White;
            l_estado.Font = new Font("Segoe UI", 12F);
            l_estado.Location = new Point(62, 374);
            l_estado.Name = "l_estado";
            l_estado.Size = new Size(71, 28);
            l_estado.TabIndex = 6;
            l_estado.Text = "Estado";
            // 
            // l_rol
            // 
            l_rol.AutoSize = true;
            l_rol.BackColor = Color.White;
            l_rol.Font = new Font("Segoe UI", 12F);
            l_rol.Location = new Point(61, 448);
            l_rol.Name = "l_rol";
            l_rol.Size = new Size(40, 28);
            l_rol.TabIndex = 7;
            l_rol.Text = "Rol";
            // 
            // text_nombre_usuario
            // 
            text_nombre_usuario.Font = new Font("Segoe UI", 12F);
            text_nombre_usuario.Location = new Point(59, 109);
            text_nombre_usuario.Name = "text_nombre_usuario";
            text_nombre_usuario.Size = new Size(269, 34);
            text_nombre_usuario.TabIndex = 8;
            // 
            // text_cuit_usuario
            // 
            text_cuit_usuario.Font = new Font("Segoe UI", 12F);
            text_cuit_usuario.Location = new Point(59, 330);
            text_cuit_usuario.Name = "text_cuit_usuario";
            text_cuit_usuario.Size = new Size(269, 34);
            text_cuit_usuario.TabIndex = 9;
            // 
            // text_clave_usuario
            // 
            text_clave_usuario.Font = new Font("Segoe UI", 12F);
            text_clave_usuario.Location = new Point(59, 254);
            text_clave_usuario.Name = "text_clave_usuario";
            text_clave_usuario.Size = new Size(269, 34);
            text_clave_usuario.TabIndex = 11;
            // 
            // text_apellido_usuario
            // 
            text_apellido_usuario.Font = new Font("Segoe UI", 12F);
            text_apellido_usuario.Location = new Point(59, 182);
            text_apellido_usuario.Name = "text_apellido_usuario";
            text_apellido_usuario.Size = new Size(269, 34);
            text_apellido_usuario.TabIndex = 12;
            // 
            // cmb_estado_usuario
            // 
            cmb_estado_usuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_estado_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_estado_usuario.FormattingEnabled = true;
            cmb_estado_usuario.Items.AddRange(new object[] { "1" });
            cmb_estado_usuario.Location = new Point(59, 405);
            cmb_estado_usuario.Name = "cmb_estado_usuario";
            cmb_estado_usuario.Size = new Size(269, 36);
            cmb_estado_usuario.TabIndex = 13;
            // 
            // cmb_rol_usuario
            // 
            cmb_rol_usuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_rol_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_rol_usuario.FormattingEnabled = true;
            cmb_rol_usuario.Location = new Point(59, 482);
            cmb_rol_usuario.Name = "cmb_rol_usuario";
            cmb_rol_usuario.Size = new Size(269, 36);
            cmb_rol_usuario.TabIndex = 14;
            // 
            // btn_guardar_usuario
            // 
            btn_guardar_usuario.BackColor = Color.LightGreen;
            btn_guardar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar_usuario.Location = new Point(59, 551);
            btn_guardar_usuario.Name = "btn_guardar_usuario";
            btn_guardar_usuario.Size = new Size(269, 43);
            btn_guardar_usuario.TabIndex = 15;
            btn_guardar_usuario.Text = "Guardar";
            btn_guardar_usuario.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_usuario
            // 
            btn_modificar_usuario.BackColor = SystemColors.GradientActiveCaption;
            btn_modificar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_usuario.Location = new Point(59, 608);
            btn_modificar_usuario.Name = "btn_modificar_usuario";
            btn_modificar_usuario.Size = new Size(269, 43);
            btn_modificar_usuario.TabIndex = 16;
            btn_modificar_usuario.Text = "Modificar";
            btn_modificar_usuario.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar_usuario
            // 
            btn_eliminar_usuario.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar_usuario.Location = new Point(59, 714);
            btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            btn_eliminar_usuario.Size = new Size(269, 43);
            btn_eliminar_usuario.TabIndex = 17;
            btn_eliminar_usuario.Text = "Eliminar";
            btn_eliminar_usuario.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 28);
            label2.Name = "label2";
            label2.Size = new Size(218, 31);
            label2.TabIndex = 18;
            label2.Text = "Detalle del Usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 124);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 558);
            dataGridView1.TabIndex = 19;
            // 
            // l_lista_usuarios
            // 
            l_lista_usuarios.BackColor = Color.White;
            l_lista_usuarios.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_usuarios.Location = new Point(420, 28);
            l_lista_usuarios.Name = "l_lista_usuarios";
            l_lista_usuarios.Size = new Size(927, 66);
            l_lista_usuarios.TabIndex = 20;
            l_lista_usuarios.Text = "Lista de usuarios";
            l_lista_usuarios.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // text_buscar_usuario
            // 
            text_buscar_usuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_usuario.Location = new Point(670, 45);
            text_buscar_usuario.Name = "text_buscar_usuario";
            text_buscar_usuario.Size = new Size(581, 31);
            text_buscar_usuario.TabIndex = 23;
            // 
            // btn_buscar_usuario
            // 
            btn_buscar_usuario.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_usuario.Image = Properties.Resources.lupa;
            btn_buscar_usuario.Location = new Point(1277, 38);
            btn_buscar_usuario.Name = "btn_buscar_usuario";
            btn_buscar_usuario.Size = new Size(55, 43);
            btn_buscar_usuario.TabIndex = 24;
            btn_buscar_usuario.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar_usuario
            // 
            btn_limpiar_usuario.BackColor = Color.FromArgb(255, 192, 128);
            btn_limpiar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar_usuario.Location = new Point(62, 662);
            btn_limpiar_usuario.Name = "btn_limpiar_usuario";
            btn_limpiar_usuario.Size = new Size(269, 43);
            btn_limpiar_usuario.TabIndex = 45;
            btn_limpiar_usuario.Text = "Limpiar";
            btn_limpiar_usuario.UseVisualStyleBackColor = false;
            // 
            // GerenteViewUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1367, 781);
            Controls.Add(btn_limpiar_usuario);
            Controls.Add(btn_buscar_usuario);
            Controls.Add(text_buscar_usuario);
            Controls.Add(l_lista_usuarios);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(btn_eliminar_usuario);
            Controls.Add(btn_modificar_usuario);
            Controls.Add(btn_guardar_usuario);
            Controls.Add(cmb_rol_usuario);
            Controls.Add(cmb_estado_usuario);
            Controls.Add(text_apellido_usuario);
            Controls.Add(text_clave_usuario);
            Controls.Add(text_cuit_usuario);
            Controls.Add(text_nombre_usuario);
            Controls.Add(l_rol);
            Controls.Add(l_estado);
            Controls.Add(l_cuit);
            Controls.Add(l_verificar_clave);
            Controls.Add(l_clave);
            Controls.Add(l_apellido);
            Controls.Add(l_nombre);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "GerenteViewUsuario";
            Text = "GerenteViewUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label l_nombre;
        private Label l_apellido;
        private Label l_clave;
        private Label l_verificar_clave;
        private Label l_cuit;
        private Label l_estado;
        private Label l_rol;
        private TextBox text_nombre_usuario;
        private TextBox text_cuit_usuario;
        private TextBox text_clave_usuario;
        private TextBox text_apellido_usuario;
        private ComboBox cmb_estado_usuario;
        private ComboBox cmb_rol_usuario;
        private Button btn_guardar_usuario;
        private Button btn_modificar_usuario;
        private Button btn_eliminar_usuario;
        private Label label2;
        private DataGridView dataGridView1;
        private Label l_lista_usuarios;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn id_rol;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn estado_valor;
        private ComboBox cmb_buscar_por;
        private TextBox text_buscar_usuario;
        private Button btn_buscar_usuario;
        private Button btn_limpiar_usuario;
    }
}