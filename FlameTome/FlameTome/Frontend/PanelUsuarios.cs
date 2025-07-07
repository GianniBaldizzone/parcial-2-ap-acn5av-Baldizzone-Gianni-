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
        private int paginaActual = 1;
        private int tamanioPagina = 17;

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
                List<Usuario> usuarios = controlador.ObtenerUsuariosPaginados(paginaActual, tamanioPagina);

                tabla_usuarios.AutoGenerateColumns = false;
                tabla_usuarios.Rows.Clear();

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

                // Actualizar label de página
                lbl_pagina.Text = $"Página {paginaActual}";

                // Control de botones
                btnAnterior.Enabled = paginaActual > 1;
                btnSiguiente.Enabled = usuarios.Count == tamanioPagina;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }
        

  

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            paginaActual++;
            CargarUsuarios();
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarUsuarios();
            }
        }
    }
}
