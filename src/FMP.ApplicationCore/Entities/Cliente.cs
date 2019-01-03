using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public virtual ICollection<Contato> Contatos { get; set; }

        public  Endereco Endereco { get; set; }

        public virtual ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}
