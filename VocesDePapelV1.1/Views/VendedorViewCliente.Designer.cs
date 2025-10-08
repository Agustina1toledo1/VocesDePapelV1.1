namespace VocesDePapelV1._1.Views
{
    partial class VendedorViewCliente
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
            LDetalleCliente = new Label();
            label2 = new Label();
            l_nombre_razonSocial = new Label();
            LTelefonoCliente = new Label();
            LEmail = new Label();
            LCuit_cuil = new Label();
            TBCliente = new TextBox();
            TBCuitCuil = new TextBox();
            TBEmailCliente = new TextBox();
            TBTelefonoCliente = new TextBox();
            btn_guardar_cliente = new Button();
            btn_limpiar_cliente = new Button();
            btn_eliminar_cliente = new Button();
            l_lista_cliente = new Label();
            text_buscar_cliente = new TextBox();
            btn_buscar_cliente = new Button();
            DGVListCliente = new DataGridView();
            btn_seleccionar = new DataGridViewButtonColumn();
            id_cliente = new DataGridViewTextBoxColumn();
            nombre_razonSocial = new DataGridViewTextBoxColumn();
            CUIT_CUIL = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btn_ir_venta_cliente = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVListCliente).BeginInit();
            SuspendLayout();
            // 
            // LDetalleCliente
            // 
            LDetalleCliente.BackColor = Color.White;
            LDetalleCliente.BorderStyle = BorderStyle.FixedSingle;
            LDetalleCliente.Dock = DockStyle.Left;
            LDetalleCliente.Location = new Point(0, 0);
            LDetalleCliente.Name = "LDetalleCliente";
            LDetalleCliente.Size = new Size(399, 781);
            LDetalleCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 26);
            label2.Name = "label2";
            label2.Size = new Size(210, 31);
            label2.TabIndex = 19;
            label2.Text = "Detalle del Cliente";
            // 
            // l_nombre_razonSocial
            // 
            l_nombre_razonSocial.AutoSize = true;
            l_nombre_razonSocial.BackColor = Color.White;
            l_nombre_razonSocial.Font = new Font("Segoe UI", 12F);
            l_nombre_razonSocial.Location = new Point(36, 85);
            l_nombre_razonSocial.Name = "l_nombre_razonSocial";
            l_nombre_razonSocial.Size = new Size(199, 28);
            l_nombre_razonSocial.TabIndex = 20;
            l_nombre_razonSocial.Text = "Nombre/RazonSocial";
            // 
            // LTelefonoCliente
            // 
            LTelefonoCliente.AutoSize = true;
            LTelefonoCliente.BackColor = Color.White;
            LTelefonoCliente.Font = new Font("Segoe UI", 12F);
            LTelefonoCliente.Location = new Point(36, 414);
            LTelefonoCliente.Name = "LTelefonoCliente";
            LTelefonoCliente.Size = new Size(86, 28);
            LTelefonoCliente.TabIndex = 21;
            LTelefonoCliente.Text = "Telefono";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.BackColor = Color.White;
            LEmail.Font = new Font("Segoe UI", 12F);
            LEmail.Location = new Point(36, 292);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(59, 28);
            LEmail.TabIndex = 22;
            LEmail.Text = "email";
            // 
            // LCuit_cuil
            // 
            LCuit_cuil.AutoSize = true;
            LCuit_cuil.BackColor = Color.White;
            LCuit_cuil.Font = new Font("Segoe UI", 12F);
            LCuit_cuil.Location = new Point(36, 190);
            LCuit_cuil.Name = "LCuit_cuil";
            LCuit_cuil.Size = new Size(101, 28);
            LCuit_cuil.TabIndex = 23;
            LCuit_cuil.Text = "CUIT/CUIL";
            // 
            // TBCliente
            // 
            TBCliente.Font = new Font("Segoe UI", 12F);
            TBCliente.Location = new Point(36, 135);
            TBCliente.Name = "TBCliente";
            TBCliente.Size = new Size(269, 34);
            TBCliente.TabIndex = 24;
            // 
            // TBCuitCuil
            // 
            TBCuitCuil.Font = new Font("Segoe UI", 12F);
            TBCuitCuil.Location = new Point(36, 235);
            TBCuitCuil.Name = "TBCuitCuil";
            TBCuitCuil.Size = new Size(269, 34);
            TBCuitCuil.TabIndex = 25;
            // 
            // TBEmailCliente
            // 
            TBEmailCliente.Font = new Font("Segoe UI", 12F);
            TBEmailCliente.Location = new Point(36, 351);
            TBEmailCliente.Name = "TBEmailCliente";
            TBEmailCliente.Size = new Size(269, 34);
            TBEmailCliente.TabIndex = 26;
            // 
            // TBTelefonoCliente
            // 
            TBTelefonoCliente.Font = new Font("Segoe UI", 12F);
            TBTelefonoCliente.Location = new Point(36, 476);
            TBTelefonoCliente.Name = "TBTelefonoCliente";
            TBTelefonoCliente.Size = new Size(269, 34);
            TBTelefonoCliente.TabIndex = 27;
            // 
            // btn_guardar_cliente
            // 
            btn_guardar_cliente.BackColor = Color.LightGreen;
            btn_guardar_cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar_cliente.Location = new Point(36, 537);
            btn_guardar_cliente.Name = "btn_guardar_cliente";
            btn_guardar_cliente.Size = new Size(269, 43);
            btn_guardar_cliente.TabIndex = 28;
            btn_guardar_cliente.Text = "Guardar";
            btn_guardar_cliente.UseVisualStyleBackColor = false;
            btn_guardar_cliente.Click += btn_guardar_cliente_Click;
            // 
            // btn_limpiar_cliente
            // 
            btn_limpiar_cliente.BackColor = Color.FromArgb(255, 192, 128);
            btn_limpiar_cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar_cliente.Location = new Point(36, 649);
            btn_limpiar_cliente.Name = "btn_limpiar_cliente";
            btn_limpiar_cliente.Size = new Size(269, 43);
            btn_limpiar_cliente.TabIndex = 29;
            btn_limpiar_cliente.Text = "Limpiar";
            btn_limpiar_cliente.UseVisualStyleBackColor = false;
            btn_limpiar_cliente.Click += btn_limpiar_cliente_Click;
            // 
            // btn_eliminar_cliente
            // 
            btn_eliminar_cliente.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar_cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar_cliente.Location = new Point(36, 699);
            btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            btn_eliminar_cliente.Size = new Size(269, 43);
            btn_eliminar_cliente.TabIndex = 30;
            btn_eliminar_cliente.Text = "Eliminar";
            btn_eliminar_cliente.UseVisualStyleBackColor = false;
            btn_eliminar_cliente.Click += btn_eliminar_cliente_Click;
            // 
            // l_lista_cliente
            // 
            l_lista_cliente.BackColor = Color.White;
            l_lista_cliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_cliente.Location = new Point(425, 9);
            l_lista_cliente.Name = "l_lista_cliente";
            l_lista_cliente.Size = new Size(903, 66);
            l_lista_cliente.TabIndex = 31;
            l_lista_cliente.Text = "Lista de clientes";
            l_lista_cliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // text_buscar_cliente
            // 
            text_buscar_cliente.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_cliente.Location = new Point(726, 31);
            text_buscar_cliente.Name = "text_buscar_cliente";
            text_buscar_cliente.Size = new Size(493, 31);
            text_buscar_cliente.TabIndex = 34;
            // 
            // btn_buscar_cliente
            // 
            btn_buscar_cliente.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_cliente.Image = Properties.Resources.lupa;
            btn_buscar_cliente.Location = new Point(1237, 24);
            btn_buscar_cliente.Name = "btn_buscar_cliente";
            btn_buscar_cliente.Size = new Size(66, 43);
            btn_buscar_cliente.TabIndex = 35;
            btn_buscar_cliente.UseVisualStyleBackColor = false;
            // 
            // DGVListCliente
            // 
            DGVListCliente.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVListCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVListCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListCliente.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, id_cliente, nombre_razonSocial, CUIT_CUIL, email, Telefono });
            DGVListCliente.Location = new Point(425, 105);
            DGVListCliente.MultiSelect = false;
            DGVListCliente.Name = "DGVListCliente";
            DGVListCliente.ReadOnly = true;
            DGVListCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            DGVListCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DGVListCliente.Size = new Size(903, 564);
            DGVListCliente.TabIndex = 36;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.MinimumWidth = 6;
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Width = 30;
            // 
            // id_cliente
            // 
            id_cliente.HeaderText = "id_cliente";
            id_cliente.MinimumWidth = 6;
            id_cliente.Name = "id_cliente";
            id_cliente.ReadOnly = true;
            id_cliente.Visible = false;
            id_cliente.Width = 125;
            // 
            // nombre_razonSocial
            // 
            nombre_razonSocial.HeaderText = "nombre_razonSocial";
            nombre_razonSocial.MinimumWidth = 6;
            nombre_razonSocial.Name = "nombre_razonSocial";
            nombre_razonSocial.ReadOnly = true;
            nombre_razonSocial.Width = 125;
            // 
            // CUIT_CUIL
            // 
            CUIT_CUIL.HeaderText = "CUIT_CUIL";
            CUIT_CUIL.MinimumWidth = 6;
            CUIT_CUIL.Name = "CUIT_CUIL";
            CUIT_CUIL.ReadOnly = true;
            CUIT_CUIL.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(36, 586);
            button1.Name = "button1";
            button1.Size = new Size(269, 43);
            button1.TabIndex = 37;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_ir_venta_cliente
            // 
            btn_ir_venta_cliente.BackColor = SystemColors.Highlight;
            btn_ir_venta_cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ir_venta_cliente.ForeColor = Color.Snow;
            btn_ir_venta_cliente.Location = new Point(1168, 699);
            btn_ir_venta_cliente.Name = "btn_ir_venta_cliente";
            btn_ir_venta_cliente.Size = new Size(160, 43);
            btn_ir_venta_cliente.TabIndex = 38;
            btn_ir_venta_cliente.Text = "ir a Venta";
            btn_ir_venta_cliente.UseVisualStyleBackColor = false;
            btn_ir_venta_cliente.Click += btn_volver_cliente_Click;
            // 
            // VendedorViewCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 781);
            Controls.Add(btn_ir_venta_cliente);
            Controls.Add(button1);
            Controls.Add(DGVListCliente);
            Controls.Add(btn_buscar_cliente);
            Controls.Add(text_buscar_cliente);
            Controls.Add(l_lista_cliente);
            Controls.Add(btn_eliminar_cliente);
            Controls.Add(btn_limpiar_cliente);
            Controls.Add(btn_guardar_cliente);
            Controls.Add(TBTelefonoCliente);
            Controls.Add(TBEmailCliente);
            Controls.Add(TBCuitCuil);
            Controls.Add(TBCliente);
            Controls.Add(LCuit_cuil);
            Controls.Add(LEmail);
            Controls.Add(LTelefonoCliente);
            Controls.Add(l_nombre_razonSocial);
            Controls.Add(label2);
            Controls.Add(LDetalleCliente);
            Name = "VendedorViewCliente";
            Text = "VendedorViewCliente";
            ((System.ComponentModel.ISupportInitialize)DGVListCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LDetalleCliente;
        private Label label2;
        private Label l_nombre_razonSocial;
        private Label LTelefonoCliente;
        private Label LEmail;
        private Label LCuit_cuil;
        private TextBox TBCliente;
        private TextBox TBCuitCuil;
        private TextBox TBEmailCliente;
        private TextBox TBTelefonoCliente;
        private Button btn_guardar_cliente;
        private Button btn_limpiar_cliente;
        private Button btn_eliminar_cliente;
        private Label l_lista_cliente;
        private TextBox text_buscar_cliente;
        private Button btn_buscar_cliente;
        private DataGridView DGVListCliente;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn nombre_razonSocial;
        private DataGridViewTextBoxColumn CUIT_CUIL;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Telefono;
        private Button button1;
        private Button btn_ir_venta_cliente;
    }
}