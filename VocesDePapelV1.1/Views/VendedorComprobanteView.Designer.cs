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
            dataGridViewDetalles = new DataGridView();
            btn_buscar_usuario = new Button();
            text_buscar_usuario = new TextBox();
            l_lista_comprobantes = new Label();
            btn_guardar_usuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDetalles
            // 
            dataGridViewDetalles.AllowUserToAddRows = false;
            dataGridViewDetalles.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalles.Location = new Point(113, 128);
            dataGridViewDetalles.MultiSelect = false;
            dataGridViewDetalles.Name = "dataGridViewDetalles";
            dataGridViewDetalles.ReadOnly = true;
            dataGridViewDetalles.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewDetalles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDetalles.Size = new Size(927, 571);
            dataGridViewDetalles.TabIndex = 57;
            // 
            // btn_buscar_usuario
            // 
            btn_buscar_usuario.BackColor = SystemColors.GradientActiveCaption;
            btn_buscar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_usuario.Image = Properties.Resources.lupa;
            btn_buscar_usuario.Location = new Point(970, 50);
            btn_buscar_usuario.Name = "btn_buscar_usuario";
            btn_buscar_usuario.Size = new Size(55, 43);
            btn_buscar_usuario.TabIndex = 60;
            btn_buscar_usuario.UseVisualStyleBackColor = false;
            // 
            // text_buscar_usuario
            // 
            text_buscar_usuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_buscar_usuario.Location = new Point(499, 57);
            text_buscar_usuario.Name = "text_buscar_usuario";
            text_buscar_usuario.Size = new Size(445, 31);
            text_buscar_usuario.TabIndex = 59;
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
            // btn_guardar_usuario
            // 
            btn_guardar_usuario.BackColor = Color.LightGreen;
            btn_guardar_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar_usuario.Location = new Point(1060, 128);
            btn_guardar_usuario.Name = "btn_guardar_usuario";
            btn_guardar_usuario.Size = new Size(269, 43);
            btn_guardar_usuario.TabIndex = 61;
            btn_guardar_usuario.Text = "Ver detalle";
            btn_guardar_usuario.UseVisualStyleBackColor = false;
            // 
            // VendedorComprobanteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 731);
            Controls.Add(btn_guardar_usuario);
            Controls.Add(btn_buscar_usuario);
            Controls.Add(text_buscar_usuario);
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
        private Button btn_buscar_usuario;
        private TextBox text_buscar_usuario;
        private Label l_lista_comprobantes;
        private Button btn_guardar_usuario;
    }
}