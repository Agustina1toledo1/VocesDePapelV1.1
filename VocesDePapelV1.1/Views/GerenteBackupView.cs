using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Views
{
    public partial class GerenteBackupView : Form, IGerenteBackupView
    {
        private string message;
        private bool isSuccessful;
        public GerenteBackupView()
        {
            InitializeComponent();
        }
        //singleton patron (abre una sola instancia del formulario) 
        private static GerenteBackupView instance;

        public event EventHandler GenerarBackupEvent;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        //singleton patron (abre una sola instancia del formulario)
        public static GerenteBackupView GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new GerenteBackupView();
                instance.MdiParent = parentConteiner; //establecer el formulario padre
                instance.FormBorderStyle = FormBorderStyle.None; //sin bordes
                instance.Dock = DockStyle.Fill; //llenar el contenedor
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)//si esta minimizado, restaurar
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();//si ya existe, traer al frente

            }
            return instance;
        }
    }
}
