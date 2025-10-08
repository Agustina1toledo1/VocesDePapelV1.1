using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class VendedorClientePresenter
    {
        private IVendedorCliente view; //campo privado para la vista usando la interfaz
        private readonly IClienteRepository repository;
        private readonly BindingSource clienteBindingSource;
        private IEnumerable<ClienteModel> clienteList;

        public VendedorClientePresenter(IVendedorCliente view, string connectionString)
        {
            this.clienteBindingSource = new BindingSource();
            this.view = view;
            this.repository = new ClienteRepository(connectionString);

            // Suscribir métodos de manejo de eventos de la vista
            this.view.SearchEvent += SearchCliente;
            this.view.AddNewEvent += AddNewCliente;
            this.view.EditEvent += EditCliente;
            this.view.DeleteEvent += DeleteCliente;
            this.view.SaveEvent += SaveCliente;
            this.view.CancelEvent += CancelAction;

            // Establecer el enlace de datos
            this.view.SetClienteListBindingSource(clienteBindingSource);

            // Cargar la lista de clientes al iniciar
            LoadAllClienteList();

            // Mostrar la vista
            this.view.Show();
        }

        // --- Métodos de Ayuda ---

        private void LoadAllClienteList()
        {
            clienteList = repository.GetAll();
            clienteBindingSource.DataSource = clienteList; // Actualiza el DataGridView
        }

        private void CleanViewFields()
        {
            view.ClienteId = "0";
            view.NombreRazonSocial = string.Empty;
            view.CuitCuil = string.Empty;
            view.Telefono = string.Empty;
            view.Email = string.Empty;
        }

        private ClienteModel GetClienteDataFromView()
        {
            // Parsea el ID solo si la vista está en modo edición y tiene un valor válido.
            int id = 0;
            if (view.IsEdit && int.TryParse(view.ClienteId, out int parsedId))
            {
                id = parsedId;
            }

            return new ClienteModel
            {
                Id_cliente = id,
                Nombre_razonSocial = view.NombreRazonSocial,
                Cuit_cuil = view.CuitCuil,
                Telefono = view.Telefono,
                Email = view.Email
            };
        }

        // --- Métodos de Manejo de Eventos (Lógica del CRUD) ---

        private void SearchCliente(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.view.SearchValue))
            {
                LoadAllClienteList();
            }
            else
            {
                clienteList = repository.GetByValue(this.view.SearchValue);
                clienteBindingSource.DataSource = clienteList;
            }
        }

        private void AddNewCliente(object sender, EventArgs e)
        {
            view.IsEdit = false;
            CleanViewFields();
        }

        private void EditCliente(object sender, EventArgs e)
        {
            if (clienteBindingSource.Current != null)
            {
                view.IsEdit = true;
                // Obtener el cliente seleccionado en el DataGridView
                var cliente = (ClienteModel)clienteBindingSource.Current;

                // Cargar datos del cliente en los campos de la vista para edición
                view.ClienteId = cliente.Id_cliente.ToString();
                view.NombreRazonSocial = cliente.Nombre_razonSocial;
                view.CuitCuil = cliente.Cuit_cuil;
                view.Telefono = cliente.Telefono;
                view.Email = cliente.Email;
            }
        }

        private void DeleteCliente(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Current != null)
                {
                    var cliente = (ClienteModel)clienteBindingSource.Current;
                    repository.Delete(cliente.Id_cliente);
                    view.IsSuccessful = true;
                    view.Message = "Cliente eliminado exitosamente.";
                    LoadAllClienteList(); // Recargar la lista
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error al eliminar el cliente: " + ex.Message;
            }
        }

        private void SaveCliente(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener y validar los datos
                var cliente = GetClienteDataFromView();
                new Common.ModelDataValidation().Validate(cliente);

                // 2. Determinar la operación (Add o Edit)
                if (view.IsEdit)
                {
                    repository.Edit(cliente);
                    view.Message = "Cliente modificado exitosamente.";
                }
                else
                {
                    repository.Add(cliente);
                    view.Message = "Cliente agregado exitosamente.";
                }
                view.IsSuccessful = true;
                LoadAllClienteList(); // Recargar la lista
                CleanViewFields(); // Limpiar campos después de guardar
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                // Muestra el error de validación o de base de datos
                view.Message = ex.Message;
            }
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
            view.IsEdit = false; // Vuelve al modo "agregar" por defecto
        }
    }
    
}
