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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            l_nombre = new Label();
            l_apellido = new Label();
            l_clave = new Label();
            l_verificar_clave = new Label();
            l_cuit = new Label();
            l_estado = new Label();
            l_rol = new Label();
            text_nombre_usuario = new TextBox();
            text_cuit_usuario = new TextBox();
            text_clave_verificar_usuario = new TextBox();
            text_clave_usuario = new TextBox();
            text_apellido_usuario = new TextBox();
            cmb_estado_usuario = new ComboBox();
            cmb_rol_usuario = new ComboBox();
            btn_guardar_usuario = new Button();
            btn_modificar_usuario = new Button();
            btn_eliminar_usuario = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btn_seleccionar = new DataGridViewButtonColumn();
            id_usuario = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            cuit = new DataGridViewTextBoxColumn();
            id_rol = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            estado_valor = new DataGridViewTextBoxColumn();
            l_lista_usuarios = new Label();
            l_buscar_usuario = new Label();
            cmb_buscar_por = new ComboBox();
            text_buscar_usuario = new TextBox();
            btn_buscar_usuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(399, 781);
            label1.TabIndex = 0;
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
            l_verificar_clave.AutoSize = true;
            l_verificar_clave.BackColor = Color.White;
            l_verificar_clave.Font = new Font("Segoe UI", 12F);
            l_verificar_clave.Location = new Point(60, 298);
            l_verificar_clave.Name = "l_verificar_clave";
            l_verificar_clave.Size = new Size(131, 28);
            l_verificar_clave.TabIndex = 4;
            l_verificar_clave.Text = "Verificar clave";
            // 
            // l_cuit
            // 
            l_cuit.AutoSize = true;
            l_cuit.BackColor = Color.White;
            l_cuit.Font = new Font("Segoe UI", 12F);
            l_cuit.Location = new Point(59, 367);
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
            l_estado.Location = new Point(62, 439);
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
            l_rol.Location = new Point(61, 513);
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
            text_cuit_usuario.Location = new Point(59, 395);
            text_cuit_usuario.Name = "text_cuit_usuario";
            text_cuit_usuario.Size = new Size(269, 34);
            text_cuit_usuario.TabIndex = 9;
            // 
            // text_clave_verificar_usuario
            // 
            text_clave_verificar_usuario.Font = new Font("Segoe UI", 12F);
            text_clave_verificar_usuario.Location = new Point(59, 330);
            text_clave_verificar_usuario.Name = "text_clave_verificar_usuario";
            text_clave_verificar_usuario.Size = new Size(269, 34);
            text_clave_verificar_usuario.TabIndex = 10;
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
            cmb_estado_usuario.Location = new Point(59, 471);
            cmb_estado_usuario.Name = "cmb_estado_usuario";
            cmb_estado_usuario.Size = new Size(269, 36);
            cmb_estado_usuario.TabIndex = 13;
            // 
            // cmb_rol_usuario
            // 
            cmb_rol_usuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_rol_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_rol_usuario.FormattingEnabled = true;
            cmb_rol_usuario.Location = new Point(59, 547);
            cmb_rol_usuario.Name = "cmb_rol_usuario";
            cmb_rol_usuario.Size = new Size(269, 36);
            cmb_rol_usuario.TabIndex = 14;
            // 
            // btn_guardar_usuario
            // 
            btn_guardar_usuario.BackColor = SystemColors.GradientActiveCaption;
            btn_guardar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar_usuario.Location = new Point(59, 611);
            btn_guardar_usuario.Name = "btn_guardar_usuario";
            btn_guardar_usuario.Size = new Size(269, 43);
            btn_guardar_usuario.TabIndex = 15;
            btn_guardar_usuario.Text = "Guardar";
            btn_guardar_usuario.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_usuario
            // 
            btn_modificar_usuario.BackColor = Color.FromArgb(255, 192, 128);
            btn_modificar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_usuario.Location = new Point(59, 672);
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
            btn_eliminar_usuario.Location = new Point(59, 732);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, id_usuario, nombre, apellido, cuit, id_rol, rol, Estado, estado_valor });
            dataGridView1.Location = new Point(420, 124);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(903, 564);
            dataGridView1.TabIndex = 19;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.MinimumWidth = 6;
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Width = 30;
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "id_usuario";
            id_usuario.MinimumWidth = 6;
            id_usuario.Name = "id_usuario";
            id_usuario.ReadOnly = true;
            id_usuario.Visible = false;
            id_usuario.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 150;
            // 
            // cuit
            // 
            cuit.HeaderText = "CUIT";
            cuit.MinimumWidth = 6;
            cuit.Name = "cuit";
            cuit.ReadOnly = true;
            cuit.Width = 125;
            // 
            // id_rol
            // 
            id_rol.HeaderText = "id_rol";
            id_rol.MinimumWidth = 6;
            id_rol.Name = "id_rol";
            id_rol.ReadOnly = true;
            id_rol.Visible = false;
            id_rol.Width = 125;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.ReadOnly = true;
            rol.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // estado_valor
            // 
            estado_valor.HeaderText = "Estado valor";
            estado_valor.MinimumWidth = 6;
            estado_valor.Name = "estado_valor";
            estado_valor.ReadOnly = true;
            estado_valor.Visible = false;
            estado_valor.Width = 125;
            // 
            // l_lista_usuarios
            // 
            l_lista_usuarios.BackColor = Color.White;
            l_lista_usuarios.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_usuarios.Location = new Point(420, 28);
            l_lista_usuarios.Name = "l_lista_usuarios";
            l_lista_usuarios.Size = new Size(903, 66);
            l_lista_usuarios.TabIndex = 20;
            l_lista_usuarios.Text = "Lista de usuarios";
            l_lista_usuarios.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l_buscar_usuario
            // 
            l_buscar_usuario.AutoSize = true;
            l_buscar_usuario.BackColor = Color.White;
            l_buscar_usuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_buscar_usuario.Location = new Point(710, 51);
            l_buscar_usuario.Name = "l_buscar_usuario";
            l_buscar_usuario.Size = new Size(96, 25);
            l_buscar_usuario.TabIndex = 21;
            l_buscar_usuario.Text = "Buscar por";
            // 
            // cmb_buscar_por
            // 
            cmb_buscar_por.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_buscar_por.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_buscar_por.FormattingEnabled = true;
            cmb_buscar_por.Location = new Point(820, 45);
            cmb_buscar_por.Name = "cmb_buscar_por";
            cmb_buscar_por.Size = new Size(158, 33);
            cmb_buscar_por.TabIndex = 22;
            // 
            // text_buscar_usuario
            // 
            text_buscar_usuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_usuario.Location = new Point(984, 47);
            text_buscar_usuario.Name = "text_buscar_usuario";
            text_buscar_usuario.Size = new Size(269, 31);
            text_buscar_usuario.TabIndex = 23;
            // 
            // btn_buscar_usuario
            // 
            btn_buscar_usuario.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_usuario.Image = Properties.Resources.lupa;
            btn_buscar_usuario.Location = new Point(1255, 43);
            btn_buscar_usuario.Name = "btn_buscar_usuario";
            btn_buscar_usuario.Size = new Size(66, 43);
            btn_buscar_usuario.TabIndex = 24;
            btn_buscar_usuario.UseVisualStyleBackColor = false;
            // 
            // GerenteViewUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
            Controls.Add(btn_buscar_usuario);
            Controls.Add(text_buscar_usuario);
            Controls.Add(cmb_buscar_por);
            Controls.Add(l_buscar_usuario);
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
            Controls.Add(text_clave_verificar_usuario);
            Controls.Add(text_cuit_usuario);
            Controls.Add(text_nombre_usuario);
            Controls.Add(l_rol);
            Controls.Add(l_estado);
            Controls.Add(l_cuit);
            Controls.Add(l_verificar_clave);
            Controls.Add(l_clave);
            Controls.Add(l_apellido);
            Controls.Add(l_nombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "GerenteViewUsuario";
            Text = "GerenteViewUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label l_nombre;
        private Label l_apellido;
        private Label l_clave;
        private Label l_verificar_clave;
        private Label l_cuit;
        private Label l_estado;
        private Label l_rol;
        private TextBox text_nombre_usuario;
        private TextBox text_cuit_usuario;
        private TextBox text_clave_verificar_usuario;
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
        private Label l_buscar_usuario;
        private ComboBox cmb_buscar_por;
        private TextBox text_buscar_usuario;
        private Button btn_buscar_usuario;
    }
}