using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Views
{
    public partial class ProductoSearchView : Form, IProductoSearchView

    {
        
        private IEnumerable<ProductoModel> productos;
        public event EventHandler<ProductoSeleccionadoEventArgs> ProductoSeleccionadoEvent;

        public ProductoModel ProductoSeleccionado { get; private set; }
        public ProductoSearchView(IEnumerable<ProductoModel> productos)
        {
            InitializeComponent();
            this.productos = productos;
            CargarProductos();
            AssociateAndRaiseViewEvents();
        }


        private void CargarProductos()
        {
            dataGridViewProductos.DataSource = productos.ToList();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dataGridViewProductos.Columns.Clear();
            dataGridViewProductos.AutoGenerateColumns = false;

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id_libro",
                HeaderText = "ID",
                Width = 50,
                 ReadOnly = true
            });

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Titulo",
                HeaderText = "Título",
                Width = 200,
                ReadOnly = true
            });

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" },
                ReadOnly = true
            });

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Stock",
                HeaderText = "Stock",
                ReadOnly = true
            });

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre_categoria",
                HeaderText = "Categoría",
                ReadOnly = true
            });
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnSeleccionar.Click += (s, e) => SeleccionarProducto();

            btnCancelar.Click += (s, e) =>
            {
                ProductoSeleccionado = null;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            dataGridViewProductos.CellDoubleClick += (s, e) =>
                {
                    if (e.RowIndex >= 0)
                    {
                        SeleccionarProducto();
                    }
                };
            // Enter para seleccionar
            dataGridViewProductos.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SeleccionarProducto();
                    e.Handled = true;
                }
            };
        }
        private void SeleccionarProducto()
        {
            if (dataGridViewProductos.CurrentRow != null && dataGridViewProductos.CurrentRow.DataBoundItem is ProductoModel producto)
            {
                ProductoSeleccionado = producto;

                // Disparar evento
                ProductoSeleccionadoEvent?.Invoke(this, new ProductoSeleccionadoEventArgs(producto));

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ShowView()
        {
            this.Show();
        }

        DialogResult IProductoSearchView.ShowDialog()
        {
            return this.ShowDialog();
        }

    }
}
