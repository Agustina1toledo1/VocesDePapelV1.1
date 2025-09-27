using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Repositories;
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
            foreach (var usuario in usuarioList)
            {
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == usuario.Baja);
                var rol = rolList.FirstOrDefault(r => r.Id_rol == usuario.Id_rol);

                usuario.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
                usuario.Nombre_rol = rol?.Nombre_rol ?? "Desconocido";
            }
            usuarioBindingSource.DataSource = usuarioList; //establecemos la lista de usuarios como el origen de datos del enlace
            
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
            foreach (var usuario in usuarioList)
            {
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == usuario.Baja);
                var rol = rolList.FirstOrDefault(r => r.Id_rol == usuario.Id_rol);

                usuario.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
                usuario.Nombre_rol = rol?.Nombre_rol ?? "Desconocido";
            }
            //actualizamos el origen de datos del enlace
            usuarioBindingSource.DataSource = usuarioList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveUsuario(object? sender, EventArgs e)
        {   // copia al objeto 'usuario' actual antes de guardarlo.
            usuarioBindingSource.EndEdit();
            // Obtiene el objeto del BindingSource (el nuevo registro o el que se está editando).
            var usuario = (UsuarioModel)usuarioBindingSource.Current;
            // Validación básica de campos clave antes de continuar
            if (string.IsNullOrWhiteSpace(usuario.Cuit_usuario) || string.IsNullOrWhiteSpace(usuario.Nombre))
            {
                usuarioBindingSource.CancelEdit(); // Cancela la edición si faltan datos
                view.IsSuccessful = false;
                view.Message = "El CUIT y el Nombre son obligatorios.";
                return;
            }
            // Lógica para manejar la Contraseña (FIX DE EDICIÓN)
            if (view.Contraseña != "00000000") // Si el usuario escribió una nueva contraseña
            {
                // Hashear contraseña nueva
                string hashedPwd = hasher.Hash(view.Contraseña);
                usuario.Contraseña = hashedPwd;
            }
            else // Si la contraseña es "00000000" (modo edición sin cambio de clave)
            {
                // Obtener el objeto original de la base de datos para mantener el hash existente.
                var usuarioOriginal = repository.ObtenerPorCuit(usuario.Cuit_usuario);

                if (usuarioOriginal != null)
                {
                    usuario.Contraseña = usuarioOriginal.Contraseña;
                }
                else
                {
                    // Esto solo debería ocurrir si se intenta editar un CUIT que no existe.
                    usuario.Contraseña = view.Contraseña; // Mantiene el "00000000", fallará la validación, lo cual es correcto.
                }
            }

            //  Bloque Try-Catch para validar y persistir
            try
            {
                // Validamos el modelo (el objeto 'usuario' ya contiene la contraseña hasheada o el hash original).
                new Common.ModelDataValidation().Validate(usuario);

                // Si el ID es 0, es un nuevo registro, si es diferente, es una modificación.
                if (usuario.Id_usuario == 0)
                {
                    // Se asume que el usuario ya tiene todos los campos de la vista asignados, 
                    // ya que se usa usuarioBindingSource.Current.
                    repository.Add(usuario);
                    view.Message = "Usuario agregado exitosamente";
                }
                else
                {
                    // Modificación
                    repository.Modificar(usuario);
                    view.Message = "Usuario modificado exitosamente";
                }

                view.IsSuccessful = true;
                LoadAllUsuarioList(); // Recargamos la lista
                CleanviewFields(); // Limpiamos campos después de guardar o volvemos al primer elemento.
            }
            catch (Exception ex)
            {
                // Cancelamos la adición pendiente en el BindingSource si falló el guardado.
                usuarioBindingSource.CancelEdit();
                this.view.IsSuccessful = false;
                this.view.Message = "Error al guardar: " + ex.Message;
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
             view.Contraseña = "00000000";
             view.CuitUsuario = usuario.Cuit_usuario;
             view.NombreEstado = usuario.Nombre_estado;
             view.NombreRol = usuario.Nombre_rol;
             this.view.IsEdit = true; //establecemos la vista en modo edicion
        }

        private void AddNewUsuario(object? sender, EventArgs e)
        {
            /// Inicia un nuevo registro en el BindingSource.
            usuarioBindingSource.AddNew();

            // Asegura que la vista se comporte como 'Agregar' (por si IsEdit se usa en la vista).
            this.view.IsEdit = false;

            // Limpia los campos de texto para que el gerente ingrese el nuevo usuario.
            CleanviewFields();
        
        
        }
      

    }
}
