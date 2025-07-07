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
    public partial class PanelUsuarios : UserControl
    {
        public PanelUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }


        private void CargarUsuarios()
        {
            try
            {
                var controlador = new Controladores.Controller_Usuario();
                List<Usuario> usuarios = controlador.ObtenerTodosLosUsuarios();

                // Desactivamos generación automática y limpiamos
                tabla_usuarios.AutoGenerateColumns = false;
                tabla_usuarios.Rows.Clear();

                // Cargar cada usuario en la tabla
                foreach (var u in usuarios)
                {
                    tabla_usuarios.Rows.Add(
                        u.Id,
                        u.NombreUsuario,
                        u.Contraseña,
                        u.FechaCreacion.ToShortDateString(),
                        u.FechaModificacion?.ToShortDateString() ?? "",
                        u.IdRol,
                        u.Activo ? "Sí" : "No"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }
    }
}
