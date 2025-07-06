using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlameTome.Modelos;

namespace FlameTome.Frontend
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label3.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_autenticar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string contraseña = txt_contraseña.Text;

            var controlador = new Controladores.Controller_Usuario();

            Usuario usuarioAutenticado = controlador.HacerLogin(usuario, contraseña);

            if (usuarioAutenticado != null)
            {
                Program.UsuarioLogueado = usuarioAutenticado;
                label3.Text = "Inicio de sesión exitoso.";
                label3.ForeColor = Color.Green;

                this.Hide();
                PanelPrincipal panel = new PanelPrincipal();
                panel.Show();
            }
            else
            {
                
                label3.Text = "Usuario o contraseña incorrectos.";
                label3.Visible = true;
            }
        }



    }
}


