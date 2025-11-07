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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewCabecera = new DataGridView();
            btn_buscar_comprobante = new Button();
            text_buscar_comprobante = new TextBox();
            l_lista_comprobantes = new Label();
            btn_ver_generarPDF = new Button();
            dataGridViewDetalle = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCabecera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalle).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCabecera
            // 
            dataGridViewCabecera.AllowUserToAddRows = false;
            dataGridViewCabecera.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCabecera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCabecera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCabecera.Location = new Point(113, 143);
            dataGridViewCabecera.MultiSelect = false;
            dataGridViewCabecera.Name = "dataGridViewCabecera";
            dataGridViewCabecera.ReadOnly = true;
            dataGridViewCabecera.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCabecera.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCabecera.Size = new Size(1186, 295);
            dataGridViewCabecera.TabIndex = 57;
            // 
            // btn_buscar_comprobante
            // 
            btn_buscar_comprobante.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_comprobante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_comprobante.Image = Properties.Resources.lupa;
            btn_buscar_comprobante.Location = new Point(1100, 61);
            btn_buscar_comprobante.Name = "btn_buscar_comprobante";
            btn_buscar_comprobante.Size = new Size(60, 43);
            btn_buscar_comprobante.TabIndex = 60;
            btn_buscar_comprobante.UseVisualStyleBackColor = false;
            // 
            // text_buscar_comprobante
            // 
            text_buscar_comprobante.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_comprobante.Location = new Point(499, 68);
            text_buscar_comprobante.Name = "text_buscar_comprobante";
            text_buscar_comprobante.Size = new Size(580, 31);
            text_buscar_comprobante.TabIndex = 59;
            // 
            // l_lista_comprobantes
            // 
            l_lista_comprobantes.BackColor = Color.White;
            l_lista_comprobantes.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_lista_comprobantes.Location = new Point(113, 51);
            l_lista_comprobantes.Name = "l_lista_comprobantes";
            l_lista_comprobantes.Size = new Size(1186, 66);
            l_lista_comprobantes.TabIndex = 58;
            l_lista_comprobantes.Text = "Lista de comprobantes";
            l_lista_comprobantes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_ver_generarPDF
            // 
            btn_ver_generarPDF.BackColor = Color.LightCoral;
            btn_ver_generarPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ver_generarPDF.Location = new Point(1077, 454);
            btn_ver_generarPDF.Name = "btn_ver_generarPDF";
            btn_ver_generarPDF.Size = new Size(222, 43);
            btn_ver_generarPDF.TabIndex = 61;
            btn_ver_generarPDF.Text = "Descargar PDF";
            btn_ver_generarPDF.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDetalle
            // 
            dataGridViewDetalle.AllowUserToAddRows = false;
            dataGridViewDetalle.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalle.Location = new Point(113, 454);
            dataGridViewDetalle.MultiSelect = false;
            dataGridViewDetalle.Name = "dataGridViewDetalle";
            dataGridViewDetalle.ReadOnly = true;
            dataGridViewDetalle.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewDetalle.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDetalle.Size = new Size(927, 273);
            dataGridViewDetalle.TabIndex = 62;
            // 
            // VendedorComprobanteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 782);
            Controls.Add(dataGridViewDetalle);
            Controls.Add(btn_ver_generarPDF);
            Controls.Add(btn_buscar_comprobante);
            Controls.Add(text_buscar_comprobante);
            Controls.Add(l_lista_comprobantes);
            Controls.Add(dataGridViewCabecera);
            Name = "VendedorComprobanteView";
            Text = "VendedorComprobanteView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCabecera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCabecera;
        private Button btn_buscar_comprobante;
        private TextBox text_buscar_comprobante;
        private Label l_lista_comprobantes;
        private Button btn_ver_generarPDF;
        private DataGridView dataGridViewDetalle;
    }
}