using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soonet.Models
{
    public class Calificacion
    {
        [Key]
        public int ID { get; set; }

        public int ProveedorID { get; set; }

        public int UsuarioID { get; set; }

        public int Puntuacion { get; set; }

        public string Comentario { get; set; }

        [ForeignKey(nameof(ProveedorID))]
        public virtual ProveedorServicios? ProveedorServicios { get; set; }

        [ForeignKey(nameof(UsuarioID))]
        public virtual Usuario? Usuario { get; set; }

    }
}
