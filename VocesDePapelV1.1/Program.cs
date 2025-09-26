using VocesDePapelV1._1.Presenters;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Models;
using System.Configuration;
using System;
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
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            //probamos el presenter de usuario
            //IGerenteViewUsuario view = new GerenteViewUsuario();
            //IUsuarioRepository repository = new UsuarioRepository(connectionString);
            //new UsuarioPresenter(view, repository);
            //Application.Run((Form)view);

            //probamos el presenter de gerente
            IGerenteView view = new GerenteView();
            new GerentePresenter(view, connectionString);
            Application.Run((Form)view);
        }
    }
}