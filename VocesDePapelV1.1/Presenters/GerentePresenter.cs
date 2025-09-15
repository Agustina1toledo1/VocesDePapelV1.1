using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;

namespace VocesDePapelV1._1.Presenters
{
    public class GerentePresenter
    {
        private IGerenteView view;
        //un campo de solo lectura para la cadena de conexion
        private readonly string connectionString;

        public GerentePresenter(IGerenteView view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;

            //suscribirse a los eventos de la vista
            this.view.ShowUsuarioView += ShowUsuariosView;

        }
        //mostrar vista de usuario
        private void ShowUsuariosView(object? sender, EventArgs e)
        {
            IGerenteViewUsuario view = new GerenteViewUsuario();
            IUsuarioRepository repository = new UsuarioRepository(connectionString);
            new UsuarioPresenter(view, repository);
        }
    }
}
