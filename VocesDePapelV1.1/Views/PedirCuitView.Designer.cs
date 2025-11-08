namespace VocesDePapelV1._1.Views
{
    partial class Cuit
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
            txtCuit = new TextBox();
            lCuit = new Label();
            btnCancelar = new Button();
            BtnAceptar = new Button();
            SuspendLayout();
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(99, 77);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(180, 27);
            txtCuit.TabIndex = 0;
            // 
            // lCuit
            // 
            lCuit.Location = new Point(99, 48);
            lCuit.Name = "lCuit";
            lCuit.Size = new Size(60, 26);
            lCuit.TabIndex = 1;
            lCuit.Text = "Cuit:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(250, 128);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 38);
            btnCancelar.TabIndex = 63;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = Color.LightGreen;
            BtnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAceptar.Location = new Point(99, 133);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(97, 33);
            BtnAceptar.TabIndex = 64;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // Cuit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 213);
            Controls.Add(BtnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lCuit);
            Controls.Add(txtCuit);
            Name = "Cuit";
            Text = "Cuit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCuit;
        private Label lCuit;
        private Button btnCancelar;
        private Button BtnAceptar;
    }
}