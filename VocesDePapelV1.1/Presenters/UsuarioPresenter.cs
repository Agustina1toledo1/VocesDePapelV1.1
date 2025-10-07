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
        {
            var usuario = new UsuarioModel(); //creamos una nueva instancia del modelo de usuario
            //asignamos los valores de la vista a las propiedades del modelo            
            usuario.Id_usuario = Convert.ToInt32(view.UsuarioId);
            usuario.Nombre = view.UsuarioNombre;
            usuario.Apellido = view.UsuarioApellido;
            usuario.Cuit_usuario = view.CuitUsuario;
            usuario.Contraseña = view.Contraseña;
            usuario.Baja = Convert.ToInt32(view.Baja);
            usuario.Id_rol = Convert.ToInt32(view.UsuarioIdRol);

            //hashea si es corresponde
            if (view.Contraseña != "00000000") //si la contraseña no es "00000000"
            {
                // Hashear contraseña
                string hashedPwd = hasher.Hash(view.Contraseña);
                usuario.Contraseña = hashedPwd;
            }
            else
            {
            //si la contraseña es nula o vacia, obtenemos el usuario actual y mantenemos su contraseña
                usuario.Contraseña = view.Contraseña;
            }
            //capturamos los posible errores 
            try
            {
                //validamos el modelo
                new Common.ModelDataValidation().Validate(usuario);
                //if (view.IsEdit) //si estamos en modo edicion
                //{
                    
                    repository.Modificar(usuario); //modificamos el usuario
                    view.Message = "Usuario modificado exitosamente";
                //}
               
                view.IsSuccessful = true; 
                LoadAllUsuarioList(); //recargamos la lista de usuarios
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message =  ex.Message;
                return;

            }
        }

        private void CleanviewFields()
        {
            
            view.UsuarioNombre = "";
            view.UsuarioApellido = "";
            view.Contraseña = "00000000";
            view.CuitUsuario = "";
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

            var usuario = new UsuarioModel(); //creamos una nueva instancia del modelo de usuario
                                              //  Hashear contraseña
            string hashedPwd = hasher.Hash(view.Contraseña);
            //asignamos los valores de la vista a las propiedades del modelo y el modelo con hash en lugar de texto plano
            usuario.Id_usuario = Convert.ToInt32(view.UsuarioId);
            usuario.Nombre = view.UsuarioNombre;
            usuario.Apellido = view.UsuarioApellido;
            usuario.Contraseña = hashedPwd;
            usuario.Cuit_usuario = view.CuitUsuario;
            usuario.Baja = Convert.ToInt32(view.Baja);
            usuario.Id_rol = Convert.ToInt32(view.UsuarioIdRol);

            //capturamos los posible errores 
            try
            {
                //validamos el modelo
                new Common.ModelDataValidation().Validate(usuario);
                
                    repository.Add(usuario); //agregamos el nuevo usuario
                    view.Message = "Usuario agregado exitosamente";
                
                view.IsSuccessful = true;
                LoadAllUsuarioList(); //recargamos la lista de usuarios
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message = ex.Message;
                return;

            }
            //this.view.IsEdit = false; //establecemos la vista en modo no edicion
            //SaveUsuario(sender, e);
        }

        
    }
}
