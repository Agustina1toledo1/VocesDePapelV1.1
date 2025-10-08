using System;
using System.Configuration;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Presenters;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Views;
namespace VocesDePapelV1._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionAgus"].ConnectionString;
            bool continuar = true;
           while (continuar)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionAgus"].ConnectionString;

                // var usuarioRepository = new UsuarioStaticoRepository();
                var usuarioRepository = new UsuarioRepository(connectionString);
                var contraseniaHasher = new pbkdf2ContraseniaHasher();
                var authService = new AuthService(usuarioRepository, contraseniaHasher);

                using (var loginView = new LoginView(authService))
                {
                    if (loginView.ShowDialog() == DialogResult.OK && loginView.AutenticacionExitosa)
                    {
                        var usuario = loginView.UsuarioAutenticado;
                        RedirigirSegunRol(usuario, connectionString);
                    }
                    else
                    {
                        continuar = false;
                        Application.Exit();
                    }
                }
            }
                //IniciarAplicacion();

            //probamos el presenter de usuario
            //IGerenteViewUsuario view = new GerenteViewUsuario();
            //IUsuarioRepository repository = new UsuarioRepository(connectionString);
            //new UsuarioPresenter(view, repository);
            //Application.Run((Form)view);

            //probamos el presenter de gerente
            /*IGerenteView view = new GerenteView();
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionAgus"].ConnectionString;
            new GerentePresenter(view, connectionString);
            Application.Run((Form)view);*/
            /*probamos el presenter de administrador
            IAdministradorView view = new AdministradorView();
            new AdministradorPresenter(view, connectionString);
            Application.Run((Form)view);*/
            //probamos el presenter de vendedor
            /* IVendedorView view = new VendedorView();
             new VendedorPresenter(view, connectionString);
             Application.Run((Form)view);*/

            // dependencias para el login
            /*
            var usuarioRepository = new UsuarioRepository(connectionString);
            var contraseniaHasher = new pbkdf2ContraseniaHasher();
            var authService = new AuthService(usuarioRepository, contraseniaHasher);

           // AbrirVistaGerente(connectionString);
       // }
          //Mostrar login primero
         using (var loginView = new LoginView(authService))
         {
             if (loginView.ShowDialog() == DialogResult.OK && loginView.AutenticacionExitosa)
             {
                 var usuario = loginView.UsuarioAutenticado;

                 //  Redirigir según el rol
                 RedirigirSegunRol(usuario, connectionString);
             }
             else
             {
                 Application.Exit();
             }
         }*/

            /*probamos el login con usuario estatico
            var usuarioRepository = new UsuarioStaticoRepository();
            var contraseniaHasher = new pbkdf2ContraseniaHasher();
            var authService = new AuthService(usuarioRepository, contraseniaHasher);

            using (var loginView = new LoginView(authService))
            {
                if (loginView.ShowDialog() == DialogResult.OK && loginView.AutenticacionExitosa)
                {
                    var usuario = loginView.UsuarioAutenticado;
                    RedirigirSegunRol(usuario, connectionString);
                }
                else
                {
                    Application.Exit();
                }
            }*/
        }
        //Metodo para mostrar el login al abrir la aplicacion
        
        public static void IniciarAplicacion()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionAgus"].ConnectionString;
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection2"].ConnectionString;

            var usuarioRepository = new UsuarioRepository(connectionString);
            var contraseniaHasher = new pbkdf2ContraseniaHasher();
            var authService = new AuthService(usuarioRepository, contraseniaHasher);

            using (var loginView = new LoginView(authService))
            {
                if (loginView.ShowDialog() == DialogResult.OK && loginView.AutenticacionExitosa)
                {
                    var usuario = loginView.UsuarioAutenticado;
                    RedirigirSegunRol(usuario, connectionString);
                }
                else
                {
                    Application.Exit();
                }
            }
        }  
        
        private static void RedirigirSegunRol(UsuarioModel usuario, string connectionString)
     {
         switch (usuario.Id_rol)

         {
                case 1: // Gerente
                    AbrirVistaGerente(connectionString);
                    break;
                case 2: // Administrador
                 AbrirVistaAdministrador(connectionString);
                 break;
             
             case 3: // Vendedor
                 AbrirVistaVendedor(connectionString, usuario);
                 break;
             default:
                 MessageBox.Show($"Rol no reconocido: {usuario.Nombre_rol}");
                 break;
         }
     }

     private static void AbrirVistaAdministrador(string connectionString)
     {
          MessageBox.Show("Bienvenido Administrador");

          IAdministradorView view = new AdministradorView();
          new AdministradorPresenter(view, connectionString);
          Application.Run((Form)view);
          //((Form)view).ShowDialog();
        }

        private static void AbrirVistaGerente(string connectionString)
        {
            MessageBox.Show("Bienvenido Gerente");
            IGerenteView view = new GerenteView();
            new GerentePresenter(view, connectionString);
            Application.Run((Form)view);
            //((Form)view).ShowDialog();
        }

        private static void AbrirVistaVendedor(string connectionString, UsuarioModel usuario)
        {
            
            MessageBox.Show($"Bienvenido Vendedor: {usuario.Nombre}");
            
             IVendedorView view = new VendedorView();
             new VendedorPresenter(view, connectionString);
           Application.Run((Form)view);
           // ((Form)view).ShowDialog();
        }
    }

}