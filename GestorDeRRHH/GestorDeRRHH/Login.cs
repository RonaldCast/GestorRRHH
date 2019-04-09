using CapaBusiness;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeRRHH
{
    public partial class Login : Form
    {
        private BusinessUser BUser;
        public Login()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BUser= new BusinessUser();
          
        }

        private void ValidateUser()
        {
            int number = 0;
            foreach (User user in BUser.SelectUser())
            {
                if (user.NameUser == txtUser.Text && user.Password == txtPassword.Text)
                {
                    number++;
                    MessageBox.Show(string.Format("Bienvenido {0} al Gestor de Recursos Humanos", user.NameUser), "");
                    break;
                }
            }

            if (number == 1)
            {
                this.Hide();
                fPrincipal fPrincipal = new fPrincipal();
                fPrincipal.Show();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña estan incorrectos","");

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //this.ShowInTaskbar = false; //para manipular la pilas de llamadas y se puda abrir el form
            // this.Close();
        }
    }
}
