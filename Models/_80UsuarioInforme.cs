using System;
using System.Collections.Generic;

namespace WebAdminPortal.Models
{
    public partial class _80UsuarioInforme
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public int? IdInforme { get; set; }
        public int? Activo { get; set; }
        public string? UsuarioRelacion { get; set; }

        public virtual _90InformesParametro? IdInformeNavigation { get; set; }
    }
}
