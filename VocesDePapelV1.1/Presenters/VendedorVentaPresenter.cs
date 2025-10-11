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
        private IClienteRepository clienteRepository; // Repositorio de Cliente para la busqueda
        // Constructor
        public VendedorVentaPresenter(IVendedorVenta view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;
            this.clienteRepository = new ClienteRepository(connectionString);
            this.view.AddNewClienteEvent += AbrirVistaCliente;
            this.view.SearchClienteByCuitEvent += BuscarClientePorCuit;
            this.view.ClearClienteEvent += LimpiarCliente;
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

        private void BuscarClientePorCuit(object sender, EventArgs e)
        {
            try
            {
                // VERIFICAR que el repositorio no sea null
                if (clienteRepository == null)
                {
                    MessageBox.Show("Error: Repositorio de clientes no inicializado", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cuit = view.ClienteCuit?.Trim();

                // Solo buscar si el CUIT tiene al menos 8 caracteres (para evitar búsquedas prematuras)
                if (string.IsNullOrEmpty(cuit) || cuit.Length < 8)
                {
                    LimpiarDatosCliente();
                    return;
                }

                // Buscar cliente en la base de datos
                var cliente = clienteRepository.ObtenerPorCuit(cuit);

                if (cliente != null)
                {
                    // Autocompletar los datos del cliente
                    view.ClienteNombre = cliente.Nombre_razon_social;
                    view.ClienteEmail = cliente.Email;
                    view.ClienteTelefono = cliente.Telefono;
                }
                else
                {
                    // Cliente no encontrado, limpiar campos
                    LimpiarDatosCliente();
                    MessageBox.Show("Cliente no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCliente(object sender, EventArgs e)
        {
            try
            {
                // Limpiar todos los campos del cliente
                view.ClienteNombre = string.Empty;
                view.ClienteCuit = string.Empty;
                view.ClienteEmail = string.Empty;
                view.ClienteTelefono = string.Empty;

                // Opcional: Mostrar mensaje de confirmación
                MessageBox.Show("Datos del cliente limpiados correctamente", "Información",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar datos del cliente: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarDatosCliente()
        {
            view.ClienteNombre = string.Empty;
            view.ClienteEmail = string.Empty;
            view.ClienteTelefono = string.Empty;
        }


        
    }
}
