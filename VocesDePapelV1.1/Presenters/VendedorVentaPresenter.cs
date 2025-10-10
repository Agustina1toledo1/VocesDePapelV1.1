using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class VendedorVentaPresenter
    {
        private IVendedorVenta view; //campo privado para la vista usando la interfaz
        private readonly string connectionString; // Almacena la cadena de conexión

        // Constructor
        public VendedorVentaPresenter(IVendedorVenta view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;
            this.view.AddNewClienteEvent += AbrirVistaCliente;
            this.view.Show();  //mostramos la vista
        }

        private void AbrirVistaCliente(object sender, EventArgs e)
        {
            try
            {
                // Obtener el contenedor padre (MdiParent) usando la propiedad FormInstance de la interfaz
                //Form parentContainer = this.view.FormInstance;
                Form parentContainer = this.view.FormInstance.MdiParent;

                // Obtener la instancia ÚNICA de la vista de Cliente (Singleton)
                IVendedorCliente clienteView = VendedorViewCliente.GetInstance(parentContainer);

                //  Crear el Repositorio de Cliente (usando la conexión almacenada)
                IClienteRepository clienteRepository = new ClienteRepository(this.connectionString);

                //  Inicializar el Presenter de Cliente
                new VendedorClientePresenter(clienteView, clienteRepository);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la vista de clientes: {ex.Message}", "Error de Navegación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       /* private void ShowVentaView(object? sender, EventArgs e)
        {
            // Asumo que tienes la cadena de conexión almacenada en 'this.connectionString'
            string connStr = this.connectionString;
            Form parentContainer = (VendedorView)this.view; // El contenedor MDI
            // Pasar la cadena de conexión
            IVendedorVenta backupView = VentaView.GetInstance(parentContainer, connStr);

            // Pasar la conexión al VendedorVentaPresenter
            new VendedorVentaPresenter(backupView, connStr);
        }*/
    }
}
