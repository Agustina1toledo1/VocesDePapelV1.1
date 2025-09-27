namespace VocesDePapelV1._1.Views
{
    partial class LoginView
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
            panel1 = new Panel();
            btn_cancelar_login = new Button();
            text_cuit_login = new TextBox();
            btn_ingresar_login = new Button();
            l_usuario = new Label();
            text_clave_login = new TextBox();
            l_clave__login = new Label();
            lblMensaje_login = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblMensaje_login);
            panel1.Controls.Add(btn_cancelar_login);
            panel1.Controls.Add(text_cuit_login);
            panel1.Controls.Add(btn_ingresar_login);
            panel1.Controls.Add(l_usuario);
            panel1.Location = new Point(182, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 373);
            panel1.TabIndex = 0;
            // 
            // btn_cancelar_login
            // 
            btn_cancelar_login.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar_login.Image = Properties.Resources.boton_eliminar;
            btn_cancelar_login.Location = new Point(58, 280);
            btn_cancelar_login.Name = "btn_cancelar_login";
            btn_cancelar_login.Size = new Size(316, 43);
            btn_cancelar_login.TabIndex = 38;
            btn_cancelar_login.Text = "Cancelar";
            btn_cancelar_login.TextAlign = ContentAlignment.MiddleRight;
            btn_cancelar_login.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar_login.UseVisualStyleBackColor = false;
            // 
            // text_cuit_login
            // 
            text_cuit_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_cuit_login.Location = new Point(58, 78);
            text_cuit_login.Name = "text_cuit_login";
            text_cuit_login.Size = new Size(316, 34);
            text_cuit_login.TabIndex = 2;
            // 
            // btn_ingresar_login
            // 
            btn_ingresar_login.BackColor = SystemColors.GradientActiveCaption;
            btn_ingresar_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar_login.Image = Properties.Resources.salida;
            btn_ingresar_login.ImageAlign = ContentAlignment.MiddleRight;
            btn_ingresar_login.Location = new Point(58, 218);
            btn_ingresar_login.Name = "btn_ingresar_login";
            btn_ingresar_login.Size = new Size(316, 43);
            btn_ingresar_login.TabIndex = 37;
            btn_ingresar_login.Text = "Ingresar";
            btn_ingresar_login.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ingresar_login.UseVisualStyleBackColor = false;
            // 
            // l_usuario
            // 
            l_usuario.AutoSize = true;
            l_usuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            l_usuario.Location = new Point(58, 39);
            l_usuario.Name = "l_usuario";
            l_usuario.Size = new Size(56, 28);
            l_usuario.TabIndex = 1;
            l_usuario.Text = "CUIT";
            // 
            // text_clave_login
            // 
            text_clave_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_clave_login.Location = new Point(242, 216);
            text_clave_login.Name = "text_clave_login";
            text_clave_login.Size = new Size(316, 34);
            text_clave_login.TabIndex = 4;
            // 
            // l_clave__login
            // 
            l_clave__login.AutoSize = true;
            l_clave__login.BackColor = Color.White;
            l_clave__login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            l_clave__login.Location = new Point(242, 177);
            l_clave__login.Name = "l_clave__login";
            l_clave__login.Size = new Size(58, 28);
            l_clave__login.TabIndex = 3;
            l_clave__login.Text = "clave";
            // 
            // lblMensaje_login
            // 
            lblMensaje_login.ForeColor = Color.Red;
            lblMensaje_login.Location = new Point(66, 326);
            lblMensaje_login.Name = "lblMensaje_login";
            lblMensaje_login.Size = new Size(300, 40);
            lblMensaje_login.TabIndex = 5;
            lblMensaje_login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(text_clave_login);
            Controls.Add(l_clave__login);
            Controls.Add(panel1);
            Name = "LoginView";
            Text = "LoginView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox text_cuit_login;
        private Label l_usuario;
        private TextBox text_clave_login;
        private Label l_clave__login;
        private Button btn_cancelar_login;
        private Button btn_ingresar_login;
        private Label lblMensaje_login;
    }
}