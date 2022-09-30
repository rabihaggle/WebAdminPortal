using System;
using System.Collections.Generic;

namespace WebAdminPortal.Models
{
    public partial class _90InformesParametro
    {
        public _90InformesParametro()
        {
            _80UsuarioInformes = new HashSet<_80UsuarioInforme>();
        }

        public int IdInforme { get; set; }
        public string? NombreInforme { get; set; }
        public string? TipoInforme { get; set; }
        public string? Observaciones { get; set; }

        public virtual ICollection<_80UsuarioInforme> _80UsuarioInformes { get; set; }
    }
}
