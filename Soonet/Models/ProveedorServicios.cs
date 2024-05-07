using System.ComponentModel.DataAnnotations;

namespace Soonet.Models
{
    public class ProveedorServicios
    {
        [Key]
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Especialidad { get; set; }

        public int ExperienciaEnAnios { get; set; }

    }
}
