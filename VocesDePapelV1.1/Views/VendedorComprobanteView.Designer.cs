namespace VocesDePapelV1._1.Views
{
    partial class VendedorComprobanteView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewDetalles = new DataGridView();
            btn_buscar_comprobante = new Button();
            text_buscar_comprobante = new TextBox();
            l_lista_comprobantes = new Label();
            btn_ver_detalle_comprobante = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDetalles
            // 
            dataGridViewDetalles.AllowUserToAddRows = false;
            dataGridViewDetalles.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalles.Location = new Point(113, 128);
            dataGridViewDetalles.MultiSelect = false;
            dataGridViewDetalles.Name = "dataGridViewDetalles";
            dataGridViewDetalles.ReadOnly = true;
            dataGridViewDetalles.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewDetalles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDetalles.Size = new Size(927, 571);
            dataGridViewDetalles.TabIndex = 57;
            // 
            // btn_buscar_comprobante
            // 
            btn_buscar_comprobante.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_comprobante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_comprobante.Image = Properties.Resources.lupa;
            btn_buscar_comprobante.Location = new Point(970, 50);
            btn_buscar_comprobante.Name = "btn_buscar_comprobante";
            btn_buscar_comprobante.Size = new Size(55, 43);
            btn_buscar_comprobante.TabIndex = 60;
            btn_buscar_comprobante.UseVisualStyleBackColor = false;
            // 
            // text_buscar_comprobante
            // 
            text_buscar_comprobante.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_comprobante.Location = new Point(499, 57);
            text_buscar_comprobante.Name = "text_buscar_comprobante";
            text_buscar_comprobante.Size = new Size(445, 31);
            text_buscar_comprobante.TabIndex = 59;
            // 
            // l_lista_comprobantes
            // 
            l_lista_comprobantes.BackColor = Color.White;
            l_lista_comprobantes.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_comprobantes.Location = new Point(113, 40);
            l_lista_comprobantes.Name = "l_lista_comprobantes";
            l_lista_comprobantes.Size = new Size(927, 66);
            l_lista_comprobantes.TabIndex = 58;
            l_lista_comprobantes.Text = "Lista de comprobantes";
            l_lista_comprobantes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_ver_detalle_comprobante
            // 
            btn_ver_detalle_comprobante.BackColor = Color.LightGreen;
            btn_ver_detalle_comprobante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ver_detalle_comprobante.Location = new Point(1060, 128);
            btn_ver_detalle_comprobante.Name = "btn_ver_detalle_comprobante";
            btn_ver_detalle_comprobante.Size = new Size(269, 43);
            btn_ver_detalle_comprobante.TabIndex = 61;
            btn_ver_detalle_comprobante.Text = "Ver detalle";
            btn_ver_detalle_comprobante.UseVisualStyleBackColor = false;
            // 
            // VendedorComprobanteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 731);
            Controls.Add(btn_ver_detalle_comprobante);
            Controls.Add(btn_buscar_comprobante);
            Controls.Add(text_buscar_comprobante);
            Controls.Add(l_lista_comprobantes);
            Controls.Add(dataGridViewDetalles);
            Name = "VendedorComprobanteView";
            Text = "VendedorComprobanteView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDetalles;
        private Button btn_buscar_comprobante;
        private TextBox text_buscar_comprobante;
        private Label l_lista_comprobantes;
        private Button btn_ver_detalle_comprobante;
    }
}