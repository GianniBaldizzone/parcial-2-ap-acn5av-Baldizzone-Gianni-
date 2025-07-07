using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using FlameTome.Modelos;

namespace FlameTome.Controladores
{
    public class Controller_Usuario : Controller_Base_De_Datos
    {
        // obtener lista de usuarios

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            var db = new Controller_Base_De_Datos();

            try
            {
                if (db.AbrirConexion())
                {
                    SqlCommand comando = new SqlCommand("SELECT id, nombre_usuario, contraseña, fecha_creacion, fecha_modificacion, id_rol, activo FROM usuarios", db.ObtenerConexion());
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        // Leemos activo como int (TINYINT en BD)
                        int activoInt = reader.GetByte(6); // GetByte es mejor para tinyint

                        Usuario u = new Usuario(
                            id: reader.GetInt32(0),
                            nombreUsuario: reader.GetString(1),
                            contraseña: reader.GetString(2),
                            fechaCreacion: reader.GetDateTime(3),
                            fechaModificacion: reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                            idRol: reader.GetInt32(5),
                            activo: activoInt == 1 ? true : false
                        );

                        lista.Add(u);
                    }

                    reader.Close();
                    db.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios: " + ex.Message);
            }

            return lista;
        }

        public List<Usuario> ObtenerUsuariosPaginados(int pagina, int cantidadPorPagina)
        {
            List<Usuario> lista = new List<Usuario>();
            var db = new Controller_Base_De_Datos();

            try
            {
                if (db.AbrirConexion())
                {
                    string query = @"
                SELECT id, nombre_usuario, contraseña, fecha_creacion, fecha_modificacion, id_rol, activo
                FROM usuarios
                ORDER BY id
                OFFSET @Offset ROWS
                FETCH NEXT @Cantidad ROWS ONLY";

                    SqlCommand comando = new SqlCommand(query, db.ObtenerConexion());
                    comando.Parameters.AddWithValue("@Offset", (pagina - 1) * cantidadPorPagina);
                    comando.Parameters.AddWithValue("@Cantidad", cantidadPorPagina);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        int activoInt = reader.GetByte(6);

                        Usuario u = new Usuario(
                            id: reader.GetInt32(0),
                            nombreUsuario: reader.GetString(1),
                            contraseña: reader.GetString(2),
                            fechaCreacion: reader.GetDateTime(3),
                            fechaModificacion: reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                            idRol: reader.GetInt32(5),
                            activo: activoInt == 1
                        );

                        lista.Add(u);
                    }

                    reader.Close();
                    db.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios paginados: " + ex.Message);
            }

            return lista;
        }

        public bool CrearUsuario(Usuario usuario)
        {
            string query = @"INSERT INTO usuarios 
                     (nombre_usuario, contraseña, id_rol, fecha_creacion, activo)
                     VALUES 
                     (@nombre_usuario, @contraseña, @id_rol, @fecha_creacion, @activo)";

            try
            {
                if (AbrirConexion())
                {
                    using (SqlCommand comando = new SqlCommand(query, ObtenerConexion()))
                    {
                        comando.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                        comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                        comando.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                        comando.Parameters.AddWithValue("@fecha_creacion", usuario.FechaCreacion);
                        comando.Parameters.AddWithValue("@activo", usuario.Activo ? 1 : 0); // tinyint

                        int filasAfectadas = comando.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return false;
        }

        public bool UsuarioExiste(string nombreUsuario)
        {
            string query = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombre";

            try
            {
                if (AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return false;
        }

        public bool ContraseñaYaUsada(string contraseñaPlano)
        {
            string query = "SELECT COUNT(*) FROM usuarios WHERE contraseña = @contraseña";

            try
            {
                if (AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@contraseña", contraseñaPlano);
                        int cantidad = (int)cmd.ExecuteScalar();
                        return cantidad > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar contraseña: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return false;
        }

        // Login de usuario
        public Usuario HacerLogin(string nombreUsuario, string contraseña)
        {
            string query = @"SELECT id, nombre_usuario, contraseña, fecha_creacion, 
                            fecha_modificacion, id_rol, activo 
                     FROM usuarios 
                     WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña AND activo = 1";

            try
            {
                AbrirConexion();

                using (SqlCommand comando = new SqlCommand(query, ObtenerConexion()))
                {
                    comando.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario(
                                reader.GetString(1),          // nombre_usuario
                                reader.GetString(2),          // contraseña
                                reader.GetInt32(5)            // id_rol
                            )
                            {
                                Id = reader.GetInt32(0),                       // id_usuario
                                FechaCreacion = reader.GetDateTime(3),         // fecha_creacion
                                FechaModificacion = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                                Activo = Convert.ToBoolean(reader.GetByte(6))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return null;
        }
    }

}
