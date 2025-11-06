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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            BtnQuitarDetalle = new Button();
            BCancelar = new Button();
            BtnGuardarVenta = new Button();
            LPrecioTotal = new Label();
            label3 = new Label();
            PFactura = new Panel();
            lb_comprobante = new Label();
            PVendedor = new Panel();
            btn_buscar_cuit_vendedor_venta = new Button();
            lb_vendedor_nombre_apellido = new Label();
            TBCuitVendedor = new TextBox();
            LNombeYApellidoV = new Label();
            LCuitVendedor = new Label();
            LVendedor = new Label();
            PCliente = new Panel();
            btn_buscar_cuit_cliente_venta = new Button();
            lb_cliente_tel = new Label();
            lb_cliente_email = new Label();
            lb_cliente_nombre_razon = new Label();
            BLimpiarCliente = new Button();
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
            dataGridViewDetalles = new DataGridView();
            PFactura.SuspendLayout();
            PVendedor.SuspendLayout();
            PCliente.SuspendLayout();
            PProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).BeginInit();
            SuspendLayout();
            // 
            // BtnQuitarDetalle
            // 
            BtnQuitarDetalle.BackColor = Color.FromArgb(255, 128, 128);
            BtnQuitarDetalle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitarDetalle.ForeColor = SystemColors.ActiveCaptionText;
            BtnQuitarDetalle.Location = new Point(804, 396);
            BtnQuitarDetalle.Margin = new Padding(0);
            BtnQuitarDetalle.Name = "BtnQuitarDetalle";
            BtnQuitarDetalle.Size = new Size(120, 38);
            BtnQuitarDetalle.TabIndex = 32;
            BtnQuitarDetalle.Text = "Quitar";
            BtnQuitarDetalle.UseVisualStyleBackColor = false;
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
            // BtnGuardarVenta
            // 
            BtnGuardarVenta.BackColor = Color.FromArgb(192, 255, 192);
            BtnGuardarVenta.Cursor = Cursors.Hand;
            BtnGuardarVenta.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BtnGuardarVenta.Location = new Point(817, 559);
            BtnGuardarVenta.Name = "BtnGuardarVenta";
            BtnGuardarVenta.Size = new Size(151, 45);
            BtnGuardarVenta.TabIndex = 30;
            BtnGuardarVenta.Text = "Guardar";
            BtnGuardarVenta.UseVisualStyleBackColor = false;
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
            // PFactura
            // 
            PFactura.Controls.Add(lb_comprobante);
            PFactura.Location = new Point(116, 36);
            PFactura.Name = "PFactura";
            PFactura.Size = new Size(233, 169);
            PFactura.TabIndex = 25;
            PFactura.Paint += this.PFactura_Paint;
            // 
            // lb_comprobante
            // 
            lb_comprobante.AutoSize = true;
            lb_comprobante.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_comprobante.Location = new Point(12, 58);
            lb_comprobante.Name = "lb_comprobante";
            lb_comprobante.Size = new Size(197, 38);
            lb_comprobante.TabIndex = 1;
            lb_comprobante.Text = "Comprobante";
            // 
            // PVendedor
            // 
            PVendedor.Controls.Add(btn_buscar_cuit_vendedor_venta);
            PVendedor.Controls.Add(lb_vendedor_nombre_apellido);
            PVendedor.Controls.Add(TBCuitVendedor);
            PVendedor.Controls.Add(LNombeYApellidoV);
            PVendedor.Controls.Add(LCuitVendedor);
            PVendedor.Controls.Add(LVendedor);
            PVendedor.Location = new Point(833, 36);
            PVendedor.Name = "PVendedor";
            PVendedor.Size = new Size(317, 169);
            PVendedor.TabIndex = 24;
            PVendedor.Paint += PVendedor_Paint;
            // 
            // btn_buscar_cuit_vendedor_venta
            // 
            btn_buscar_cuit_vendedor_venta.BackColor = SystemColors.ActiveCaption;
            btn_buscar_cuit_vendedor_venta.Image = Properties.Resources.lupa;
            btn_buscar_cuit_vendedor_venta.Location = new Point(261, 25);
            btn_buscar_cuit_vendedor_venta.Name = "btn_buscar_cuit_vendedor_venta";
            btn_buscar_cuit_vendedor_venta.Size = new Size(53, 38);
            btn_buscar_cuit_vendedor_venta.TabIndex = 58;
            btn_buscar_cuit_vendedor_venta.UseVisualStyleBackColor = false;
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
            TBCuitVendedor.Size = new Size(170, 34);
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
            PCliente.Controls.Add(btn_buscar_cuit_cliente_venta);
            PCliente.Controls.Add(lb_cliente_tel);
            PCliente.Controls.Add(lb_cliente_email);
            PCliente.Controls.Add(lb_cliente_nombre_razon);
            PCliente.Controls.Add(BLimpiarCliente);
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
            PCliente.Paint += this.PCliente_Paint;
            // 
            // btn_buscar_cuit_cliente_venta
            // 
            btn_buscar_cuit_cliente_venta.BackColor = SystemColors.ActiveCaption;
            btn_buscar_cuit_cliente_venta.Image = Properties.Resources.lupa;
            btn_buscar_cuit_cliente_venta.Location = new Point(347, 61);
            btn_buscar_cuit_cliente_venta.Name = "btn_buscar_cuit_cliente_venta";
            btn_buscar_cuit_cliente_venta.Size = new Size(53, 38);
            btn_buscar_cuit_cliente_venta.TabIndex = 57;
            btn_buscar_cuit_cliente_venta.UseVisualStyleBackColor = false;
            // 
            // lb_cliente_tel
            // 
            lb_cliente_tel.BorderStyle = BorderStyle.Fixed3D;
            lb_cliente_tel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_cliente_tel.Location = new Point(104, 133);
            lb_cliente_tel.Name = "lb_cliente_tel";
            lb_cliente_tel.Size = new Size(226, 29);
            lb_cliente_tel.TabIndex = 36;
            // 
            // lb_cliente_email
            // 
            lb_cliente_email.BorderStyle = BorderStyle.Fixed3D;
            lb_cliente_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_cliente_email.Location = new Point(104, 101);
            lb_cliente_email.Name = "lb_cliente_email";
            lb_cliente_email.Size = new Size(226, 32);
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
            BLimpiarCliente.Location = new Point(346, 115);
            BLimpiarCliente.Name = "BLimpiarCliente";
            BLimpiarCliente.Size = new Size(90, 33);
            BLimpiarCliente.TabIndex = 12;
            BLimpiarCliente.Text = "Limpiar";
            BLimpiarCliente.UseVisualStyleBackColor = false;
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
            lb_producto_subtotal.BorderStyle = BorderStyle.Fixed3D;
            lb_producto_subtotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_producto_subtotal.Location = new Point(739, 65);
            lb_producto_subtotal.Name = "lb_producto_subtotal";
            lb_producto_subtotal.Size = new Size(85, 28);
            lb_producto_subtotal.TabIndex = 39;
            // 
            // lb_producto_stock
            // 
            lb_producto_stock.BorderStyle = BorderStyle.Fixed3D;
            lb_producto_stock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_producto_stock.Location = new Point(521, 67);
            lb_producto_stock.Name = "lb_producto_stock";
            lb_producto_stock.Size = new Size(58, 28);
            lb_producto_stock.TabIndex = 38;
            // 
            // lb_producto_precio
            // 
            lb_producto_precio.BorderStyle = BorderStyle.Fixed3D;
            lb_producto_precio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_producto_precio.Location = new Point(428, 67);
            lb_producto_precio.Name = "lb_producto_precio";
            lb_producto_precio.Size = new Size(67, 28);
            lb_producto_precio.TabIndex = 37;
            // 
            // lb_producto_titulo
            // 
            lb_producto_titulo.BorderStyle = BorderStyle.Fixed3D;
            lb_producto_titulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_producto_titulo.Location = new Point(239, 68);
            lb_producto_titulo.Name = "lb_producto_titulo";
            lb_producto_titulo.Size = new Size(174, 28);
            lb_producto_titulo.TabIndex = 36;
            // 
            // LSubtotal
            // 
            LSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LSubtotal.ImageAlign = ContentAlignment.BottomCenter;
            LSubtotal.Location = new Point(717, 28);
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
            BtnAgregarDetalle.Size = new Size(114, 33);
            BtnAgregarDetalle.TabIndex = 15;
            BtnAgregarDetalle.Text = "Agregar";
            BtnAgregarDetalle.UseVisualStyleBackColor = false;
            // 
            // NUDCantidadProducto
            // 
            NUDCantidadProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NUDCantidadProducto.Location = new Point(637, 64);
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
            LCantidad.Location = new Point(613, 27);
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
            LStock.Location = new Point(502, 26);
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
            lb_venta_total.BorderStyle = BorderStyle.FixedSingle;
            lb_venta_total.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_venta_total.Location = new Point(995, 485);
            lb_venta_total.Name = "lb_venta_total";
            lb_venta_total.Size = new Size(112, 39);
            lb_venta_total.TabIndex = 40;
            lb_venta_total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewDetalles
            // 
            dataGridViewDetalles.AllowUserToAddRows = false;
            dataGridViewDetalles.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalles.Location = new Point(119, 384);
            dataGridViewDetalles.MultiSelect = false;
            dataGridViewDetalles.Name = "dataGridViewDetalles";
            dataGridViewDetalles.ReadOnly = true;
            dataGridViewDetalles.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewDetalles.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewDetalles.Size = new Size(674, 285);
            dataGridViewDetalles.TabIndex = 56;
            // 
            // VentaView2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 709);
            Controls.Add(dataGridViewDetalles);
            Controls.Add(lb_venta_total);
            Controls.Add(BtnQuitarDetalle);
            Controls.Add(BCancelar);
            Controls.Add(BtnGuardarVenta);
            Controls.Add(LPrecioTotal);
            Controls.Add(label3);
            Controls.Add(PFactura);
            Controls.Add(PVendedor);
            Controls.Add(PCliente);
            Controls.Add(PProducto);
            Name = "VentaView2";
            Text = "VentaView2";
            Load += this.VentaView2_Load;
            PFactura.ResumeLayout(false);
            PFactura.PerformLayout();
            PVendedor.ResumeLayout(false);
            PVendedor.PerformLayout();
            PCliente.ResumeLayout(false);
            PCliente.PerformLayout();
            PProducto.ResumeLayout(false);
            PProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnQuitarDetalle;
        private Button BCancelar;
        private Button BtnGuardarVenta;
        private Label LPrecioTotal;
        private Label label3;
        private Panel PFactura;
        private TextBox TBNUmFactura;
        private Label lb_comprobante;
        private DateTimePicker dateTimePicker1;
        private Panel PVendedor;
        private TextBox TBCuitVendedor;
        private Label LNombeYApellidoV;
        private Label LCuitVendedor;
        private Label LVendedor;
        private Panel PCliente;
        private Button BLimpiarCliente;
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
        private Label lb_cliente_email;
        private Label lb_cliente_nombre_razon;
        private Label lb_cliente_tel;
        private Label lb_vendedor_nombre_apellido;
        private Label lb_producto_precio;
        private Label lb_producto_titulo;
        private Label lb_producto_stock;
        private Label lb_producto_subtotal;
        private Label lb_venta_total;
        private DataGridView dataGridViewDetalles;
        private Button btn_buscar_cuit_cliente_venta;
        private Button btn_buscar_cuit_vendedor_venta;
    }
}