using System.ComponentModel.DataAnnotations;

namespace TicketControl.Models
{
    public class TicketViewModel
    {
        public int Id { get; set; }

        public bool WasUsed { get; set; }

        [Display(Name = "Documento del usuario")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Document { get; set; }

        [Display(Name = "Nombres y apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Name { get; set; }

        [Display(Name = "Fecha y hora del ingreso")]
        public DateTime? Date { get; set; }

        [Display(Name = "Entrada")]
        public int? EntranceId { get; set; }
    }
}
