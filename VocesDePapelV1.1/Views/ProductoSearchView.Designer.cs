namespace VocesDePapelV1._1.Views
{
    partial class ProductoSearchView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        { 
            if (disposing && (components != null))
            { 
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProductos = new DataGridView();
            btnCancelar = new Button();
            btnSeleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(79, 51);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(566, 310);
            dataGridViewProductos.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCancelar.Location = new Point(663, 177);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 45);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(192, 255, 192);
            btnSeleccionar.Cursor = Cursors.Hand;
            btnSeleccionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSeleccionar.Location = new Point(651, 132);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(137, 39);
            btnSeleccionar.TabIndex = 22;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // ProductoSearchView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnCancelar);
            Controls.Add(dataGridViewProductos);
            Name = "ProductoSearchView";
            Text = "ProductoSearchView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private Button btnCancelar;
        private Button btnSeleccionar;
    }
}