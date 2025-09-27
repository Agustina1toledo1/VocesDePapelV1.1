using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Presenters.Common;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Views;
namespace VocesDePapelV1._1.Presenters
{
    public class UsuarioPresenter 
    {
        //campos        
        private IGerenteViewUsuario view; //campo privado para la vista usando la interfaz
        private IUsuarioRepository repository; //campo privado para el repositorio usando la interfaz
        private IContraseniaHasher hasher; //campo privado para el hasher usando la interfaz
        private BindingSource usuarioBindingSource; //origen de datos para el enlace
        private BindingSource estadoBindingSource; //origen de datos para el enlace
        private BindingSource rolBindingSource; //origen de datos para el enlace
        private IEnumerable<UsuarioModel> usuarioList; //lista de usuarios
        private IEnumerable<RolModel> rolList;
        private IEnumerable<EstadoModel> estadoList;
        //constructor
        public UsuarioPresenter(IGerenteViewUsuario view, IUsuarioRepository repository, IContraseniaHasher hasher)
        {
            //inicializamos los campos
            this.usuarioBindingSource = new BindingSource();
            this.estadoBindingSource = new BindingSource();
            this.rolBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.hasher = hasher;
            //Suscribimos los eventos del controlador a los eventos de la vista
            this.view.SearchEvent += SearchUsuario;
            this.view.AddNewEvent += AddNewUsuario;
            this.view.EditEvent += EditUsuario;
            this.view.DeleteEvent += DeleteUsuario;
            this.view.SaveEvent += SaveUsuario;
            this.view.CancelEvent += CancelAction; //no se si es necesario
            
            //cargar los datos de rol y estado 
            CargarAllRol();
            CargarAllEstado();
            //cargamos los datos de usuario a  la lista de usuarios
            LoadAllUsuarioList();
            //Establecemos el origen de datos del enlace, fuente vinculante
            this.view.SetUsuarioListBindingSource(usuarioBindingSource);
            this.view.SetEstadoListBindingSource(estadoBindingSource);
            this.view.SetRolListBindingSource(rolBindingSource);
            // Establecer defaults después de poblar combos
            this.view.SetDefaultEstado("0");  // Activo por defecto
            this.view.SetDefaultRol("1");     // Gerente por defecto (ajusta si BD usa id=2)
            //mostramos la vista
            this.view.Show();
        

        }

        private void CargarAllEstado()
        {
            estadoList = repository.GetEstado();
            estadoBindingSource.DataSource = estadoList; //establecemos la lista de estados como el origen de datos del enlace
        }

        private void CargarAllRol()
        {
            rolList = repository.GetRol(); //obtenemos todos los usuarios del repositorio
            rolBindingSource.DataSource = rolList; //establecemos la lista de roles como el origen de datos del enlace
        }

        private void LoadAllUsuarioList()
        {
            usuarioList = repository.GetAll(); //obtenemos todos los usuarios del repositorio
                                               //Si listas de estado/rol están vacías (BD sin datos), usa defaults para evitar "Desconocido"
            if (!estadoList.Any())
            {
                estadoList = new List<EstadoModel>
    {
        new EstadoModel { Id_estado = 0, Nombre_estado = "Activo" },
        new EstadoModel { Id_estado = 1, Nombre_estado = "Inactivo" }
    };
            }
            if (!rolList.Any())
            {
                rolList = new List<RolModel>
    {
        new RolModel { Id_rol = 1, Nombre_rol = "Gerente" }
        // Agrega más si hay otros roles, e.g., {2, "Vendedor"}
    };
            }
            foreach (var usuario in usuarioList)
            {
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == usuario.Baja);
                var rol = rolList.FirstOrDefault(r => r.Id_rol == usuario.Id_rol);

                usuario.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
                usuario.Nombre_rol = rol?.Nombre_rol ?? "Desconocido";
            }
            usuarioBindingSource.DataSource = usuarioList; //establecemos la lista de usuarios como el origen de datos del enlace

            usuarioBindingSource.ResetBindings(false);//  Refresca binding para actualizar vista
        }
        

        private void SearchUsuario(object? sender, EventArgs e)
        {
            //si es vacio, nulo, espacio en blanco
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if(emptyValue == false) //si no es vacio
            {
                usuarioList = repository.GetByValue(this.view.SearchValue); //obtenemos los usuarios que coinciden con el valor de busqueda
            }
            else
            {
                usuarioList = repository.GetAll(); //si es vacio, obtenemos todos los usuarios
            }
            // Mismo fallback para listas vacías en búsqueda
            if (!estadoList.Any())
            {
                 estadoList = new List<EstadoModel>
                {
                    new EstadoModel { Id_estado = 0, Nombre_estado = "Activo" },
                    new EstadoModel { Id_estado = 1, Nombre_estado = "Inactivo" }
                };
              }
            if (!rolList.Any())
                {
                  rolList = new List<RolModel>
                {
                    new RolModel { Id_rol = 1, Nombre_rol = "Gerente" }
                };
            }
            foreach (var usuario in usuarioList)
            {
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == usuario.Baja);
                var rol = rolList.FirstOrDefault(r => r.Id_rol == usuario.Id_rol);

                usuario.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
                usuario.Nombre_rol = rol?.Nombre_rol ?? "Desconocido";
            }
            //actualizamos el origen de datos del enlace
            usuarioBindingSource.DataSource = usuarioList;
            // Refresca binding
            usuarioBindingSource.ResetBindings(false);
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveUsuario(object? sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            // Obtiene el objeto actual del BindingSource (nuevo o editando)
            var usuario = (UsuarioModel)usuarioBindingSource.Current;
            // Asigna valores de la vista al modelo (binding ya ayuda, pero asegura)
            usuario.Nombre = view.UsuarioNombre;
            usuario.Apellido = view.UsuarioApellido;
            usuario.Cuit_usuario = view.CuitUsuario;
            usuario.ContraseñaPlana = view.Contraseña;  // Temporal para validación
                                                        // Parsea valores de combos (Baja y Id_rol)
            int baja = 0;
            int.TryParse(view.Baja, out baja);
            usuario.Baja = baja;
            int idRol = 1;  // Default gerente
            int.TryParse(view.UsuarioIdRol, out idRol);
            usuario.Id_rol = idRol;
            // Nueva Lógica Simplificada para Contraseña (sin sentinel "00000000")
            string contrasenaPlana = view.Contraseña;  // Declaración corregida: captura de vista
            if (string.IsNullOrEmpty(contrasenaPlana) && view.IsEdit)  // Edición: no cambiar clave (mantener hash viejo)
            {
                // Recupera hash original de BD vía CUIT (no expone plano)
                var usuarioOriginal = repository.ObtenerPorCuit(usuario.Cuit_usuario);
                if (usuarioOriginal != null)
                {
                    usuario.Contraseña = usuarioOriginal.Contraseña;  // Hash existente
                }
                else
                {
                    // Falla si CUIT no existe (e.g., cambió CUIT sin clave nueva)
                    throw new InvalidOperationException("No se pudo recuperar el usuario original. Ingrese una nueva contraseña.");
                }
            }
            else  // Nuevo usuario o cambio de clave: obligatoria y hasheada
            {
                if (string.IsNullOrEmpty(contrasenaPlana))
                {
                    throw new InvalidOperationException("La contraseña es obligatoria para nuevos usuarios o cambios.");
                }
                // Hashea la nueva contraseña
                string hashedPwd = hasher.Hash(contrasenaPlana);
                usuario.Contraseña = hashedPwd;
            }
            // Bloque Try-Catch para validar y persistir
            try
            {
                // Valida el modelo completo (incluyendo DataAnnotations y Contraseña hasheada)
                new VocesDePapelV1._1.Presenters.Common.ModelDataValidation().Validate(usuario);  // Corrige namespace si es "Common"
                                                                                                  // Determina acción: nuevo o modificar
                if (usuario.Id_usuario == 0)
                {
                    repository.Add(usuario);
                    view.Message = "Usuario agregado exitosamente.";
                }
                else
                {
                    repository.Modificar(usuario);
                    view.Message = "Usuario modificado exitosamente.";
                }
                view.IsSuccessful = true;
                // Post-éxito: Recarga lista y limpia campos
                LoadAllUsuarioList();  // Recarga grid
                this.view.LimpiarCampos();  // Limpia vista (nuevo método)
            }
            catch (Exception ex)
            {
                // Cancela edición si falla
                usuarioBindingSource.CancelEdit();
                view.IsSuccessful = false;
                view.Message = "Error al guardar usuario: " + ex.Message;
                // Opcional: Limpia en error para resetear UX
                this.view.LimpiarCampos();
            }
        }

        private void CleanviewFields()
        {
            view.UsuarioNombre = "";
            view.UsuarioApellido = "";
            view.Contraseña = ""; // Dejar vacío en lugar de "00000000"
            view.CuitUsuario = "";

            // Usar los nuevos métodos de la interfaz
            view.SetDefaultEstado("0"); // Activo por defecto
            view.SetDefaultRol("2"); // Gerente por defecto
        }

        private void DeleteUsuario(object? sender, EventArgs e)
        {
            try
            {
                var usuario = (UsuarioModel)usuarioBindingSource.Current; //obtenemos el usuario actual del origen de datos del enlace
                repository.Eliminar(usuario.Id_usuario); //eliminamos el usuario
                view.IsSuccessful = true;
                view.Message = "Usuario eliminado exitosamente";
                LoadAllUsuarioList(); //recargamos la lista de usuarios
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error al eliminar el usuario. " + ex.Message;
            }
        }

        private void EditUsuario(object? sender, EventArgs e)
        {
            var usuario = (UsuarioModel)usuarioBindingSource.Current; //obtenemos el usuario actual del origen de datos del enlace
            //asignamos los valores de la vista a las propiedades del modelo
            
             view.UsuarioId = usuario.Id_usuario.ToString();
             view.UsuarioNombre = usuario.Nombre;
             view.UsuarioApellido = usuario.Apellido;
            view.Contraseña = "";  // Vacío: obliga ingresar nueva si se cambia (Save maneja si vacío = mantener hash)
            view.CuitUsuario = usuario.Cuit_usuario;
             view.NombreEstado = usuario.Nombre_estado;
             view.NombreRol = usuario.Nombre_rol;
             this.view.IsEdit = true; //establecemos la vista en modo edicion
        }

        private void AddNewUsuario(object? sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();

            var nuevoUsuario = (UsuarioModel)usuarioBindingSource.Current;

            nuevoUsuario.Nombre = view.UsuarioNombre;
            nuevoUsuario.Apellido = view.UsuarioApellido;
            nuevoUsuario.Cuit_usuario = view.CuitUsuario;

            // Validación segura para campos numéricos
            int baja = 0;
            if (!int.TryParse(view.Baja, out baja))
            {
                view.IsSuccessful = false;
                view.Message = "Debe seleccionar un estado válido.";
                return;
            }

            int idRol = 1;
            if (!int.TryParse(view.UsuarioIdRol, out idRol))
            {
                view.IsSuccessful = false;
                view.Message = "Debe seleccionar un rol válido.";
                return;
            }

            nuevoUsuario.Baja = baja;    // Puede ser 0 (activo)
            nuevoUsuario.Id_rol = idRol;
            nuevoUsuario.Nombre = view.UsuarioNombre;
            nuevoUsuario.Apellido = view.UsuarioApellido;
            nuevoUsuario.Cuit_usuario = view.CuitUsuario;
            nuevoUsuario.ContraseñaPlana = view.Contraseña;  // Para validación en Save
            // Defaults ya validados en vista
            nuevoUsuario.Baja = 0;  // Activo
            nuevoUsuario.Id_rol = 1;  // Gerente
            this.view.IsEdit = false;


            nuevoUsuario.ContraseñaPlana = view.Contraseña;

            this.view.IsEdit = false;
        }


    }
}
