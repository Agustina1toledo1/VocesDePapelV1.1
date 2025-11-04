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
using VocesDePapelV1._1.Servicios;

namespace VocesDePapelV1._1.Views
{
    public partial class LoginView : Form
    {
       
        private readonly AuthService _authService;

        public UsuarioModel? UsuarioAutenticado { get; private set; }
        public bool AutenticacionExitosa { get; private set; }

        // ✅ Constructor vacio 
        public LoginView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Constructor que recibe el AuthService
        public LoginView(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
            
            this.StartPosition = FormStartPosition.CenterScreen;
            // Inicializa propiedades
            UsuarioAutenticado = null;
            AutenticacionExitosa = false;

            // eventos para los botones 
            btn_ingresar_login.Click += BtnIngresar_Click;
            btn_cancelar_login.Click += BtnCancelar_Click;

            // Enter key en el campo de contraseña
            text_clave_login.KeyPress += TxtClave_KeyPress;
        }

        //Evento del botón Ingresar
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            AutenticarUsuario(text_cuit_login.Text, text_clave_login.Text);
        }

        // Evento del botón Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Enter key en campo de contraseña
        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AutenticarUsuario(text_cuit_login.Text, text_clave_login.Text);
                e.Handled = true;
            }
        }

        // Método principal de autenticación
        private void AutenticarUsuario(string cuit, string contrasenia)
        {
            // Limpiar mensajes anteriores
            lblMensaje_login.Text = "";
            lblMensaje_login.ForeColor = Color.Red;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(cuit) || string.IsNullOrWhiteSpace(contrasenia))
            {
                lblMensaje_login.Text = "Por favor, complete todos los campos.";
                return;
            }

            // Valida formato CUIT
            cuit = cuit.Trim();
            if (cuit.Length != 11 || !cuit.All(char.IsDigit))
            {
                lblMensaje_login.Text = "El CUIT debe tener exactamente 11 dígitos.";
                return;
            }

            try
            {
                //Mostrar indicador de carga 
                btn_ingresar_login.Enabled = false;
                btn_ingresar_login.Text = "Autenticando...";

                // Intenta autenticar
                var usuario = _authService.Autenticar(cuit, contrasenia);

                if (usuario != null)
                {
                    // Login exitoso
                    UsuarioAutenticado = usuario;
                    AutenticacionExitosa = true;

                    lblMensaje_login.ForeColor = Color.Green;
                    lblMensaje_login.Text = "¡Autenticación exitosa!";

                    // Pequeña pausa para mostrar el mensaje de éxito
                    Task.Delay(500).ContinueWith(t =>
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }));
                    });
                }
                else
                {
                    lblMensaje_login.Text = "CUIT o contraseña incorrectos.\nO el usuario puede estar inactivo.";
                    btn_ingresar_login.Enabled = true;
                    btn_ingresar_login.Text = "Ingresar";
                }
            }
            catch (Exception ex)
            {
                lblMensaje_login.Text = $"Error al autenticar: {ex.Message}";
                btn_ingresar_login.Enabled = true;
                btn_ingresar_login.Text = "Ingresar";
            }
        }
    }
}
 
