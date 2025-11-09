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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_seleccionar_productoSearch = new Button();
            btn_cancelar_productoSearch = new Button();
            dtg_productoSearch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_productoSearch).BeginInit();
            SuspendLayout();
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
            btn_cancelar_productoSearch.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar_productoSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar_productoSearch.Location = new Point(898, 133);
            btn_cancelar_productoSearch.Name = "btn_cancelar_productoSearch";
            btn_cancelar_productoSearch.Size = new Size(122, 37);
            btn_cancelar_productoSearch.TabIndex = 3;
            btn_cancelar_productoSearch.Text = "Cancelar";
            btn_cancelar_productoSearch.UseVisualStyleBackColor = false;
            btn_cancelar_productoSearch.Click += btn_cancelar_productoSearch_Click;
            // 
            // dtg_productoSearch
            // 
            dtg_productoSearch.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_productoSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_productoSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_productoSearch.Location = new Point(82, 50);
            dtg_productoSearch.MultiSelect = false;
            dtg_productoSearch.Name = "dtg_productoSearch";
            dtg_productoSearch.ReadOnly = true;
            dtg_productoSearch.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dtg_productoSearch.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtg_productoSearch.Size = new Size(796, 433);
            dtg_productoSearch.TabIndex = 57;
            // 
            // ProductoSearchView2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1138, 666);
            Controls.Add(dtg_productoSearch);
            Controls.Add(btn_cancelar_productoSearch);
            Controls.Add(btn_seleccionar_productoSearch);
            Name = "ProductoSearchView2";
            Text = "ProductoSearchView2";
            ((System.ComponentModel.ISupportInitialize)dtg_productoSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_seleccionar_productoSearch;
        private Button btn_cancelar_productoSearch;
        private DataGridView dtg_productoSearch;
    }
}