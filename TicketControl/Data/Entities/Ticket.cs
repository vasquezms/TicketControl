using System.ComponentModel.DataAnnotations;

namespace TicketControl.Data.Entities
{
    public class Ticket

    {
        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }
        public DateTime Date { get; set; }
        public Entrance Entrance { get; set; }
        public int Id { get; set; }

        [Display(Name = "Nombres y Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Name { get; set; }

        public bool WasUsed { get; set; }

    }
}
