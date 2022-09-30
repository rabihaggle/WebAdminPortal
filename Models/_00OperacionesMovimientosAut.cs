using System;
using System.Collections.Generic;

namespace WebAdminPortal.Models
{
    public partial class _00OperacionesMovimientosAut
    {
        public int Id { get; set; }
        public string? DidNumeroOperacion { get; set; }
        public string? DidCodMatriculaContenedor { get; set; }
        public DateTime? FechaActualizaciónRegistro { get; set; }
        public DateTime? FechaExpectedTime { get; set; }
        public DateTime? FechaActualTime { get; set; }
        public string? TipoEvento { get; set; }
    }
}
