using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace FlameTome.Controladores
{
    public class Controller_Base_De_Datos
    {
        private SqlConnection conexion;
        private readonly string cadenaConexion;

        // Constructor: definí tu cadena de conexión acá
        public Controller_Base_De_Datos()
        {
            // CAMBIAR ESTO según tu instancia y base de datos
            cadenaConexion = "Server=TU_SERVIDOR_SQL;Database=TU_BASE_DE_DATOS;Trusted_Connection=True;";
            conexion = new SqlConnection(cadenaConexion);
        }

        // Método para abrir conexión
        public bool AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return false;
            }
        }

        // Método para cerrar conexión
        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }

        // Método público para obtener la conexión activa
        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
