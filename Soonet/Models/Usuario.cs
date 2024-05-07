using System.ComponentModel.DataAnnotations;

namespace Soonet.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        public string IdIdentity { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public long Document { get; set; }
        public string Address { get; set; }
    }
}
