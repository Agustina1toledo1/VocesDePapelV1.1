namespace VocesDePapelV1._1.Views
{
    partial class ReporteVentasView
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelFiltros = new Panel();
            grpFiltros = new GroupBox();
            cmbVendedor = new ComboBox();
            chkIncluirDetalles = new CheckBox();
            lblTipoReporte = new Label();
            lblBusqueda = new Label();
            cmbTipoReporte = new ComboBox();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            panelBotones = new Panel();
            btnLimpiar = new Button();
            btnGenerarPDF = new Button();
            btnBuscar = new Button();
            panelResultados = new Panel();
            grpEstadisticas = new GroupBox();
            lblPromedio = new Label();
            lblPromedioVenta = new Label();
            lblCantidad = new Label();
            lblCantidadVentas = new Label();
            lblTotal = new Label();
            lblTotalVentas = new Label();
            panelGrid = new Panel();
            dgvVentas = new DataGridView();
            lblMensaje = new Label();
            cmbBusqueda = new ComboBox();
            panelFiltros.SuspendLayout();
            grpFiltros.SuspendLayout();
            panelBotones.SuspendLayout();
            panelResultados.SuspendLayout();
            grpEstadisticas.SuspendLayout();
            panelGrid.SuspendLayout();
            grpFiltros.Controls.Add(cmbVendedores);
            grpFiltros.Controls.Add(txtVendedorAuto);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(grpFiltros);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 0);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(1200, 120);
            panelFiltros.TabIndex = 0;
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(cmbBusqueda);
            grpFiltros.Controls.Add(cmbVendedor);
            grpFiltros.Controls.Add(chkIncluirDetalles);
            grpFiltros.Controls.Add(lblTipoReporte);
            grpFiltros.Controls.Add(cmbTipoReporte);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(dtpFechaFin);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Controls.Add(dtpFechaInicio);
            grpFiltros.Dock = DockStyle.Fill;
            grpFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFiltros.Location = new Point(0, 0);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(1200, 120);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros del Reporte";
            // 
            // cmbVendedor
            // 
            cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(150, 117);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(200, 28);
            cmbVendedor.TabIndex = 11;
            // 
            // chkIncluirDetalles
            // 
            chkIncluirDetalles.AutoSize = true;
            chkIncluirDetalles.Font = new Font("Segoe UI", 9F);
            chkIncluirDetalles.Location = new Point(900, 70);
            chkIncluirDetalles.Name = "chkIncluirDetalles";
            chkIncluirDetalles.Size = new Size(129, 24);
            chkIncluirDetalles.TabIndex = 8;
            chkIncluirDetalles.Text = "Incluir Detalles";
            chkIncluirDetalles.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
=======
            // lblFiltroAdicional
            // 
            lblFiltroAdicional.AutoSize = true;
            lblFiltroAdicional.Font = new Font("Segoe UI", 9F);
            lblFiltroAdicional.Location = new Point(600, 40);
            lblFiltroAdicional.Name = "lblFiltroAdicional";
            lblFiltroAdicional.Size = new Size(95, 20);
            lblFiltroAdicional.TabIndex = 7;
            lblFiltroAdicional.Text = "ID Vendedor:";
            // 
            // txtFiltroAdicional
            // 
            txtFiltroAdicional.Font = new Font("Segoe UI", 9F);
            txtFiltroAdicional.Location = new Point(600, 65);
            txtFiltroAdicional.Name = "txtFiltroAdicional";
            txtFiltroAdicional.Size = new Size(200, 27);
            txtFiltroAdicional.TabIndex = 6;
            // 
            // ComboBox para Gerente
            cmbVendedores = new ComboBox();
            cmbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendedores.Location = new Point(600, 65);
            cmbVendedores.Size = new Size(200, 28);
            cmbVendedores.Visible = false;

            // TextBox para Vendedor (solo lectura)
            txtVendedorAuto = new TextBox();
            txtVendedorAuto.ReadOnly = true;
            txtVendedorAuto.BackColor = Color.LightGray;
            txtVendedorAuto.Location = new Point(600, 65);
            txtVendedorAuto.Size = new Size(200, 27);
            txtVendedorAuto.Visible = false;
            //
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 9F);
            lblTipoReporte.Location = new Point(400, 40);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(99, 20);
            lblTipoReporte.TabIndex = 5;
            lblTipoReporte.Text = "Tipo Reporte:";
            // 
            //lblBusqueda
            //
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Segoe UI", 9F);
            lblBusqueda.Location = new Point(622, 40);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(80, 20);
            lblBusqueda.TabIndex = 10;
            lblBusqueda.Text = "Búsqueda:";
            //
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new Font("Segoe UI", 9F);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Items.AddRange(new object[] { "Por Fecha", "Por Vendedor", "Top 10 Ventas", "Por Cliente" });
            cmbTipoReporte.Location = new Point(400, 65);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(180, 28);
            cmbTipoReporte.TabIndex = 4;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 9F);
            lblFechaFin.Location = new Point(200, 40);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(73, 20);
            lblFechaFin.TabIndex = 3;
            lblFechaFin.Text = "Fecha Fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 9F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(200, 65);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(180, 27);
            dtpFechaFin.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 9F);
            lblFechaInicio.Location = new Point(20, 40);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(90, 20);
            lblFechaInicio.TabIndex = 1;
            lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 9F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(20, 65);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(160, 27);
            dtpFechaInicio.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Controls.Add(btnGenerarPDF);
            panelBotones.Controls.Add(btnBuscar);
            panelBotones.Dock = DockStyle.Top;
            panelBotones.Location = new Point(0, 120);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1200, 60);
            panelBotones.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightGray;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.Location = new Point(400, 10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 40);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.LightCoral;
            btnGenerarPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarPDF.Location = new Point(140, 10);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(120, 40);
            btnGenerarPDF.TabIndex = 1;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.GradientActiveCaption;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.Location = new Point(20, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 40);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // panelResultados
            // 
            panelResultados.Controls.Add(grpEstadisticas);
            panelResultados.Dock = DockStyle.Top;
            panelResultados.Location = new Point(0, 180);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(1200, 80);
            panelResultados.TabIndex = 2;
            // 
            // grpEstadisticas
            // 
            grpEstadisticas.Controls.Add(lblPromedio);
            grpEstadisticas.Controls.Add(lblPromedioVenta);
            grpEstadisticas.Controls.Add(lblCantidad);
            grpEstadisticas.Controls.Add(lblCantidadVentas);
            grpEstadisticas.Controls.Add(lblTotal);
            grpEstadisticas.Controls.Add(lblTotalVentas);
            grpEstadisticas.Dock = DockStyle.Fill;
            grpEstadisticas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpEstadisticas.Location = new Point(0, 0);
            grpEstadisticas.Name = "grpEstadisticas";
            grpEstadisticas.Size = new Size(1200, 80);
            grpEstadisticas.TabIndex = 0;
            grpEstadisticas.TabStop = false;
            grpEstadisticas.Text = "Estadísticas del Período";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Segoe UI", 9F);
            lblPromedio.Location = new Point(800, 35);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(118, 20);
            lblPromedio.TabIndex = 5;
            lblPromedio.Text = "Promedio Venta:";
            // 
            // lblPromedioVenta
            // 
            lblPromedioVenta.AutoSize = true;
            lblPromedioVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPromedioVenta.ForeColor = Color.Blue;
            lblPromedioVenta.Location = new Point(920, 35);
            lblPromedioVenta.Name = "lblPromedioVenta";
            lblPromedioVenta.Size = new Size(49, 20);
            lblPromedioVenta.TabIndex = 4;
            lblPromedioVenta.Text = "$0.00";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F);
            lblCantidad.Location = new Point(400, 35);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(119, 20);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad Ventas:";
            // 
            // lblCantidadVentas
            // 
            lblCantidadVentas.AutoSize = true;
            lblCantidadVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantidadVentas.ForeColor = Color.Green;
            lblCantidadVentas.Location = new Point(530, 35);
            lblCantidadVentas.Name = "lblCantidadVentas";
            lblCantidadVentas.Size = new Size(18, 20);
            lblCantidadVentas.TabIndex = 2;
            lblCantidadVentas.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F);
            lblTotal.Location = new Point(20, 35);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total Ventas:";
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalVentas.ForeColor = Color.Red;
            lblTotalVentas.Location = new Point(140, 35);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(49, 20);
            lblTotalVentas.TabIndex = 0;
            lblTotalVentas.Text = "$0.00";
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvVentas);
            panelGrid.Controls.Add(lblMensaje);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 260);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1200, 440);
            panelGrid.TabIndex = 3;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(0, 30);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.Size = new Size(1200, 410);
            dgvVentas.TabIndex = 1;
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = SystemColors.Info;
            lblMensaje.Dock = DockStyle.Top;
            lblMensaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMensaje.ForeColor = Color.Blue;
            lblMensaje.Location = new Point(0, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(1200, 30);
            lblMensaje.TabIndex = 0;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Visible = false;
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBusqueda.Font = new Font("Segoe UI", 9F);
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Items.AddRange(new object[] { "Por Fecha", "Por Vendedor", "Top 10 Ventas", "Por Cliente" });
            cmbBusqueda.Location = new Point(622, 64);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(180, 28);
            cmbBusqueda.TabIndex = 12;
            // 
            // ReporteVentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelGrid);
            Controls.Add(panelResultados);
            Controls.Add(panelBotones);
            Controls.Add(panelFiltros);
            Name = "ReporteVentasView";
            Text = "Reporte de Ventas";
            panelFiltros.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelResultados.ResumeLayout(false);
            grpEstadisticas.ResumeLayout(false);
            grpEstadisticas.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panelFiltros;
        private GroupBox grpFiltros;
        private CheckBox chkIncluirDetalles;
<<<<<<< HEAD
        private ComboBox cmbVendedor;
        private Label lblBusqueda;
        // private Label lblVendedor;
        //private TextBox txtVendedorAuto;
=======
        private Label lblFiltroAdicional;
        private TextBox txtFiltroAdicional;
        private ComboBox cmbVendedores;
        private TextBox txtVendedorAuto;
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
        private Label lblTipoReporte;
        private ComboBox cmbTipoReporte;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaFin;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaInicio;
        private Panel panelBotones;
        private Button btnLimpiar;
        private Button btnGenerarPDF;
        private Button btnBuscar;
        private Panel panelResultados;
        private GroupBox grpEstadisticas;
        private Label lblPromedio;
        private Label lblPromedioVenta;
        private Label lblCantidad;
        private Label lblCantidadVentas;
        private Label lblTotal;
        private Label lblTotalVentas;
        private Panel panelGrid;
        private DataGridView dgvVentas;
        private Label lblMensaje;
        private ComboBox cmbBusqueda;
    }
}
