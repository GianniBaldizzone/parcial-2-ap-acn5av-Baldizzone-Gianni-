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
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.WorkingArea;

            Usuario usuariologueado = Program.UsuarioLogueado;

            lbl_usuario.Text = "Bienvenido: " + usuariologueado.NombreUsuario;

            if (usuariologueado.IdRol != 1)
            {
                this.OcultarBotonUsuarios();
            }

            // Interpretar el IdRol y mostrar el nombre del rol
            switch (usuariologueado.IdRol)
            {
                case 1:
                    lbl_rol.Text = "Rol: Administrador";
                    break;
                case 2:
                    lbl_rol.Text = "Rol: Usuario";
                    break;
                default:
                    lbl_rol.Text = "Rol: Desconocido";
                    break;
            }
        }

        private void btn_cerrarsesion_Click(object sender, EventArgs e)
        {

        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {

        }

        public void OcultarBotonUsuarios()
        {
            btn_usuarios.Visible = false;
        }
    }
}
