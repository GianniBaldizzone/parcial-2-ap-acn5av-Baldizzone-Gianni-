using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlameTome.Modelos;

namespace FlameTome.Controladores
{
    public class Controller_Serie : Controller_Base_De_Datos
    {
        // Método para crear una nueva serie
        public bool CrearSerie(Serie nuevaSerie)
        {
            try
            {
                if (AbrirConexion())
                {
                    string query = @"INSERT INTO serie (nombre, fecha_modificacion, activo, foto, id_categoria)
                             VALUES (@nombre, @fechaModificacion, @activo, @foto, @idCategoria)";

                    using (SqlCommand cmd = new SqlCommand(query, ObtenerConexion()))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nuevaSerie.Nombre);
                        // Para creación inicial podés enviar NULL o DateTime.Now para fecha_modificacion, según lógica
                        cmd.Parameters.AddWithValue("@fechaModificacion", (object)nuevaSerie.FechaModificacion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@activo", nuevaSerie.Activo ? 1 : 0);
                        cmd.Parameters.AddWithValue("@foto", (object)nuevaSerie.Foto ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@idCategoria", nuevaSerie.IdCategoria);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al crear serie: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return false;
        }

        // Método para obtener todas las series activas
        public List<Serie> ObtenerSeries()
        {
            List<Serie> lista = new List<Serie>();

            try
            {
                if (AbrirConexion())
                {
                    string query = @"SELECT id, nombre, fecha_modificacion, activo, foto, id_categoria
                             FROM serie
                             WHERE activo = 1";

                    using (SqlCommand cmd = new SqlCommand(query, ObtenerConexion()))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Serie s = new Serie
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                FechaModificacion = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2),
                                Activo = reader.GetByte(3) == 1,
                                Foto = reader.IsDBNull(4) ? null : reader.GetString(4),
                                IdCategoria = reader.GetInt32(5)
                            };

                            lista.Add(s);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener series: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return lista; // ✅ Esto garantiza que siempre se devuelve algo
        }

    }
}
