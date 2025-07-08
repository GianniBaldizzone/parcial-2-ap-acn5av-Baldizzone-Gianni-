using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameTome.Modelos
{
    public class Serie
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Activo { get; set; }

        public int IdCategoria { get; set; }
        public string Foto { get; set; }


        // Constructores
        public Serie() { }

        public Serie(int id, string nombre, DateTime fechaCreacion, DateTime? fechaModificacion, int idBiblioteca, bool activo, int idcategoria, string foto)
        {
            Id = id;
            Nombre = nombre;
            FechaModificacion = fechaModificacion;
            Activo = activo;
            IdCategoria = idcategoria;
            Foto = foto;
        }
    }
}

