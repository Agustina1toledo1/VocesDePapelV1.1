using VocesDePapelV1._1.Presenters;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Repositories;
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
            //string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection2"].ConnectionString;
            //probamos el presenter de usuario
            IGerenteViewUsuario view = new GerenteViewUsuario();
            IUsuarioRepository repository = new UsuarioRepository(connectionString);
            new UsuarioPresenter(view, repository);
            //new GerentePresenter(view, connectionString);
            //Application.Run(new Views.GerenteView());
            Application.Run((Form)view);
        }
    }
}