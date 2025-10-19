using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Views
{
    public partial class AdministradorViewProducto : Form, IAdministradorViewProducto
    {
        private string message;
        private bool isSuccessful;
        public AdministradorViewProducto()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

        }

        private void AssociateAndRaiseViewEvents()
        {
            AddSearchItems(new string[] { "Titulo", "Categoria" });
            btn_registrar_usuario.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            //buscar producto
            btn_buscar_producto.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            text_buscar_producto.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //eliminar producto
            btn_eliminar_producto.Click += delegate
            {
                if (dataGridProducto.SelectedCells.Count > 0)
                {
                    var result = MessageBox.Show("Estas seguro de eliminar el producto seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteEvent?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show(Message);
                    }
                }
            };
            //modificar producto
            btn_modificar_producto.Click += delegate
            {
                if (dataGridProducto.SelectedCells.Count > 0)
                {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            //mostrar datos en los textbox al seleccionar una fila del datagrid
            dataGridProducto.SelectionChanged += delegate
            {
               if (dataGridProducto.SelectedCells.Count > 0)
               {
                    EditEvent?.Invoke(this, EventArgs.Empty);
               }
               else
               {
                    CancelEvent?.Invoke(this, EventArgs.Empty);
               }
            };
            //limpiar campos 
            btn_limpiar_producto.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
            };

            text_precio_admin.KeyPress += TextBoxSoloNumerosDecimales_KeyPress;
            text_stock_admin.KeyPress += TextBoxSoloNumeros_KeyPress;
        }
        
        public string ProductoId {
            get
            {
                if (dataGridProducto.CurrentRow != null)
                    return dataGridProducto.CurrentRow.Cells["Id_libro"].Value?.ToString();
                return "0";
            } //ver que pasa con esto
            set { }
        }
        public string ProductoTitulo {
            get { return text_titulo_admin.Text; }
            set { text_titulo_admin.Text = value; }
        }
        public string ProductoEditorial {
            get { return text_editorial_admin.Text; }
            set { text_editorial_admin.Text = value; }
        }
        public string ProductoPrecio {
            get { return text_precio_admin.Text; }
            set { text_precio_admin.Text = value; }
        }
        public string ProductoStock {
            get { return text_stock_admin.Text; }
            set { text_stock_admin.Text = value; }
        }
        public string ProductoEliminado {
            get { return cmb_estado_producto.SelectedValue?.ToString(); }
            set { cmb_estado_producto.SelectedValue = value; }
        }
        public string ProductoNombreEstado {
            get { return cmb_estado_producto.Text; }
            set { cmb_estado_producto.Text = value; }
        }
        public string ProductoIdCategoria {
            get { return cmb_categoria_producto.SelectedValue?.ToString(); }
            set { cmb_categoria_producto.SelectedValue = value; }
        }
        public string ProductoNombreCategoria {
            get { return cmb_categoria_producto.Text; }
            set { cmb_categoria_producto.Text = value; }
        }
        public string SearchValue {
            get { return text_buscar_producto.Text; }
            set { text_buscar_producto.Text = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string SearchBy {
            get { return cmb_buscar_por_producto.Text; }
            set { cmb_buscar_por_producto.Text = value; }
        }

        public string ProductoIdAutor {
            get { return cmb_autor.SelectedValue?.ToString(); }
            set { cmb_autor.SelectedValue = value; }
        }
        public string ProductoNombreAutor {
            get { return cmb_autor.Text; }
            set { cmb_autor.Text = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //singleton patron (abre una sola instancia del formulario) 
        private static AdministradorViewProducto instance;

        public static AdministradorViewProducto GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new AdministradorViewProducto();
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
        private void TextBoxSoloNumerosDecimales_KeyPress(object? sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;

            // Permitir teclas de control (como backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir una sola coma, y no como primer carácter
            if (e.KeyChar == ',' && textBox != null && !textBox.Text.Contains(",") && textBox.Text.Length > 0)
                return;

            // Bloquear todo lo demás
            e.Handled = true;
        }

        private void TextBoxSoloNumeros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
        public void SetProductoListBindingSource(object productoList)
        {
            dataGridProducto.DataSource = productoList;
            //ocultar columnas no necesarias
            dataGridProducto.Columns["Id_categoria"].Visible = false;
            dataGridProducto.Columns["Eliminado_id"].Visible = false;
            dataGridProducto.Columns["Id_autor"].Visible = false;
        }

        public void SetCategoriaListBindingSource(object categoriaList)
        {
           
            cmb_categoria_producto.DataSource = categoriaList;
            cmb_categoria_producto.DisplayMember = "Nombre_categoria";
            cmb_categoria_producto.ValueMember = "Id_categoria";
        }

        public void SetEstadoListBindingSource(object estadoList)
        {
            cmb_estado_producto.DataSource = estadoList;
            cmb_estado_producto.DisplayMember = "Nombre_estado";
            cmb_estado_producto.ValueMember = "Id_estado";
        }
        public void SetAutorListBindingSource(object autorList)
        {
            cmb_autor.DataSource = autorList;
            cmb_autor.DisplayMember = "Alias_autor";
            cmb_autor.ValueMember = "Id_autor";
        }
        //metodo para agregar los items al combobox de buscar 
        public void AddSearchItems(string[] items)
        {

            cmb_buscar_por_producto.Items.Clear();
            cmb_buscar_por_producto.Items.AddRange(items);
            cmb_buscar_por_producto.SelectedIndex = 0; //seleccionar el primer item por defecto
        }
    }
}
