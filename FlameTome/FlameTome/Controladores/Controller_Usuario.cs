using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FlameTome.Controladores
{
    public class Controller_Usuario : Controller_Base_De_Datos
    {
        // Registrar un nuevo usuario
        public bool RegistrarUsuario(string nombreUsuario, string contraseña, int idRol)
        {
            string contraseñaHash = GenerarHashContraseña(contraseña);

            string query = @"INSERT INTO usuarios (nombre_usuario, contraseña, fecha_creacion, activo, id_rol) 
                         VALUES (@nombre_usuario, @contraseña, @fecha_creacion, @activo, @id_rol)";

            try
            {
                AbrirConexion();

                using (SqlCommand comando = new SqlCommand(query, ObtenerConexion()))
                {
                    comando.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseñaHash);
                    comando.Parameters.AddWithValue("@fecha_creacion", DateTime.Now);
                    comando.Parameters.AddWithValue("@activo", 1);
                    comando.Parameters.AddWithValue("@id_rol", idRol);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar usuario: " + ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        // Login de usuario
        public bool HacerLogin(string nombreUsuario, string contraseña)
        {
            string contraseñaHash = GenerarHashContraseña(contraseña);

            string query = @"SELECT 1 FROM usuarios 
                         WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña AND activo = 1";

            try
            {
                AbrirConexion();

                using (SqlCommand comando = new SqlCommand(query, ObtenerConexion()))
                {
                    comando.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseñaHash);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al hacer login: " + ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        // Hasheo de contraseña con SHA256
        private string GenerarHashContraseña(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }

}
