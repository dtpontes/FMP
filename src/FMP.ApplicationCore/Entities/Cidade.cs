using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class Cidade
    {
        public Cidade()
        {
        }

        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public string Descricao { get; set; }
        
        public Estado Estado { get; set; }        

    }
}
