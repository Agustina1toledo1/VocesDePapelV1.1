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
    public partial class ProductoSearchView : Form
    {
        public ProductoModel ProductoSeleccionado { get; private set; }
        private IEnumerable<ProductoModel> productos;

        public ProductoSearchView(IEnumerable<ProductoModel> productos)
        {
            InitializeComponent();
            this.productos = productos;
            CargarProductos();
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
                Width = 50
            });

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Titulo",
                HeaderText = "Título",
                Width = 200
            });

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Stock",
                HeaderText = "Stock"
            });
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                ProductoSeleccionado = (ProductoModel)dataGridViewProductos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSeleccionar_Click(sender, e);
            }
        }
    }
}
