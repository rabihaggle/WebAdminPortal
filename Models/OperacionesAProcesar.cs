using System;
using System.Collections.Generic;

namespace WebAdminPortal.Models
{
    public partial class OperacionesAProcesar
    {
        public int Id { get; set; }
        public string? NumeroOperacion { get; set; }
        public string? Navieras { get; set; }
        public string? Flujo { get; set; }
        public string? CodMatriculaContenedor { get; set; }
        public string? Usuario { get; set; }
    }
}
