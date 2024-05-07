using System.ComponentModel.DataAnnotations;

namespace Soonet.Models
{
    public class Servicio
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public string Categoria { get; set; }

        public string NivelDificultad { get; set; }

        public int DuracionEstimada { get; set; }

        public DateTime FechaDisponibilidad { get; set; }

        // Otras propiedades del servicio...
    }
}
