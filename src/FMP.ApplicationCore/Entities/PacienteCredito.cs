using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class PacienteCredito
    {
        public PacienteCredito()
        {
        }

        public int PacienteCreditoId { get; set; }

        public int PacienteId { get; set; }

        public decimal Valor { get; set; }

        public int IdTipoPagamento { get; set; }

        public bool Compensado { get; set; }

        public int QtdCreditos { get; set; }

        public DateTime Data { get; set; }
        
        public Paciente Paciente { get; set; }

        public TipoPagamento TipoPagamento { get; set; }

    }
}
