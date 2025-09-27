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
    public partial class GerenteViewUsuario : Form, IGerenteViewUsuario
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        public BindingSource UsuarioBindingSource { get; private set; }  // Nuevo: Para sincronizar controles con modelo seleccionado
        public BindingSource EstadoBindingSource { get; private set; }
        public BindingSource RolBindingSource { get; private set; }

       private void AssociateAndRaiseViewEvents()
        {
            //Buscar usuario
            btn_buscar_usuario.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); }; //al hacer clic (formulario, argumento de evento vacio)
            //con la tecla enter
            text_buscar_usuario.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Agregar nuevo usuario
            btn_guardar_usuario.Click += delegate {
                // Nuevo: Validación mínima antes de invocar eventos (evita saves inválidos)
                if (string.IsNullOrWhiteSpace(text_nombre_usuario.Text) ||
                    string.IsNullOrWhiteSpace(text_apellido_usuario.Text) ||
                    string.IsNullOrWhiteSpace(text_cuit_usuario.Text) ||
                    string.IsNullOrWhiteSpace(text_clave_usuario.Text) ||
                    cmb_estado_usuario.SelectedIndex < 0 ||
                    cmb_rol_usuario.SelectedIndex < 0)
                {
                    MessageBox.Show("Complete todos los campos obligatorios (nombre, apellido, CUIT, clave, estado, rol).",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (text_clave_usuario.Text.Length < 8)
                {
                    MessageBox.Show("La clave debe tener al menos 8 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                AddNewEvent?.Invoke(this, EventArgs.Empty); // Inicializa el objeto en el BindingSource (para nuevo)
                SaveEvent?.Invoke(this, EventArgs.Empty);   // Guarda el objeto

                // Nuevo: Muestra mensaje solo si éxito, y recarga grid
                if (!string.IsNullOrWhiteSpace(Message))
                {
                    MessageBox.Show(Message);
                    if (IsSuccessful)
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);  // Recarga grid después de éxito
                    }
                }
            };
            //editar usuario
            btn_modificar_usuario.Click += delegate {
                if (dataGridView1.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario del grid para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (!string.IsNullOrWhiteSpace(Message) && IsSuccessful)
                {
                    MessageBox.Show(Message);
                    SearchEvent?.Invoke(this, EventArgs.Empty);  // Recarga grid
                }
            };

            //eliminar usuario
            btn_eliminar_usuario.Click += delegate {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    var result = MessageBox.Show("Estas seguro de eliminar el usuario seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteEvent?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show(Message);

                    }
                }
                
            };
            dataGridView1.SelectionChanged += delegate
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                }
                    
            };
            // Text box que solo admiten letras
            text_nombre_usuario.KeyPress += TextBoxSoloLetras_KeyPress;
            text_apellido_usuario.KeyPress += TextBoxSoloLetras_KeyPress;
            // Text box que solo admiten numeros
            text_cuit_usuario.KeyPress += TextBoxSoloNumeros_KeyPress;

        }

        public GerenteViewUsuario()
        {
            InitializeComponent();
            UsuarioBindingSource = new BindingSource();  // Nuevo: Inicializa binding local
            AssociateAndRaiseViewEvents(); //asociar y generar los eventos de vistas

            // Nuevo: Carga inicial de usuarios al abrir la vista (invoca SearchEvent en Presenter)
            if (SearchEvent != null) SearchEvent(this, EventArgs.Empty);
        }
        private void TextBoxSoloNumeros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextBoxSoloLetras_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // si es: 
            //  - Espacios, caracteres especiales char.IsControl
            //  - Letras y letras con acento => char.IsLetter
            //  - Espacio => e.KeyChar == ' '
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetter(e.KeyChar)
                && e.KeyChar != ' ')
            {
                // Bloquea la tecla
                e.Handled = true;
            }
        }

        //propiedades
        public string UsuarioId
        {
            get
            {
                if (UsuarioBindingSource.Current != null)
                {
                    var usuario = (UsuarioModel)UsuarioBindingSource.Current;
                    return usuario.Id_usuario.ToString();
                }
                // Fallback al grid si no hay binding actual
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["Id_usuario"] != null)
                    return dataGridView1.CurrentRow.Cells["Id_usuario"].Value?.ToString() ?? "0";
                return "0";
            }
            set { }
        }
        public string UsuarioNombre
        {
            get
            {
                if (UsuarioBindingSource.Current != null)
                {
                    var usuario = (UsuarioModel)UsuarioBindingSource.Current;
                    return usuario.Nombre;
                }
                return text_nombre_usuario.Text;
            }
            set { text_nombre_usuario.Text = value; }
        }

        public string UsuarioApellido
        {
            get
            {
                if (UsuarioBindingSource.Current != null)
                {
                    var usuario = (UsuarioModel)UsuarioBindingSource.Current;
                    return usuario.Apellido;
                }
                return text_apellido_usuario.Text;
            }
            set { text_apellido_usuario.Text = value; }
        }

        public string Contraseña
        {
            get
            {
                if (UsuarioBindingSource.Current != null)
                {
                    var usuario = (UsuarioModel)UsuarioBindingSource.Current;
                    return usuario.ContraseñaPlana;
                }
                return text_clave_usuario.Text;
            }
            set { text_clave_usuario.Text = value; }
        }

        public string CuitUsuario
        {
            get
            {
                if (UsuarioBindingSource.Current != null)
                {
                    var usuario = (UsuarioModel)UsuarioBindingSource.Current;
                    return usuario.Cuit_usuario;
                }
                return text_cuit_usuario.Text;
            }
            set { text_cuit_usuario.Text = value; }
        }

        public string Baja
        {
            get
            {
                if (UsuarioBindingSource.Current != null)
                {
                    var usuario = (UsuarioModel)UsuarioBindingSource.Current;
                    return usuario.Baja.ToString();
                }
                return cmb_estado_usuario.SelectedValue?.ToString();
            }
            set { cmb_estado_usuario.SelectedValue = value; }
        }

        public string UsuarioIdRol
        {
            get
            {
                if (UsuarioBindingSource.Current != null)
                {
                    var usuario = (UsuarioModel)UsuarioBindingSource.Current;
                    return usuario.Id_rol.ToString();
                }
                return cmb_rol_usuario.SelectedValue?.ToString();
            }
            set { cmb_rol_usuario.SelectedValue = value; }
        }

        public string SearchValue
        {
            get { return text_buscar_usuario.Text; }
            set { text_buscar_usuario.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string NombreEstado
        {
            get { return cmb_estado_usuario.Text; }
            set { cmb_estado_usuario.Text = value; }
        }

        public string NombreRol
        {
            get { return cmb_rol_usuario.Text; }
            set { cmb_rol_usuario.Text = value; }
        }


        //Eventos
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Metodos
        public void SetUsuarioListBindingSource(BindingSource usuarioList)
        {
            UsuarioBindingSource = usuarioList;  // Asigna al binding local
            dataGridView1.DataSource = UsuarioBindingSource;
            // Nuevo: Evento para configurar columnas después del binding (ocultar + UX)
            dataGridView1.DataBindingComplete += (s, e) =>
            {
                // Ocultar columnas sensibles (Id_rol, Baja, Contraseña, etc.)
                var columnsToHide = new[] { "Id_rol", "Baja", "Contraseña", "ContraseñaPlana", "Id_usuario" };
                foreach (var colName in columnsToHide)
                {
                    if (dataGridView1.Columns[colName] != null)
                        dataGridView1.Columns[colName].Visible = false;
                }
                // Configurar headers para columnas visibles (del modelo: Nombre_estado, Nombre_rol)
                if (dataGridView1.Columns["Nombre_estado"] != null)
                    dataGridView1.Columns["Nombre_estado"].HeaderText = "Estado";
                if (dataGridView1.Columns["Nombre_rol"] != null)
                    dataGridView1.Columns["Nombre_rol"].HeaderText = "Rol";
                // Auto-ajustar columnas para mejor visualización
                dataGridView1.AutoResizeColumns();
            };
            // Nuevo: Vincular controles al BindingSource (sincroniza TextBoxes/Combos al seleccionar fila)
            VincularControles();
        }
        private void VincularControles()
        {
            // Limpiar bindings previos
            text_nombre_usuario.DataBindings.Clear();
            text_apellido_usuario.DataBindings.Clear();
            text_cuit_usuario.DataBindings.Clear();
            text_clave_usuario.DataBindings.Clear();
            cmb_estado_usuario.DataBindings.Clear();
            cmb_rol_usuario.DataBindings.Clear();
            // Agregar bindings (sincroniza con propiedades del UsuarioModel)
            text_nombre_usuario.DataBindings.Add("Text", UsuarioBindingSource, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            text_apellido_usuario.DataBindings.Add("Text", UsuarioBindingSource, "Apellido", true, DataSourceUpdateMode.OnPropertyChanged);
            text_cuit_usuario.DataBindings.Add("Text", UsuarioBindingSource, "Cuit_usuario", true, DataSourceUpdateMode.OnPropertyChanged);
            text_clave_usuario.DataBindings.Add("Text", UsuarioBindingSource, "ContraseñaPlana", true, DataSourceUpdateMode.OnPropertyChanged);  // Temporal para UI
                                                                                                                                                 // Combos: Usa SelectedValue para IDs (Baja = Id_estado, Id_rol)
            cmb_estado_usuario.DataBindings.Add("SelectedValue", UsuarioBindingSource, "Baja", true, DataSourceUpdateMode.OnPropertyChanged);
            cmb_rol_usuario.DataBindings.Add("SelectedValue", UsuarioBindingSource, "Id_rol", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void VincularControlesABindingSource()
        {
            try
            {
                // Vincular TextBoxes
                text_nombre_usuario.DataBindings.Clear();
                text_nombre_usuario.DataBindings.Add("Text", UsuarioBindingSource, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);

                text_apellido_usuario.DataBindings.Clear();
                text_apellido_usuario.DataBindings.Add("Text", UsuarioBindingSource, "Apellido", true, DataSourceUpdateMode.OnPropertyChanged);

                text_cuit_usuario.DataBindings.Clear();
                text_cuit_usuario.DataBindings.Add("Text", UsuarioBindingSource, "Cuit_usuario", true, DataSourceUpdateMode.OnPropertyChanged);

                text_clave_usuario.DataBindings.Clear();
                text_clave_usuario.DataBindings.Add("Text", UsuarioBindingSource, "ContraseñaPlana", true, DataSourceUpdateMode.OnPropertyChanged);

                // Vincular ComboBoxes
                cmb_estado_usuario.DataBindings.Clear();
                cmb_estado_usuario.DataBindings.Add("SelectedValue", UsuarioBindingSource, "Baja", true, DataSourceUpdateMode.OnPropertyChanged);

                cmb_rol_usuario.DataBindings.Clear();
                cmb_rol_usuario.DataBindings.Add("SelectedValue", UsuarioBindingSource, "Id_rol", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al vincular controles: {ex.Message}");
            }
        }
        public void LimpiarCampos()
        {
            // Limpia bindings y TextBoxes
            UsuarioBindingSource.ResetBindings(false);
            text_nombre_usuario.Text = "";
            text_apellido_usuario.Text = "";
            text_cuit_usuario.Text = "";
            text_clave_usuario.Text = "";  // Vacío para nuevo (obligatorio ingresar)
                                           // Defaults
            SetDefaultEstado("0");  // Activo (ajusta si id_estado difiere)
            SetDefaultRol("1");     // Gerente (ajusta si id_rol=2 en BD)
            IsEdit = false;
        }

        //singleton patron (abre una sola instancia del formulario) 
        private static GerenteViewUsuario instance;
        public static GerenteViewUsuario GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new GerenteViewUsuario();
                instance.MdiParent = parentConteiner; //establecer el formulario padre
                instance.FormBorderStyle = FormBorderStyle.None; //sin bordes
                instance.Dock = DockStyle.Fill; //llenar el contenedor
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)//si esta minimizado, restaurar
                {
                    instance.WindowState = FormWindowState.Normal; 
                }
                instance.BringToFront();//si ya existe, traer al frente

            } 
            return instance;
        }

        public void SetEstadoListBindingSource(BindingSource estadoList)
        {
            EstadoBindingSource = estadoList;
            cmb_estado_usuario.DataSource = EstadoBindingSource;
            cmb_estado_usuario.DisplayMember = "Nombre_estado";
            cmb_estado_usuario.ValueMember = "Id_estado";
        }

        public void SetRolListBindingSource(BindingSource rolList)
        {
            RolBindingSource = rolList;
            cmb_rol_usuario.DataSource = RolBindingSource;
            cmb_rol_usuario.DisplayMember = "Nombre_rol";
            cmb_rol_usuario.ValueMember = "Id_rol";
        }

        public void SetDefaultEstado(string estadoId)
        {
            if (cmb_estado_usuario.Items.Count > 0)
            {
                try
                {
                    cmb_estado_usuario.SelectedValue = estadoId;
                }
                catch
                {
                    // Si falla la selección por valor, seleccionar el primer item
                    if (cmb_estado_usuario.Items.Count > 0)
                        cmb_estado_usuario.SelectedIndex = 0;
                }
            }
        }

        public void SetDefaultRol(string rolId)
        {
            if (cmb_rol_usuario.Items.Count > 0)
            {
                try
                {
                    cmb_rol_usuario.SelectedValue = rolId;
                }
                catch
                {
                    // Si falla la selección por valor, seleccionar el primer item
                    if (cmb_rol_usuario.Items.Count > 0)
                        cmb_rol_usuario.SelectedIndex = 0;
                }
            }
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
