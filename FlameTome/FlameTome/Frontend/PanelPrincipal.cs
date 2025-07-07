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
            // Limpiar controles previos en el panel
            panel_contenedor.Controls.Clear();

            // Crear instancia del UserControl
            PanelUsuarios usuariosControl = new PanelUsuarios();

            // Configurar para que ocupe todo el panel
            usuariosControl.Dock = DockStyle.Fill;

            // Agregar al panel contenedor
            panel_contenedor.Controls.Add(usuariosControl);
        }

        private void AbrirFormularioEnPanel(object formHijo)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
        }

        public void OcultarBotonUsuarios()
        {
            btn_usuarios.Visible = false;
        }
    }
}
