using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAdminPortal.Models.ViewModels
{
    public class InformesViewModels
    {
        [Required]
        [Display(Name = "Nombre del Informe")]
        public string? NombreInforme { get; set; }
        [Required]
        [Display(Name = "Tipo de Informe")]
        public string? TipoInforme { get; set; }
        [Required]
        [Display(Name = "Observaciones para el usuario")]
        public string? Observaciones { get; set; }

    }
}
