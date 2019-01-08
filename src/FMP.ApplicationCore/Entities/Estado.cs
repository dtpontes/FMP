using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class Estado
    {
        public Estado()
        {
        }

        public int EstadoId { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }

    }
}
