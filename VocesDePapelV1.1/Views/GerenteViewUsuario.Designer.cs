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
            l_lista_usuarios = new Label();
            btn_seleccionar = new DataGridViewButtonColumn();
            id_usuario = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            cuit = new DataGridViewTextBoxColumn();
            id_rol = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            estado_valor = new DataGridViewTextBoxColumn();
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
            l_clave.Size = new Size(110, 28);
            l_clave.TabIndex = 3;
            l_clave.Text = "Contraseña";
            // 
            // l_verificar_clave
            // 
            l_verificar_clave.AutoSize = true;
            l_verificar_clave.BackColor = Color.White;
            l_verificar_clave.Font = new Font("Segoe UI", 12F);
            l_verificar_clave.Location = new Point(60, 298);
            l_verificar_clave.Name = "l_verificar_clave";
            l_verificar_clave.Size = new Size(182, 28);
            l_verificar_clave.TabIndex = 4;
            l_verificar_clave.Text = "Verificar contraseña";
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, id_usuario, nombre, apellido, Contraseña, cuit, id_rol, rol, Estado, estado_valor });
            dataGridView1.Location = new Point(420, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(903, 564);
            dataGridView1.TabIndex = 19;
            // 
            // l_lista_usuarios
            // 
            l_lista_usuarios.BackColor = Color.White;
            l_lista_usuarios.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_usuarios.Location = new Point(420, 31);
            l_lista_usuarios.Name = "l_lista_usuarios";
            l_lista_usuarios.Size = new Size(903, 44);
            l_lista_usuarios.TabIndex = 20;
            l_lista_usuarios.Text = "Lista de usuarios";
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.MinimumWidth = 6;
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.Width = 30;
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "id_usuario";
            id_usuario.MinimumWidth = 6;
            id_usuario.Name = "id_usuario";
            id_usuario.Visible = false;
            id_usuario.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 150;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.Width = 150;
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.MinimumWidth = 6;
            Contraseña.Name = "Contraseña";
            Contraseña.Visible = false;
            Contraseña.Width = 125;
            // 
            // cuit
            // 
            cuit.HeaderText = "CUIT";
            cuit.MinimumWidth = 6;
            cuit.Name = "cuit";
            cuit.Width = 125;
            // 
            // id_rol
            // 
            id_rol.HeaderText = "id_rol";
            id_rol.MinimumWidth = 6;
            id_rol.Name = "id_rol";
            id_rol.Visible = false;
            id_rol.Width = 125;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // estado_valor
            // 
            estado_valor.HeaderText = "Estado valor";
            estado_valor.MinimumWidth = 6;
            estado_valor.Name = "estado_valor";
            estado_valor.Visible = false;
            estado_valor.Width = 125;
            // 
            // GerenteViewUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
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
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn cuit;
        private DataGridViewTextBoxColumn id_rol;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn estado_valor;
    }
}