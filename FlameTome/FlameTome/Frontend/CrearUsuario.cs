using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlameTome.Controladores;
using Guna.UI2.WinForms;

namespace FlameTome.Frontend
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
            CargarRoles();

        }

        private void CargarRoles()
        {
            Controller_Base_De_Datos db = new Controller_Base_De_Datos();
            List<Modelos.Rol> listaRoles = new List<Modelos.Rol>();

            if (db.AbrirConexion())
            {
                string query = "SELECT ID, Nombre FROM roles";

                using (SqlCommand cmd = new SqlCommand(query, db.ObtenerConexion()))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaRoles.Add(new Modelos.Rol
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }

                db.CerrarConexion();

                idRolSeleccionado.DataSource = listaRoles;
                idRolSeleccionado.DisplayMember = "Nombre";
                idRolSeleccionado.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
            }
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim().Replace(" ", "");
            string contraseña = txtContraseña.Text.Trim().Replace(" ", "");
            string repetirContraseña = txtRepetirContraseña.Text.Trim().Replace(" ", "");

            if (string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(repetirContraseña) ||
                this.idRolSeleccionado.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contraseña.Length > 16)
            {
                MessageBox.Show("La contraseña no puede superar los 16 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contraseña.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("La contraseña no puede ser igual al nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contraseña != repetirContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden. Verificalas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idRolSeleccionado = Convert.ToInt32(this.idRolSeleccionado.SelectedValue);
            if (idRolSeleccionado != 1 && idRolSeleccionado != 2)
            {
                MessageBox.Show("El rol seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var controlador = new Controladores.Controller_Usuario();

            if (controlador.UsuarioExiste(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario ya está en uso. Elegí otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (controlador.ContraseñaYaUsada(contraseña))
            {
                MessageBox.Show("Esa contraseña ya fue utilizada por otro usuario. Por seguridad, usá una diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Modelos.Usuario nuevoUsuario = new Modelos.Usuario
            {
                NombreUsuario = nombreUsuario,
                Contraseña = contraseña, // sin hashear
                IdRol = idRolSeleccionado,
                FechaCreacion = DateTime.Now,
                Activo = true
            };

            bool creado = controlador.CrearUsuario(nuevoUsuario);

            if (creado)
            {
                MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
