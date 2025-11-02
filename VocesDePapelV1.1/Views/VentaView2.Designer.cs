namespace VocesDePapelV1._1.Views
{
    partial class VentaView2
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
            BtnEliminarDetalle = new Button();
            BCancelar = new Button();
            BGuardar = new Button();
            LPrecioTotal = new Label();
            label3 = new Label();
            dataGridViewDetalles = new DataGridView();
            PFactura = new Panel();
            lb_nro_factura = new Label();
            LNUmFACTura = new Label();
            lb_comprobante = new Label();
            PVendedor = new Panel();
            lb_vendedor_nombre_apellido = new Label();
            TBCuitVendedor = new TextBox();
            LNombeYApellidoV = new Label();
            LCuitVendedor = new Label();
            LVendedor = new Label();
            PCliente = new Panel();
            lb_cliente_tel = new Label();
            lb_cliente_email = new Label();
            lb_cliente_nombre_razon = new Label();
            BLimpiarCliente = new Button();
            BAgregarCliente = new Button();
            LCliente = new Label();
            label1 = new Label();
            TBCuilCuit = new TextBox();
            LCuilCuit = new Label();
            LTelefono = new Label();
            l_cliente_email = new Label();
            PProducto = new Panel();
            lb_producto_subtotal = new Label();
            lb_producto_stock = new Label();
            lb_producto_precio = new Label();
            lb_producto_titulo = new Label();
            LSubtotal = new Label();
            BtnLimpiarDetalles = new Button();
            BtnAgregarDetalle = new Button();
            NUDCantidadProducto = new NumericUpDown();
            LCantidad = new Label();
            LStock = new Label();
            LPrecioU = new Label();
            BBuscarProducto = new Button();
            LNomProducto = new Label();
            TBSearch = new TextBox();
            LProducto = new Label();
            lb_venta_total = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).BeginInit();
            PFactura.SuspendLayout();
            PVendedor.SuspendLayout();
            PCliente.SuspendLayout();
            PProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCantidadProducto).BeginInit();
            SuspendLayout();
            // 
            // BtnEliminarDetalle
            // 
            BtnEliminarDetalle.BackColor = Color.FromArgb(255, 128, 128);
            BtnEliminarDetalle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminarDetalle.ForeColor = SystemColors.ActiveCaptionText;
            BtnEliminarDetalle.Location = new Point(804, 396);
            BtnEliminarDetalle.Margin = new Padding(0);
            BtnEliminarDetalle.Name = "BtnEliminarDetalle";
            BtnEliminarDetalle.Size = new Size(120, 38);
            BtnEliminarDetalle.TabIndex = 32;
            BtnEliminarDetalle.Text = "Eliminar";
            BtnEliminarDetalle.UseVisualStyleBackColor = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.FromArgb(255, 128, 128);
            BCancelar.Cursor = Cursors.Hand;
            BCancelar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BCancelar.Location = new Point(974, 559);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(151, 45);
            BCancelar.TabIndex = 31;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(192, 255, 192);
            BGuardar.Cursor = Cursors.Hand;
            BGuardar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BGuardar.Location = new Point(817, 559);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(151, 45);
            BGuardar.TabIndex = 30;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // LPrecioTotal
            // 
            LPrecioTotal.AutoSize = true;
            LPrecioTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LPrecioTotal.Location = new Point(817, 485);
            LPrecioTotal.Name = "LPrecioTotal";
            LPrecioTotal.Size = new Size(146, 31);
            LPrecioTotal.TabIndex = 28;
            LPrecioTotal.Text = "Precio Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 350);
            label3.Name = "label3";
            label3.Size = new Size(217, 31);
            label3.TabIndex = 27;
            label3.Text = "Lista de Productos:";
            // 
            // dataGridViewDetalles
            // 
            dataGridViewDetalles.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalles.Location = new Point(116, 384);
            dataGridViewDetalles.Name = "dataGridViewDetalles";
            dataGridViewDetalles.RowHeadersWidth = 51;
            dataGridViewDetalles.Size = new Size(671, 220);
            dataGridViewDetalles.TabIndex = 26;
            // 
            // PFactura
            // 
            PFactura.Controls.Add(lb_nro_factura);
            PFactura.Controls.Add(LNUmFACTura);
            PFactura.Location = new Point(116, 36);
            PFactura.Name = "PFactura";
            PFactura.Size = new Size(233, 169);
            PFactura.TabIndex = 25;
            // 
            // lb_nro_factura
            // 
            lb_nro_factura.AutoSize = true;
            lb_nro_factura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nro_factura.Location = new Point(32, 90);
            lb_nro_factura.Name = "lb_nro_factura";
            lb_nro_factura.Size = new Size(135, 28);
            lb_nro_factura.TabIndex = 33;
            lb_nro_factura.Text = "lb_nro_factura";
            // 
            // LNUmFACTura
            // 
            LNUmFACTura.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNUmFACTura.ImageAlign = ContentAlignment.BottomCenter;
            LNUmFACTura.Location = new Point(22, 41);
            LNUmFACTura.Name = "LNUmFACTura";
            LNUmFACTura.Size = new Size(117, 26);
            LNUmFACTura.TabIndex = 8;
            LNUmFACTura.Text = "Numero:";
            LNUmFACTura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_comprobante
            // 
            lb_comprobante.AutoSize = true;
            lb_comprobante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_comprobante.Location = new Point(119, 28);
            lb_comprobante.Name = "lb_comprobante";
            lb_comprobante.Size = new Size(145, 28);
            lb_comprobante.TabIndex = 1;
            lb_comprobante.Text = "Comprobante:";
            // 
            // PVendedor
            // 
            PVendedor.Controls.Add(lb_vendedor_nombre_apellido);
            PVendedor.Controls.Add(TBCuitVendedor);
            PVendedor.Controls.Add(LNombeYApellidoV);
            PVendedor.Controls.Add(LCuitVendedor);
            PVendedor.Controls.Add(LVendedor);
            PVendedor.Location = new Point(833, 36);
            PVendedor.Name = "PVendedor";
            PVendedor.Size = new Size(317, 169);
            PVendedor.TabIndex = 24;
            // 
            // lb_vendedor_nombre_apellido
            // 
            lb_vendedor_nombre_apellido.BorderStyle = BorderStyle.Fixed3D;
            lb_vendedor_nombre_apellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_vendedor_nombre_apellido.Location = new Point(25, 104);
            lb_vendedor_nombre_apellido.Name = "lb_vendedor_nombre_apellido";
            lb_vendedor_nombre_apellido.Size = new Size(277, 39);
            lb_vendedor_nombre_apellido.TabIndex = 37;
            // 
            // TBCuitVendedor
            // 
            TBCuitVendedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBCuitVendedor.Location = new Point(85, 27);
            TBCuitVendedor.Name = "TBCuitVendedor";
            TBCuitVendedor.Size = new Size(217, 34);
            TBCuitVendedor.TabIndex = 8;
            // 
            // LNombeYApellidoV
            // 
            LNombeYApellidoV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombeYApellidoV.ImageAlign = ContentAlignment.BottomCenter;
            LNombeYApellidoV.Location = new Point(0, 75);
            LNombeYApellidoV.Name = "LNombeYApellidoV";
            LNombeYApellidoV.Size = new Size(234, 26);
            LNombeYApellidoV.TabIndex = 7;
            LNombeYApellidoV.Text = "Nombre y Apellido:";
            LNombeYApellidoV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LCuitVendedor
            // 
            LCuitVendedor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCuitVendedor.ImageAlign = ContentAlignment.BottomCenter;
            LCuitVendedor.Location = new Point(12, 27);
            LCuitVendedor.Name = "LCuitVendedor";
            LCuitVendedor.Size = new Size(77, 26);
            LCuitVendedor.TabIndex = 6;
            LCuitVendedor.Text = "Cuit:";
            LCuitVendedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LVendedor.Location = new Point(12, -6);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(108, 28);
            LVendedor.TabIndex = 1;
            LVendedor.Text = "Vendedor:";
            // 
            // PCliente
            // 
            PCliente.Controls.Add(lb_cliente_tel);
            PCliente.Controls.Add(lb_cliente_email);
            PCliente.Controls.Add(lb_cliente_nombre_razon);
            PCliente.Controls.Add(BLimpiarCliente);
            PCliente.Controls.Add(BAgregarCliente);
            PCliente.Controls.Add(LCliente);
            PCliente.Controls.Add(label1);
            PCliente.Controls.Add(TBCuilCuit);
            PCliente.Controls.Add(LCuilCuit);
            PCliente.Controls.Add(LTelefono);
            PCliente.Controls.Add(l_cliente_email);
            PCliente.Location = new Point(355, 36);
            PCliente.Name = "PCliente";
            PCliente.Size = new Size(468, 169);
            PCliente.TabIndex = 23;
            // 
            // lb_cliente_tel
            // 
            lb_cliente_tel.BorderStyle = BorderStyle.Fixed3D;
            lb_cliente_tel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_cliente_tel.Location = new Point(104, 133);
            lb_cliente_tel.Name = "lb_cliente_tel";
            lb_cliente_tel.Size = new Size(198, 29);
            lb_cliente_tel.TabIndex = 36;
            // 
            // lb_cliente_email
            // 
            lb_cliente_email.BorderStyle = BorderStyle.Fixed3D;
            lb_cliente_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_cliente_email.Location = new Point(104, 101);
            lb_cliente_email.Name = "lb_cliente_email";
            lb_cliente_email.Size = new Size(198, 32);
            lb_cliente_email.TabIndex = 36;
            // 
            // lb_cliente_nombre_razon
            // 
            lb_cliente_nombre_razon.BorderStyle = BorderStyle.Fixed3D;
            lb_cliente_nombre_razon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_cliente_nombre_razon.Location = new Point(220, 18);
            lb_cliente_nombre_razon.Name = "lb_cliente_nombre_razon";
            lb_cliente_nombre_razon.Size = new Size(231, 35);
            lb_cliente_nombre_razon.TabIndex = 35;
            // 
            // BLimpiarCliente
            // 
            BLimpiarCliente.BackColor = Color.FromArgb(255, 192, 128);
            BLimpiarCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BLimpiarCliente.ForeColor = SystemColors.ActiveCaptionText;
            BLimpiarCliente.Location = new Point(361, 124);
            BLimpiarCliente.Name = "BLimpiarCliente";
            BLimpiarCliente.Size = new Size(90, 33);
            BLimpiarCliente.TabIndex = 12;
            BLimpiarCliente.Text = "Limpiar";
            BLimpiarCliente.UseVisualStyleBackColor = false;
            // 
            // BAgregarCliente
            // 
            BAgregarCliente.BackColor = Color.FromArgb(192, 255, 192);
            BAgregarCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregarCliente.ForeColor = SystemColors.ActiveCaptionText;
            BAgregarCliente.Location = new Point(361, 85);
            BAgregarCliente.Name = "BAgregarCliente";
            BAgregarCliente.Size = new Size(90, 33);
            BAgregarCliente.TabIndex = 11;
            BAgregarCliente.Text = "Agregar";
            BAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCliente.Location = new Point(3, -6);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(83, 28);
            LCliente.TabIndex = 2;
            LCliente.Text = "Cliente:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(-12, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 26);
            label1.TabIndex = 4;
            label1.Text = "Nombre/Razon Social:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBCuilCuit
            // 
            TBCuilCuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBCuilCuit.Location = new Point(104, 62);
            TBCuilCuit.Name = "TBCuilCuit";
            TBCuilCuit.Size = new Size(226, 34);
            TBCuilCuit.TabIndex = 6;
            // 
            // LCuilCuit
            // 
            LCuilCuit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCuilCuit.ImageAlign = ContentAlignment.BottomCenter;
            LCuilCuit.Location = new Point(3, 62);
            LCuilCuit.Name = "LCuilCuit";
            LCuilCuit.Size = new Size(95, 30);
            LCuilCuit.TabIndex = 5;
            LCuilCuit.Text = "Cuit/Cuil:";
            LCuilCuit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LTelefono
            // 
            LTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTelefono.ImageAlign = ContentAlignment.BottomCenter;
            LTelefono.Location = new Point(3, 127);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(95, 28);
            LTelefono.TabIndex = 9;
            LTelefono.Text = "Telefono:";
            LTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_cliente_email
            // 
            l_cliente_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_cliente_email.ImageAlign = ContentAlignment.BottomCenter;
            l_cliente_email.Location = new Point(3, 100);
            l_cliente_email.Name = "l_cliente_email";
            l_cliente_email.Size = new Size(74, 27);
            l_cliente_email.TabIndex = 7;
            l_cliente_email.Text = "email:";
            l_cliente_email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PProducto
            // 
            PProducto.BackColor = SystemColors.GradientInactiveCaption;
            PProducto.Controls.Add(lb_producto_subtotal);
            PProducto.Controls.Add(lb_producto_stock);
            PProducto.Controls.Add(lb_producto_precio);
            PProducto.Controls.Add(lb_producto_titulo);
            PProducto.Controls.Add(LSubtotal);
            PProducto.Controls.Add(BtnLimpiarDetalles);
            PProducto.Controls.Add(BtnAgregarDetalle);
            PProducto.Controls.Add(NUDCantidadProducto);
            PProducto.Controls.Add(LCantidad);
            PProducto.Controls.Add(LStock);
            PProducto.Controls.Add(LPrecioU);
            PProducto.Controls.Add(BBuscarProducto);
            PProducto.Controls.Add(LNomProducto);
            PProducto.Controls.Add(TBSearch);
            PProducto.Controls.Add(LProducto);
            PProducto.Location = new Point(116, 211);
            PProducto.Name = "PProducto";
            PProducto.Size = new Size(1036, 125);
            PProducto.TabIndex = 22;
            // 
            // lb_producto_subtotal
            // 
            lb_producto_subtotal.AutoSize = true;
            lb_producto_subtotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_producto_subtotal.Location = new Point(750, 70);
            lb_producto_subtotal.Name = "lb_producto_subtotal";
            lb_producto_subtotal.Size = new Size(85, 28);
            lb_producto_subtotal.TabIndex = 39;
            lb_producto_subtotal.Text = "subtotal";
            // 
            // lb_producto_stock
            // 
            lb_producto_stock.AutoSize = true;
            lb_producto_stock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_producto_stock.Location = new Point(514, 72);
            lb_producto_stock.Name = "lb_producto_stock";
            lb_producto_stock.Size = new Size(58, 28);
            lb_producto_stock.TabIndex = 38;
            lb_producto_stock.Text = "stock";
            // 
            // lb_producto_precio
            // 
            lb_producto_precio.AutoSize = true;
            lb_producto_precio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_producto_precio.Location = new Point(419, 70);
            lb_producto_precio.Name = "lb_producto_precio";
            lb_producto_precio.Size = new Size(67, 28);
            lb_producto_precio.TabIndex = 37;
            lb_producto_precio.Text = "precio";
            // 
            // lb_producto_titulo
            // 
            lb_producto_titulo.AutoSize = true;
            lb_producto_titulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_producto_titulo.Location = new Point(239, 71);
            lb_producto_titulo.Name = "lb_producto_titulo";
            lb_producto_titulo.Size = new Size(174, 28);
            lb_producto_titulo.TabIndex = 36;
            lb_producto_titulo.Text = "lb_producto_titulo";
            // 
            // LSubtotal
            // 
            LSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LSubtotal.ImageAlign = ContentAlignment.BottomCenter;
            LSubtotal.Location = new Point(717, 29);
            LSubtotal.Name = "LSubtotal";
            LSubtotal.Size = new Size(132, 32);
            LSubtotal.TabIndex = 31;
            LSubtotal.Text = "Subtotal:";
            LSubtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnLimpiarDetalles
            // 
            BtnLimpiarDetalles.BackColor = Color.FromArgb(255, 192, 128);
            BtnLimpiarDetalles.ForeColor = SystemColors.ActiveCaptionText;
            BtnLimpiarDetalles.Location = new Point(879, 78);
            BtnLimpiarDetalles.Name = "BtnLimpiarDetalles";
            BtnLimpiarDetalles.Size = new Size(112, 34);
            BtnLimpiarDetalles.TabIndex = 19;
            BtnLimpiarDetalles.Text = "Limpiar";
            BtnLimpiarDetalles.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarDetalle
            // 
            BtnAgregarDetalle.BackColor = Color.FromArgb(192, 255, 192);
            BtnAgregarDetalle.Location = new Point(879, 42);
            BtnAgregarDetalle.Name = "BtnAgregarDetalle";
            BtnAgregarDetalle.Size = new Size(114, 30);
            BtnAgregarDetalle.TabIndex = 15;
            BtnAgregarDetalle.Text = "Agregar";
            BtnAgregarDetalle.UseVisualStyleBackColor = false;
            // 
            // NUDCantidadProducto
            // 
            NUDCantidadProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NUDCantidadProducto.Location = new Point(638, 70);
            NUDCantidadProducto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDCantidadProducto.Name = "NUDCantidadProducto";
            NUDCantidadProducto.Size = new Size(58, 34);
            NUDCantidadProducto.TabIndex = 18;
            NUDCantidadProducto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LCantidad
            // 
            LCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCantidad.ImageAlign = ContentAlignment.BottomCenter;
            LCantidad.Location = new Point(613, 28);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(118, 34);
            LCantidad.TabIndex = 17;
            LCantidad.Text = "Cantidad:";
            LCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LStock
            // 
            LStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LStock.ImageAlign = ContentAlignment.BottomCenter;
            LStock.Location = new Point(502, 28);
            LStock.Name = "LStock";
            LStock.Size = new Size(105, 32);
            LStock.TabIndex = 16;
            LStock.Text = "Stock:";
            LStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LPrecioU
            // 
            LPrecioU.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LPrecioU.ImageAlign = ContentAlignment.BottomCenter;
            LPrecioU.Location = new Point(419, 27);
            LPrecioU.Name = "LPrecioU";
            LPrecioU.Size = new Size(77, 32);
            LPrecioU.TabIndex = 15;
            LPrecioU.Text = "Precio:";
            LPrecioU.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.Image = Properties.Resources.lupa;
            BBuscarProducto.Location = new Point(163, 59);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(59, 41);
            BBuscarProducto.TabIndex = 10;
            BBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // LNomProducto
            // 
            LNomProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNomProducto.ImageAlign = ContentAlignment.BottomCenter;
            LNomProducto.Location = new Point(239, 23);
            LNomProducto.Name = "LNomProducto";
            LNomProducto.Size = new Size(148, 39);
            LNomProducto.TabIndex = 8;
            LNomProducto.Text = "Producto:";
            LNomProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBSearch
            // 
            TBSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBSearch.Location = new Point(17, 63);
            TBSearch.Name = "TBSearch";
            TBSearch.Size = new Size(140, 34);
            TBSearch.TabIndex = 7;
            // 
            // LProducto
            // 
            LProducto.AutoSize = true;
            LProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LProducto.Location = new Point(17, -2);
            LProducto.Name = "LProducto";
            LProducto.Size = new Size(103, 28);
            LProducto.TabIndex = 0;
            LProducto.Text = "Producto:";
            // 
            // lb_venta_total
            // 
            lb_venta_total.AutoSize = true;
            lb_venta_total.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_venta_total.Location = new Point(995, 485);
            lb_venta_total.Name = "lb_venta_total";
            lb_venta_total.Size = new Size(65, 31);
            lb_venta_total.TabIndex = 40;
            lb_venta_total.Text = "total";
            // 
            // VentaView2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 709);
            Controls.Add(lb_venta_total);
            Controls.Add(BtnEliminarDetalle);
            Controls.Add(BCancelar);
            Controls.Add(lb_comprobante);
            Controls.Add(BGuardar);
            Controls.Add(LPrecioTotal);
            Controls.Add(label3);
            Controls.Add(dataGridViewDetalles);
            Controls.Add(PFactura);
            Controls.Add(PVendedor);
            Controls.Add(PCliente);
            Controls.Add(PProducto);
            Name = "VentaView2";
            Text = "VentaView2";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).EndInit();
            PFactura.ResumeLayout(false);
            PFactura.PerformLayout();
            PVendedor.ResumeLayout(false);
            PVendedor.PerformLayout();
            PCliente.ResumeLayout(false);
            PCliente.PerformLayout();
            PProducto.ResumeLayout(false);
            PProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCantidadProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEliminarDetalle;
        private Button BCancelar;
        private Button BGuardar;
        private Label LPrecioTotal;
        private Label label3;
        private DataGridView dataGridViewDetalles;
        private Panel PFactura;
        private TextBox TBNUmFactura;
        private Label LNUmFACTura;
        private Label lb_comprobante;
        private DateTimePicker dateTimePicker1;
        private Panel PVendedor;
        private TextBox TBCuitVendedor;
        private Label LNombeYApellidoV;
        private Label LCuitVendedor;
        private Label LVendedor;
        private Panel PCliente;
        private Button BLimpiarCliente;
        private Button BAgregarCliente;
        private Label LCliente;
        private Label label1;
        private TextBox TBCuilCuit;
        private Label LCuilCuit;
        private Label LTelefono;
        private Label l_cliente_email;
        private Panel PProducto;
        private Label LSubtotal;
        private Button BtnLimpiarDetalles;
        private Button BtnAgregarDetalle;
        private NumericUpDown NUDCantidadProducto;
        private Label LCantidad;
        private Label LStock;
        private Label LPrecioU;
        private Button BBuscarProducto;
        private Label LNomProducto;
        private TextBox TBSearch;
        private Label LProducto;
        private Label lb_nro_factura;
        private Label lb_cliente_email;
        private Label lb_cliente_nombre_razon;
        private Label lb_cliente_tel;
        private Label lb_vendedor_nombre_apellido;
        private Label lb_producto_precio;
        private Label lb_producto_titulo;
        private Label lb_producto_stock;
        private Label lb_producto_subtotal;
        private Label lb_venta_total;
    }
}