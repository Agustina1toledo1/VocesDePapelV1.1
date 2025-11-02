namespace VocesDePapelV1._1.Views
{
    partial class ProductoSearchView2
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
            dtg_productoSearch = new DataGridView();
            btn_seleccionar_productoSearch = new Button();
            btn_cancelar_productoSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_productoSearch).BeginInit();
            SuspendLayout();
            // 
            // dtg_productoSearch
            // 
            dtg_productoSearch.BackgroundColor = SystemColors.ActiveBorder;
            dtg_productoSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_productoSearch.Location = new Point(75, 60);
            dtg_productoSearch.MultiSelect = false;
            dtg_productoSearch.Name = "dtg_productoSearch";
            dtg_productoSearch.ReadOnly = true;
            dtg_productoSearch.RowHeadersWidth = 51;
            dtg_productoSearch.Size = new Size(799, 436);
            dtg_productoSearch.TabIndex = 1;
            // 
            // btn_seleccionar_productoSearch
            // 
            btn_seleccionar_productoSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_seleccionar_productoSearch.Location = new Point(898, 90);
            btn_seleccionar_productoSearch.Name = "btn_seleccionar_productoSearch";
            btn_seleccionar_productoSearch.Size = new Size(122, 37);
            btn_seleccionar_productoSearch.TabIndex = 2;
            btn_seleccionar_productoSearch.Text = "Seleccionar";
            btn_seleccionar_productoSearch.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar_productoSearch
            // 
            btn_cancelar_productoSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar_productoSearch.Location = new Point(898, 133);
            btn_cancelar_productoSearch.Name = "btn_cancelar_productoSearch";
            btn_cancelar_productoSearch.Size = new Size(122, 37);
            btn_cancelar_productoSearch.TabIndex = 3;
            btn_cancelar_productoSearch.Text = "Cancelar";
            btn_cancelar_productoSearch.UseVisualStyleBackColor = true;
            // 
            // ProductoSearchView2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1138, 666);
            Controls.Add(btn_cancelar_productoSearch);
            Controls.Add(btn_seleccionar_productoSearch);
            Controls.Add(dtg_productoSearch);
            Name = "ProductoSearchView2";
            Text = "ProductoSearchView2";
            ((System.ComponentModel.ISupportInitialize)dtg_productoSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_productoSearch;
        private Button btn_seleccionar_productoSearch;
        private Button btn_cancelar_productoSearch;
    }
}