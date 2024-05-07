using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soonet.Models
{
    public class SeccionServicio
    {
        [Key]
        public int ID { get; set; }

        public int ServicioID { get; set; }

        public string Titulo { get; set; }

        public string Contenido { get; set; }

        public string Recursos { get; set; }

        [ForeignKey(nameof(ServicioID))]
        public virtual Servicio Servicio { get; set; }
    }
}
