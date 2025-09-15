namespace VocesDePapelV1._1.Views
{
    partial class VentaView
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
            LFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            LCliente = new Label();
            TBNombreCliente = new TextBox();
            label1 = new Label();
            LCuilCuit = new Label();
            TBCuilCuit = new TextBox();
            LEmail = new Label();
            TBEmail = new TextBox();
            LTelefono = new Label();
            TBTelefono = new TextBox();
            PProducto = new Panel();
            BAgregarP = new Button();
            NUDCantidadProducto = new NumericUpDown();
            LCantidad = new Label();
            TBSTock = new TextBox();
            LStock = new Label();
            TBPrecio = new TextBox();
            LPrecio = new Label();
            BBuscarProducto = new Button();
            TBNomProducto = new TextBox();
            LNomProducto = new Label();
            TBCodProducto = new TextBox();
            LCodProducto = new Label();
            LProducto = new Label();
            PCliente = new Panel();
            BBuscarCliente = new Button();
            BAgregarCliente = new Button();
            PVendedor = new Panel();
            TBNombreApellidoVendedor = new TextBox();
            TBCuitVendedor = new TextBox();
            LNombeYApellidoV = new Label();
            LCuitVendedor = new Label();
            LVendedor = new Label();
            PFactura = new Panel();
            TBNUmFactura = new TextBox();
            LNUmFACTura = new Label();
            LFactura = new Label();
            dataGridView1 = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Sub_Total = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewTextBoxColumn();
            label3 = new Label();
            LPrecioTotal = new Label();
            TBPrecioTotal = new TextBox();
            BGuardar = new Button();
            BCancelar = new Button();
            PProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCantidadProducto).BeginInit();
            PCliente.SuspendLayout();
            PVendedor.SuspendLayout();
            PFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LFecha
            // 
            LFecha.Font = new Font("Segoe UI", 10F);
            LFecha.ImageAlign = ContentAlignment.BottomCenter;
            LFecha.Location = new Point(3, 73);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(72, 32);
            LFecha.TabIndex = 0;
            LFecha.Text = "Fecha:";
            LFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(51, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LCliente.Location = new Point(3, 0);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(71, 23);
            LCliente.TabIndex = 2;
            LCliente.Text = "Cliente:";
            // 
            // TBNombreCliente
            // 
            TBNombreCliente.Location = new Point(193, 23);
            TBNombreCliente.Name = "TBNombreCliente";
            TBNombreCliente.Size = new Size(270, 27);
            TBNombreCliente.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(184, 26);
            label1.TabIndex = 4;
            label1.Text = "Nombre/Razon Social:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LCuilCuit
            // 
            LCuilCuit.Font = new Font("Segoe UI", 10F);
            LCuilCuit.ImageAlign = ContentAlignment.BottomCenter;
            LCuilCuit.Location = new Point(3, 56);
            LCuilCuit.Name = "LCuilCuit";
            LCuilCuit.Size = new Size(80, 20);
            LCuilCuit.TabIndex = 5;
            LCuilCuit.Text = "Cuit/Cuil:";
            LCuilCuit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBCuilCuit
            // 
            TBCuilCuit.Location = new Point(95, 49);
            TBCuilCuit.Name = "TBCuilCuit";
            TBCuilCuit.Size = new Size(226, 27);
            TBCuilCuit.TabIndex = 6;
            // 
            // LEmail
            // 
            LEmail.Font = new Font("Segoe UI", 10F);
            LEmail.ImageAlign = ContentAlignment.BottomCenter;
            LEmail.Location = new Point(3, 82);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(57, 27);
            LEmail.TabIndex = 7;
            LEmail.Text = "email:";
            LEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBEmail
            // 
            TBEmail.Location = new Point(95, 80);
            TBEmail.Name = "TBEmail";
            TBEmail.Size = new Size(226, 27);
            TBEmail.TabIndex = 8;
            // 
            // LTelefono
            // 
            LTelefono.Font = new Font("Segoe UI", 10F);
            LTelefono.ImageAlign = ContentAlignment.BottomCenter;
            LTelefono.Location = new Point(3, 113);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(78, 28);
            LTelefono.TabIndex = 9;
            LTelefono.Text = "Telefono:";
            LTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBTelefono
            // 
            TBTelefono.Location = new Point(95, 113);
            TBTelefono.Name = "TBTelefono";
            TBTelefono.Size = new Size(226, 27);
            TBTelefono.TabIndex = 10;
            // 
            // PProducto
            // 
            PProducto.BackColor = SystemColors.GradientInactiveCaption;
            PProducto.Controls.Add(BAgregarP);
            PProducto.Controls.Add(NUDCantidadProducto);
            PProducto.Controls.Add(LCantidad);
            PProducto.Controls.Add(TBSTock);
            PProducto.Controls.Add(LStock);
            PProducto.Controls.Add(TBPrecio);
            PProducto.Controls.Add(LPrecio);
            PProducto.Controls.Add(BBuscarProducto);
            PProducto.Controls.Add(TBNomProducto);
            PProducto.Controls.Add(LNomProducto);
            PProducto.Controls.Add(TBCodProducto);
            PProducto.Controls.Add(LCodProducto);
            PProducto.Controls.Add(LProducto);
            PProducto.Location = new Point(12, 166);
            PProducto.Name = "PProducto";
            PProducto.Size = new Size(911, 82);
            PProducto.TabIndex = 11;
            // 
            // BAgregarP
            // 
            BAgregarP.BackColor = Color.FromArgb(192, 255, 192);
            BAgregarP.Location = new Point(708, 20);
            BAgregarP.Name = "BAgregarP";
            BAgregarP.Size = new Size(141, 51);
            BAgregarP.TabIndex = 15;
            BAgregarP.Text = "Agregar";
            BAgregarP.UseVisualStyleBackColor = false;
            // 
            // NUDCantidadProducto
            // 
            NUDCantidadProducto.Location = new Point(579, 43);
            NUDCantidadProducto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDCantidadProducto.Name = "NUDCantidadProducto";
            NUDCantidadProducto.Size = new Size(58, 27);
            NUDCantidadProducto.TabIndex = 18;
            NUDCantidadProducto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LCantidad
            // 
            LCantidad.Font = new Font("Segoe UI", 9F);
            LCantidad.ImageAlign = ContentAlignment.BottomCenter;
            LCantidad.Location = new Point(575, 20);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(76, 20);
            LCantidad.TabIndex = 17;
            LCantidad.Text = "Cantidad:";
            LCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBSTock
            // 
            TBSTock.Location = new Point(492, 44);
            TBSTock.Name = "TBSTock";
            TBSTock.Size = new Size(63, 27);
            TBSTock.TabIndex = 17;
            // 
            // LStock
            // 
            LStock.Font = new Font("Segoe UI", 9F);
            LStock.ImageAlign = ContentAlignment.BottomCenter;
            LStock.Location = new Point(492, 20);
            LStock.Name = "LStock";
            LStock.Size = new Size(63, 20);
            LStock.TabIndex = 16;
            LStock.Text = "Stock:";
            LStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBPrecio
            // 
            TBPrecio.Location = new Point(398, 43);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(78, 27);
            TBPrecio.TabIndex = 16;
            // 
            // LPrecio
            // 
            LPrecio.Font = new Font("Segoe UI", 9F);
            LPrecio.ImageAlign = ContentAlignment.BottomCenter;
            LPrecio.Location = new Point(398, 20);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(63, 20);
            LPrecio.TabIndex = 15;
            LPrecio.Text = "Precio:";
            LPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.Image = Properties.Resources.lupa;
            BBuscarProducto.Location = new Point(148, 29);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(59, 41);
            BBuscarProducto.TabIndex = 10;
            BBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // TBNomProducto
            // 
            TBNomProducto.Location = new Point(224, 43);
            TBNomProducto.Name = "TBNomProducto";
            TBNomProducto.Size = new Size(151, 27);
            TBNomProducto.TabIndex = 9;
            // 
            // LNomProducto
            // 
            LNomProducto.Font = new Font("Segoe UI", 9F);
            LNomProducto.ImageAlign = ContentAlignment.BottomCenter;
            LNomProducto.Location = new Point(213, 20);
            LNomProducto.Name = "LNomProducto";
            LNomProducto.Size = new Size(114, 20);
            LNomProducto.TabIndex = 8;
            LNomProducto.Text = "Producto:";
            LNomProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBCodProducto
            // 
            TBCodProducto.Location = new Point(17, 43);
            TBCodProducto.Name = "TBCodProducto";
            TBCodProducto.Size = new Size(125, 27);
            TBCodProducto.TabIndex = 7;
            // 
            // LCodProducto
            // 
            LCodProducto.Font = new Font("Segoe UI", 9F);
            LCodProducto.ImageAlign = ContentAlignment.BottomCenter;
            LCodProducto.Location = new Point(16, 20);
            LCodProducto.Name = "LCodProducto";
            LCodProducto.Size = new Size(114, 20);
            LCodProducto.TabIndex = 6;
            LCodProducto.Text = "Cod. Producto:";
            LCodProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LProducto
            // 
            LProducto.AutoSize = true;
            LProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LProducto.Location = new Point(17, 0);
            LProducto.Name = "LProducto";
            LProducto.Size = new Size(77, 20);
            LProducto.TabIndex = 0;
            LProducto.Text = "Producto:";
            // 
            // PCliente
            // 
            PCliente.Controls.Add(BBuscarCliente);
            PCliente.Controls.Add(BAgregarCliente);
            PCliente.Controls.Add(LCliente);
            PCliente.Controls.Add(label1);
            PCliente.Controls.Add(TBNombreCliente);
            PCliente.Controls.Add(TBCuilCuit);
            PCliente.Controls.Add(TBEmail);
            PCliente.Controls.Add(TBTelefono);
            PCliente.Controls.Add(LCuilCuit);
            PCliente.Controls.Add(LTelefono);
            PCliente.Controls.Add(LEmail);
            PCliente.Location = new Point(200, 7);
            PCliente.Name = "PCliente";
            PCliente.Size = new Size(468, 153);
            PCliente.TabIndex = 12;
            // 
            // BBuscarCliente
            // 
            BBuscarCliente.BackColor = SystemColors.GradientInactiveCaption;
            BBuscarCliente.ForeColor = SystemColors.ActiveCaptionText;
            BBuscarCliente.Location = new Point(363, 110);
            BBuscarCliente.Name = "BBuscarCliente";
            BBuscarCliente.Size = new Size(86, 31);
            BBuscarCliente.TabIndex = 12;
            BBuscarCliente.Text = "Buscar";
            BBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // BAgregarCliente
            // 
            BAgregarCliente.BackColor = Color.FromArgb(192, 255, 192);
            BAgregarCliente.ForeColor = SystemColors.ActiveCaptionText;
            BAgregarCliente.Location = new Point(361, 62);
            BAgregarCliente.Name = "BAgregarCliente";
            BAgregarCliente.Size = new Size(90, 33);
            BAgregarCliente.TabIndex = 11;
            BAgregarCliente.Text = "Agregar";
            BAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // PVendedor
            // 
            PVendedor.Controls.Add(TBNombreApellidoVendedor);
            PVendedor.Controls.Add(TBCuitVendedor);
            PVendedor.Controls.Add(LNombeYApellidoV);
            PVendedor.Controls.Add(LCuitVendedor);
            PVendedor.Controls.Add(LVendedor);
            PVendedor.Location = new Point(674, 7);
            PVendedor.Name = "PVendedor";
            PVendedor.Size = new Size(249, 153);
            PVendedor.TabIndex = 13;
            // 
            // TBNombreApellidoVendedor
            // 
            TBNombreApellidoVendedor.Location = new Point(12, 80);
            TBNombreApellidoVendedor.Name = "TBNombreApellidoVendedor";
            TBNombreApellidoVendedor.Size = new Size(233, 27);
            TBNombreApellidoVendedor.TabIndex = 9;
            // 
            // TBCuitVendedor
            // 
            TBCuitVendedor.Location = new Point(78, 19);
            TBCuitVendedor.Name = "TBCuitVendedor";
            TBCuitVendedor.Size = new Size(167, 27);
            TBCuitVendedor.TabIndex = 8;
            // 
            // LNombeYApellidoV
            // 
            LNombeYApellidoV.Font = new Font("Segoe UI", 10F);
            LNombeYApellidoV.ImageAlign = ContentAlignment.BottomCenter;
            LNombeYApellidoV.Location = new Point(3, 49);
            LNombeYApellidoV.Name = "LNombeYApellidoV";
            LNombeYApellidoV.Size = new Size(184, 26);
            LNombeYApellidoV.TabIndex = 7;
            LNombeYApellidoV.Text = "Nombre y Apellido:";
            LNombeYApellidoV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LCuitVendedor
            // 
            LCuitVendedor.Font = new Font("Segoe UI", 10F);
            LCuitVendedor.ImageAlign = ContentAlignment.BottomCenter;
            LCuitVendedor.Location = new Point(12, 22);
            LCuitVendedor.Name = "LCuitVendedor";
            LCuitVendedor.Size = new Size(68, 20);
            LCuitVendedor.TabIndex = 6;
            LCuitVendedor.Text = "Cuit:";
            LCuitVendedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LVendedor.Location = new Point(12, 2);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(81, 20);
            LVendedor.TabIndex = 1;
            LVendedor.Text = "Vendedor:";
            // 
            // PFactura
            // 
            PFactura.Controls.Add(TBNUmFactura);
            PFactura.Controls.Add(LNUmFACTura);
            PFactura.Controls.Add(LFactura);
            PFactura.Controls.Add(LFecha);
            PFactura.Controls.Add(dateTimePicker1);
            PFactura.Location = new Point(12, 23);
            PFactura.Name = "PFactura";
            PFactura.Size = new Size(182, 137);
            PFactura.TabIndex = 14;
            // 
            // TBNUmFactura
            // 
            TBNUmFactura.Location = new Point(16, 43);
            TBNUmFactura.Name = "TBNUmFactura";
            TBNUmFactura.Size = new Size(149, 27);
            TBNUmFactura.TabIndex = 9;
            // 
            // LNUmFACTura
            // 
            LNUmFACTura.Font = new Font("Segoe UI", 10F);
            LNUmFACTura.ImageAlign = ContentAlignment.BottomCenter;
            LNUmFACTura.Location = new Point(3, 20);
            LNUmFACTura.Name = "LNUmFACTura";
            LNUmFACTura.Size = new Size(79, 20);
            LNUmFACTura.TabIndex = 8;
            LNUmFACTura.Text = "Numero:";
            LNUmFACTura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LFactura
            // 
            LFactura.AutoSize = true;
            LFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LFactura.Location = new Point(3, 0);
            LFactura.Name = "LFactura";
            LFactura.Size = new Size(65, 20);
            LFactura.TabIndex = 1;
            LFactura.Text = "Factura:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, descripcion, Cantidad, Sub_Total, Eliminar });
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(671, 220);
            dataGridView1.TabIndex = 15;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "idProducto";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "descripcion";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Sub_Total
            // 
            Sub_Total.HeaderText = "Sub_Total";
            Sub_Total.MinimumWidth = 6;
            Sub_Total.Name = "Sub_Total";
            Sub_Total.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(12, 251);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 16;
            label3.Text = "Lista de Productos:";
            // 
            // LPrecioTotal
            // 
            LPrecioTotal.AutoSize = true;
            LPrecioTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LPrecioTotal.Location = new Point(705, 288);
            LPrecioTotal.Name = "LPrecioTotal";
            LPrecioTotal.Size = new Size(95, 20);
            LPrecioTotal.TabIndex = 17;
            LPrecioTotal.Text = "Precio Total:";
            // 
            // TBPrecioTotal
            // 
            TBPrecioTotal.Location = new Point(806, 281);
            TBPrecioTotal.Name = "TBPrecioTotal";
            TBPrecioTotal.Size = new Size(78, 27);
            TBPrecioTotal.TabIndex = 18;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(192, 255, 192);
            BGuardar.Cursor = Cursors.Hand;
            BGuardar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BGuardar.Location = new Point(729, 346);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(151, 45);
            BGuardar.TabIndex = 19;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.FromArgb(255, 128, 128);
            BCancelar.Cursor = Cursors.Hand;
            BCancelar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BCancelar.Location = new Point(729, 407);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(151, 45);
            BCancelar.TabIndex = 20;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            // 
            // VentaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 535);
            Controls.Add(BCancelar);
            Controls.Add(BGuardar);
            Controls.Add(TBPrecioTotal);
            Controls.Add(LPrecioTotal);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(PFactura);
            Controls.Add(PVendedor);
            Controls.Add(PCliente);
            Controls.Add(PProducto);
            Name = "VentaView";
            Text = "Venta";
            PProducto.ResumeLayout(false);
            PProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCantidadProducto).EndInit();
            PCliente.ResumeLayout(false);
            PCliente.PerformLayout();
            PVendedor.ResumeLayout(false);
            PVendedor.PerformLayout();
            PFactura.ResumeLayout(false);
            PFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LFecha;
        private DateTimePicker dateTimePicker1;
        private Label LCliente;
        private TextBox TBNombreCliente;
        private Label label1;
        private Label LCuilCuit;
        private TextBox TBCuilCuit;
        private Label LEmail;
        private TextBox TBEmail;
        private Label LTelefono;
        private TextBox TBTelefono;
        private Panel PProducto;
        private Label LProducto;
        private Panel PCliente;
        private Panel PVendedor;
        private Button BAgregarCliente;
        private Button BBuscarCliente;
        private Label LVendedor;
        private Label LNombeYApellidoV;
        private Label LCuitVendedor;
        private TextBox TBNombreApellidoVendedor;
        private TextBox TBCuitVendedor;
        private Panel PFactura;
        private Label LFactura;
        private TextBox TBNUmFactura;
        private Label LNUmFACTura;
        private Label LCodProducto;
        private TextBox TBCodProducto;
        private Button BBuscarProducto;
        private TextBox TBNomProducto;
        private Label LNomProducto;
        private Label LPrecio;
        private Label LCantidad;
        private TextBox TBSTock;
        private Label LStock;
        private TextBox TBPrecio;
        private NumericUpDown NUDCantidadProducto;
        private Button BAgregarP;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Sub_Total;
        private DataGridViewTextBoxColumn Eliminar;
        private Label label3;
        private Label LPrecioTotal;
        private TextBox TBPrecioTotal;
        private Button BGuardar;
        private Button BCancelar;
    }
}