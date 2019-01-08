using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class Profissao
    {
        public Profissao()
        {
        }

        public int ProfissaoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string CBO { get; set; }

        public virtual ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}
