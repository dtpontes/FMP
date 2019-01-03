using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class ProfissaoCliente
    {
        public ProfissaoCliente()
        {

        }

        public  int ProfissaoClienteId { get; set;}

        public int ClienteId { get; set;}

        public int ProfissaoId { get; set; }

        public Cliente Cliente { get; set; }

        public Profissao Profissao { get; set; }
    }
}
