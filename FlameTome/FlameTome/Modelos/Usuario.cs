using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameTome.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int IdRol { get; set; }
        public bool Activo { get; set; }

        public Usuario()
        {
        
        }

        public Usuario(string nombreUsuario, string contraseña, int idRol)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            IdRol = idRol;
            FechaCreacion = DateTime.Now;
            Activo = true;
            FechaModificacion = null; // no tiene aún modificación
        }

        // Constructor para cargar un usuario con todos los datos (por ejemplo desde la base de datos)
        public Usuario(int id, string nombreUsuario, string contraseña, DateTime fechaCreacion, DateTime? fechaModificacion, int idRol, bool activo)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            FechaCreacion = fechaCreacion;
            FechaModificacion = fechaModificacion;
            IdRol = idRol;
            Activo = activo;
        }
    }

}
