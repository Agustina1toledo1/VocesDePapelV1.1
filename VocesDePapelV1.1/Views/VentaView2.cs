using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Views
{
    public partial class VentaView2 : Form, IVentaView2
    {
        private string message;
        private bool isSuccessful;
        private string idCliente;
        private string idVendedor;
        private string idProducto;
        public string Cantidad => NUDCantidadProducto.Value.ToString();


        public VentaView2()
        {
            InitializeComponent();
            this.AutoScroll = true;
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            TBCuilCuit.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchClienteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            TBCuitVendedor.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchVendedorEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            //Buscar producto
            BBuscarProducto.Click += delegate
            {
                SearchProductoEvent?.Invoke(this, EventArgs.Empty);
                
            };
            TBSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchProductoEvent?.Invoke(this, EventArgs.Empty);
                    
                }
            };
            NUDCantidadProducto.ValueChanged += (s, e) =>
            {
                CalculateSubtotalEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public VentaCabeceraModel2 VentaCabecera
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public VentaDetalleModel2 VentaDetalleActual
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public ProductoModel ProductoActual
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string Id_venta_cabecera
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string Fecha_hora_venta
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string Total_venta
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string Id_cliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string Id_usuario
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }
        public string Id_estado
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string Cliente_nombre
        {
            get { return lb_cliente_nombre_razon.Text; }
            set { lb_cliente_nombre_razon.Text = value; }
        }
        public string Cliente_cuit
        {
            get { return TBCuilCuit.Text; }
            set { TBCuilCuit.Text = value; }
        }
        public string Cliente_email
        {
            get { return lb_cliente_email.Text; }
            set { lb_cliente_email.Text = value; }
        }
        public string Cliente_telefono
        {
            get { return lb_cliente_tel.Text; }
            set { lb_cliente_tel.Text = value; }
        }
        public string Vendedor_nombre
        {
            get { return lb_vendedor_nombre_apellido.Text; }
            set { lb_vendedor_nombre_apellido.Text = value; }
        }
        public string Vendedor_cuit
        {
            get { return TBCuitVendedor.Text; }
            set { TBCuitVendedor.Text = value; }
        }
        public string Estado_nombre
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Id_venta_detalle
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string Id_producto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
       
        public string Precio_unitario
        {
            get { return lb_producto_precio.Text; }
        }
        public string Subtotal
        {
            get { return lb_producto_subtotal.Text; }
            set { lb_producto_subtotal.Text = value; }
        }
        public string Producto_nombre
        {
            get { return lb_producto_titulo.Text; }
            set { lb_producto_titulo.Text = value; }
        }
        public string Producto_stock
        {
            get { return lb_producto_stock.Text; }
        }
        public string SearchValue
        {
            get { return TBSearch.Text; }
            set { TBSearch.Text = value; }
        }

        public event EventHandler SearchClienteEvent;
        public event EventHandler SearchVendedorEvent;
        public event EventHandler SearchProductoEvent;
        public event EventHandler AddNewDetalleEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler SaveEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler DeleteAllEvent;
        public event EventHandler CancelEvent;
        public event EventHandler CancelAllEvent;
        public event EventHandler CalculateSubtotalEvent;

        //singleton patron (abre una sola instancia del formulario) 
        private static VentaView2 instance;

        public static VentaView2 GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new VentaView2();
                instance.MdiParent = parentConteiner; //establecer el formulario padre
                instance.FormBorderStyle = FormBorderStyle.None; //sin bordes
                instance.Dock = DockStyle.Fill; //llenar el contenedor
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)//si esta minimizado, restaurar
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();//si ya existe, traer al frente

            }
            return instance;
        }
        public void SetVentaDetalleListBindingSource(object ventaDetalleList)
        {
            dataGridViewDetalles.DataSource = ventaDetalleList;
        }

       
    }
}
